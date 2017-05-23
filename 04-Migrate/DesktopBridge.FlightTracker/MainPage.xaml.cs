using System;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.ApplicationModel.AppService;
using Windows.ApplicationModel.Background;
using Windows.Data.Xml.Dom;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.System.Profile;
using Windows.UI.Notifications;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DesktopBridge.FlightTracker
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            (Application.Current as App).StatusUpdated += MainPage_StatusUpdated;
        }

        private async void MainPage_StatusUpdated(object sender, string e)
        {
            //the Win32 app has initialized the channel with the App Service, so we hide the ProgressRing
            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
            {
                progressBar.IsActive = false;
            });
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            progressBar.IsActive = true;
            //if it exists, we load the data about the flight from the local storage and we display it
            if (ApplicationData.Current.LocalSettings.Values.ContainsKey("Code"))
            {
                codeTextbox.Text = ApplicationData.Current.LocalSettings.Values["Code"].ToString();
            }

            if (ApplicationData.Current.LocalSettings.Values.ContainsKey("Date"))
            {
                dateTextbox.Text = ApplicationData.Current.LocalSettings.Values["Date"].ToString();
            }

            if (ApplicationData.Current.LocalSettings.Values.ContainsKey("Departure"))
            {
                departureTextbox.Text = ApplicationData.Current.LocalSettings.Values["Departure"].ToString();
            }

            if (ApplicationData.Current.LocalSettings.Values.ContainsKey("Arrival"))
            {
                arrivalTextbox.Text = ApplicationData.Current.LocalSettings.Values["Arrival"].ToString();
            }

            //we check if the app is running on the desktop: only if that's the case, we leverage the Desktop Bridge specific features
            if (AnalyticsInfo.VersionInfo.DeviceFamily == "Windows.Desktop")
            {
                //we launch the Win32 process that generates the boarding pass on the desktop
                await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync();

                //we display the export button if the app is running on the desktop, since it's the only Windows 10 platform which supports running Win32 applications
                exportButton.Visibility = Visibility.Visible;
            }

            //we register the background task that is triggered every time the time zone of the device changes
            string triggerName = "FlightTimeZoneTrigger";

            // Check if the task is already registered
            foreach (var cur in BackgroundTaskRegistration.AllTasks)
            {
                if (cur.Value.Name == triggerName)
                {
                    // The task is already registered.
                    return;
                }
            }

            BackgroundTaskBuilder builder = new BackgroundTaskBuilder();
            builder.Name = triggerName;
            builder.TaskEntryPoint = "DesktopBridge.FlightTracker.Notification.ToastTask";
            builder.SetTrigger(new SystemTrigger(SystemTriggerType.TimeZoneChange, false));
            builder.Register();
        }

        private void OnSaveFlight(object sender, RoutedEventArgs e)
        {
            //we save the data about the flight in the local storage
            ApplicationData.Current.LocalSettings.Values["Code"] = codeTextbox.Text;
            ApplicationData.Current.LocalSettings.Values["Date"] = dateTextbox.Text;
            ApplicationData.Current.LocalSettings.Values["Departure"] = departureTextbox.Text;
            ApplicationData.Current.LocalSettings.Values["Arrival"] = arrivalTextbox.Text;

            operationStatusLabel.Text = "The flight has been saved";
        }

        private async void OnExportBoardingPass(object sender, RoutedEventArgs e)
        {
            progressBar.IsActive = true;
            //we simulate that the exporting operation takes a while to be completed
            await Task.Delay(5000);

            //if the connection with the App Service has been established, we send the info about the flight to the Win32 process
            if (App.Connection != null)
            {
                ValueSet set = new ValueSet();
                set.Add("Code", codeTextbox.Text);
                set.Add("Date", dateTextbox.Text);
                set.Add("Departure", departureTextbox.Text);
                set.Add("Arrival", arrivalTextbox.Text);

                AppServiceResponse response = await App.Connection.SendMessageAsync(set);
                //if the Win32 process has received the data and it has successfully generated the boarding pass, we show a notification to the user
                if (response.Status == AppServiceResponseStatus.Success)
                {
                    string status = response.Message["Status"].ToString();
                    if (status == "Success")
                    {
                        ShowNotification();
                    }
                }
            }
            progressBar.IsActive = false;

        }

        private async void OnShowAbout(object sender, RoutedEventArgs e)
        {
            AboutPage aboutPage = new AboutPage();
            await aboutPage.ShowAsync();
        }

        private void ShowNotification()
        {
            string xml = $@"<toast>
                <visual>
                    <binding template='ToastGeneric'>
                        <text>Flight Tracker</text>
                        <text>The boarding pass for flight {codeTextbox.Text} from {departureTextbox.Text} to {arrivalTextbox.Text} has been exported on your desktop</text>
                    </binding>
                </visual>
            </toast>";

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            ToastNotification toast = new ToastNotification(doc);
            ToastNotificationManager.CreateToastNotifier().Show(toast);
        }
    }
}
