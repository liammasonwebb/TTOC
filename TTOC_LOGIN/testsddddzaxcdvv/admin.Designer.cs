namespace testsddddzaxcdvv
{
    partial class admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogOff = new System.Windows.Forms.Button();
            this.BuildReport = new System.Windows.Forms.Button();
            this.SearchEvent = new System.Windows.Forms.Button();
            this.addlocation = new System.Windows.Forms.Button();
            this.ViewDashboard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN PANEL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(33, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 269);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LogOff
            // 
            this.LogOff.Location = new System.Drawing.Point(623, 294);
            this.LogOff.Name = "LogOff";
            this.LogOff.Size = new System.Drawing.Size(259, 66);
            this.LogOff.TabIndex = 11;
            this.LogOff.Text = "Log Off";
            this.LogOff.UseVisualStyleBackColor = true;
            this.LogOff.Click += new System.EventHandler(this.LogOff_Click);
            // 
            // BuildReport
            // 
            this.BuildReport.Location = new System.Drawing.Point(623, 222);
            this.BuildReport.Name = "BuildReport";
            this.BuildReport.Size = new System.Drawing.Size(259, 66);
            this.BuildReport.TabIndex = 10;
            this.BuildReport.Text = "View Report";
            this.BuildReport.UseVisualStyleBackColor = true;
            // 
            // SearchEvent
            // 
            this.SearchEvent.Location = new System.Drawing.Point(623, 150);
            this.SearchEvent.Name = "SearchEvent";
            this.SearchEvent.Size = new System.Drawing.Size(259, 66);
            this.SearchEvent.TabIndex = 9;
            this.SearchEvent.Text = "Edit Event Types";
            this.SearchEvent.UseVisualStyleBackColor = true;
            this.SearchEvent.Click += new System.EventHandler(this.SearchEvent_Click);
            // 
            // addlocation
            // 
            this.addlocation.Location = new System.Drawing.Point(623, 78);
            this.addlocation.Name = "addlocation";
            this.addlocation.Size = new System.Drawing.Size(259, 66);
            this.addlocation.TabIndex = 8;
            this.addlocation.Text = "Edit Locations";
            this.addlocation.UseVisualStyleBackColor = true;
            this.addlocation.Click += new System.EventHandler(this.addlocation_Click);
            // 
            // ViewDashboard
            // 
            this.ViewDashboard.Location = new System.Drawing.Point(623, 6);
            this.ViewDashboard.Name = "ViewDashboard";
            this.ViewDashboard.Size = new System.Drawing.Size(259, 66);
            this.ViewDashboard.TabIndex = 7;
            this.ViewDashboard.Text = "View Dashboard";
            this.ViewDashboard.UseVisualStyleBackColor = true;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 368);
            this.Controls.Add(this.LogOff);
            this.Controls.Add(this.BuildReport);
            this.Controls.Add(this.SearchEvent);
            this.Controls.Add(this.addlocation);
            this.Controls.Add(this.ViewDashboard);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "admin";
            this.Text = "admin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LogOff;
        private System.Windows.Forms.Button BuildReport;
        private System.Windows.Forms.Button SearchEvent;
        private System.Windows.Forms.Button addlocation;
        private System.Windows.Forms.Button ViewDashboard;
    }
}