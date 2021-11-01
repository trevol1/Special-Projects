namespace DigitalClock
{
    partial class DigitalClock
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
            this.components = new System.ComponentModel.Container();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.SecondsLbl = new System.Windows.Forms.Label();
            this.DayLbl = new System.Windows.Forms.Label();
            this.DateLbl = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TimeLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TimeLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TimeLbl.Location = new System.Drawing.Point(267, 57);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(204, 85);
            this.TimeLbl.TabIndex = 0;
            this.TimeLbl.Text = "23:23";
            this.TimeLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SecondsLbl
            // 
            this.SecondsLbl.AutoSize = true;
            this.SecondsLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SecondsLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SecondsLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondsLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SecondsLbl.Location = new System.Drawing.Point(475, 94);
            this.SecondsLbl.Name = "SecondsLbl";
            this.SecondsLbl.Size = new System.Drawing.Size(64, 48);
            this.SecondsLbl.TabIndex = 1;
            this.SecondsLbl.Text = "22";
            this.SecondsLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DayLbl
            // 
            this.DayLbl.AutoSize = true;
            this.DayLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DayLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DayLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DayLbl.Location = new System.Drawing.Point(504, 228);
            this.DayLbl.Name = "DayLbl";
            this.DayLbl.Size = new System.Drawing.Size(220, 64);
            this.DayLbl.TabIndex = 2;
            this.DayLbl.Text = "Monday";
            this.DayLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DateLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DateLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DateLbl.Location = new System.Drawing.Point(33, 228);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(345, 64);
            this.DateLbl.TabIndex = 3;
            this.DateLbl.Text = "JUNE 20 2021";
            this.DateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // DigitalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DateLbl);
            this.Controls.Add(this.DayLbl);
            this.Controls.Add(this.SecondsLbl);
            this.Controls.Add(this.TimeLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DigitalClock";
            this.Text = "DigitalClock";
            this.Load += new System.EventHandler(this.DigitalClock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.Label SecondsLbl;
        private System.Windows.Forms.Label DayLbl;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Timer timer;
    }
}

