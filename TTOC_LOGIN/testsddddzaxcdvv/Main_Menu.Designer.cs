namespace testsddddzaxcdvv
{
    partial class Main_Menu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LogEvent = new System.Windows.Forms.Button();
            this.RecentEntries = new System.Windows.Forms.Button();
            this.SearchEvent = new System.Windows.Forms.Button();
            this.BuildReport = new System.Windows.Forms.Button();
            this.LogOff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(74, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 276);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tauranga Transport Operations Centre";
            // 
            // LogEvent
            // 
            this.LogEvent.Location = new System.Drawing.Point(628, 12);
            this.LogEvent.Name = "LogEvent";
            this.LogEvent.Size = new System.Drawing.Size(259, 66);
            this.LogEvent.TabIndex = 2;
            this.LogEvent.Text = "Log Event";
            this.LogEvent.UseVisualStyleBackColor = true;
            this.LogEvent.Click += new System.EventHandler(this.LogEvent_Click);
            // 
            // RecentEntries
            // 
            this.RecentEntries.Location = new System.Drawing.Point(628, 84);
            this.RecentEntries.Name = "RecentEntries";
            this.RecentEntries.Size = new System.Drawing.Size(259, 66);
            this.RecentEntries.TabIndex = 3;
            this.RecentEntries.Text = "Recent Entries";
            this.RecentEntries.UseVisualStyleBackColor = true;
            // 
            // SearchEvent
            // 
            this.SearchEvent.Location = new System.Drawing.Point(628, 156);
            this.SearchEvent.Name = "SearchEvent";
            this.SearchEvent.Size = new System.Drawing.Size(259, 66);
            this.SearchEvent.TabIndex = 4;
            this.SearchEvent.Text = "Search Event";
            this.SearchEvent.UseVisualStyleBackColor = true;
            // 
            // BuildReport
            // 
            this.BuildReport.Location = new System.Drawing.Point(628, 228);
            this.BuildReport.Name = "BuildReport";
            this.BuildReport.Size = new System.Drawing.Size(259, 66);
            this.BuildReport.TabIndex = 5;
            this.BuildReport.Text = "Build Report";
            this.BuildReport.UseVisualStyleBackColor = true;
            // 
            // LogOff
            // 
            this.LogOff.Location = new System.Drawing.Point(628, 300);
            this.LogOff.Name = "LogOff";
            this.LogOff.Size = new System.Drawing.Size(259, 66);
            this.LogOff.TabIndex = 6;
            this.LogOff.Text = "Log Off";
            this.LogOff.UseVisualStyleBackColor = true;
            this.LogOff.Click += new System.EventHandler(this.LogOff_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 380);
            this.Controls.Add(this.LogOff);
            this.Controls.Add(this.BuildReport);
            this.Controls.Add(this.SearchEvent);
            this.Controls.Add(this.RecentEntries);
            this.Controls.Add(this.LogEvent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Main_Menu";
            this.Text = "Mian_Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogEvent;
        private System.Windows.Forms.Button RecentEntries;
        private System.Windows.Forms.Button SearchEvent;
        private System.Windows.Forms.Button BuildReport;
        private System.Windows.Forms.Button LogOff;
    }
}