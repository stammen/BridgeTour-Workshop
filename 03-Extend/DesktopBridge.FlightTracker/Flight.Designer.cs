namespace DesktopBridge.FlightTracker
{
    partial class Flight
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flight));
            this.label1 = new System.Windows.Forms.Label();
            this.codeTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.departureTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.arrivalTextbox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutFlightTrackerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationStatusLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "FlightTracker";
            // 
            // codeTextbox
            // 
            this.codeTextbox.Location = new System.Drawing.Point(59, 107);
            this.codeTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.codeTextbox.Name = "codeTextbox";
            this.codeTextbox.Size = new System.Drawing.Size(197, 20);
            this.codeTextbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Flight code:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(100, 272);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(50, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(174, 272);
            this.exportButton.Margin = new System.Windows.Forms.Padding(2);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(50, 23);
            this.exportButton.TabIndex = 6;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Flight date:";
            // 
            // dateTextbox
            // 
            this.dateTextbox.Location = new System.Drawing.Point(59, 148);
            this.dateTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.dateTextbox.Name = "dateTextbox";
            this.dateTextbox.Size = new System.Drawing.Size(197, 20);
            this.dateTextbox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Flight depature city:";
            // 
            // departureTextbox
            // 
            this.departureTextbox.Location = new System.Drawing.Point(59, 189);
            this.departureTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.departureTextbox.Name = "departureTextbox";
            this.departureTextbox.Size = new System.Drawing.Size(197, 20);
            this.departureTextbox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Flight arrival city:";
            // 
            // arrivalTextbox
            // 
            this.arrivalTextbox.Location = new System.Drawing.Point(59, 226);
            this.arrivalTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.arrivalTextbox.Name = "arrivalTextbox";
            this.arrivalTextbox.Size = new System.Drawing.Size(197, 20);
            this.arrivalTextbox.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(315, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateStripMenuItem,
            this.aboutFlightTrackerToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // updateStripMenuItem
            // 
            this.updateStripMenuItem.Name = "updateStripMenuItem";
            this.updateStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.updateStripMenuItem.Text = "Check for updates";
            this.updateStripMenuItem.Click += new System.EventHandler(this.updateStripMenuItem_Click);
            // 
            // aboutFlightTrackerToolStripMenuItem
            // 
            this.aboutFlightTrackerToolStripMenuItem.Name = "aboutFlightTrackerToolStripMenuItem";
            this.aboutFlightTrackerToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.aboutFlightTrackerToolStripMenuItem.Text = "About FlightTracker";
            this.aboutFlightTrackerToolStripMenuItem.Click += new System.EventHandler(this.aboutFlightTrackerToolStripMenuItem_Click);
            // 
            // operationStatusLabel
            // 
            this.operationStatusLabel.AutoSize = true;
            this.operationStatusLabel.Location = new System.Drawing.Point(3, 336);
            this.operationStatusLabel.Name = "operationStatusLabel";
            this.operationStatusLabel.Size = new System.Drawing.Size(0, 13);
            this.operationStatusLabel.TabIndex = 12;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(0, 352);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(315, 11);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 13;
            this.progressBar.Visible = false;
            // 
            // Flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 362);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.operationStatusLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.arrivalTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.departureTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTextbox);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codeTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Flight";
            this.Text = "FlightTracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codeTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dateTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox departureTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox arrivalTextbox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutFlightTrackerToolStripMenuItem;
        private System.Windows.Forms.Label operationStatusLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ToolStripMenuItem updateStripMenuItem;
    }
}

