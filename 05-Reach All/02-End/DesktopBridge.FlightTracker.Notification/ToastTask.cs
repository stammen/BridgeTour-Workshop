using Windows.ApplicationModel.Background;
using Windows.Data.Xml.Dom;
using Windows.Storage;
using Windows.UI.Notifications;

namespace DesktopBridge.FlightTracker.Notification
{
    public sealed class ToastTask : IBackgroundTask
    {
        public void Run(IBackgroundTaskInstance taskInstance)
        {
            string flightInfo = GenerateFlightInfo();

            string xml = $@"<toast>
                                <visual>
                                    <binding template='ToastGeneric'>
                                        <text>Flight Tracker</text>
                                        <text>Pay attention, your time zone has changed! Make sure your flight is still in time!</text>
                                        <text>{flightInfo}</text>
                                    </binding>
                                </visual>
                            </toast>";

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            ToastNotification toast = new ToastNotification(doc);
            ToastNotificationManager.CreateToastNotifier().Show(toast);
        }


        private string GenerateFlightInfo()
        {
            string code = string.Empty;
            string date = string.Empty;
            string departure = string.Empty;
            string arrival = string.Empty;

            if (ApplicationData.Current.LocalSettings.Values.ContainsKey("Code"))
            {
                code = ApplicationData.Current.LocalSettings.Values["Code"].ToString();
            }

            if (ApplicationData.Current.LocalSettings.Values.ContainsKey("Date"))
            {
                date = ApplicationData.Current.LocalSettings.Values["Date"].ToString();
            }

            if (ApplicationData.Current.LocalSettings.Values.ContainsKey("Departure"))
            {
                departure = ApplicationData.Current.LocalSettings.Values["Departure"].ToString();
            }

            if (ApplicationData.Current.LocalSettings.Values.ContainsKey("Arrival"))
            {
                arrival = ApplicationData.Current.LocalSettings.Values["Arrival"].ToString();
            }

            string message = $"Flight code: {code} - Date: {date} - From: {departure} - To: {arrival}";
            return message;
        }
    }
}
