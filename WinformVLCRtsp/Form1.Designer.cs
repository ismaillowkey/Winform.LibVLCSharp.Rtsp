namespace WinformVLCRtsp
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
            this.TxtURLrtsp = new System.Windows.Forms.TextBox();
            this.BtnStream = new System.Windows.Forms.Button();
            this.videoView1 = new LibVLCSharp.WinForms.VideoView();
            ((System.ComponentModel.ISupportInitialize)(this.videoView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtURLrtsp
            // 
            this.TxtURLrtsp.Location = new System.Drawing.Point(88, 23);
            this.TxtURLrtsp.Name = "TxtURLrtsp";
            this.TxtURLrtsp.Size = new System.Drawing.Size(538, 20);
            this.TxtURLrtsp.TabIndex = 1;
            this.TxtURLrtsp.Text = "rtsp://192.168.2.107/live/ch00_1";
            // 
            // BtnStream
            // 
            this.BtnStream.Location = new System.Drawing.Point(644, 21);
            this.BtnStream.Name = "BtnStream";
            this.BtnStream.Size = new System.Drawing.Size(75, 23);
            this.BtnStream.TabIndex = 2;
            this.BtnStream.Text = "stream";
            this.BtnStream.UseVisualStyleBackColor = true;
            this.BtnStream.Click += new System.EventHandler(this.BtnStream_Click);
            // 
            // videoView1
            // 
            this.videoView1.BackColor = System.Drawing.Color.Black;
            this.videoView1.Location = new System.Drawing.Point(88, 62);
            this.videoView1.MediaPlayer = null;
            this.videoView1.Name = "videoView1";
            this.videoView1.Size = new System.Drawing.Size(538, 364);
            this.videoView1.TabIndex = 3;
            this.videoView1.Text = "videoView1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.videoView1);
            this.Controls.Add(this.BtnStream);
            this.Controls.Add(this.TxtURLrtsp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtURLrtsp;
        private System.Windows.Forms.Button BtnStream;
        private LibVLCSharp.WinForms.VideoView videoView1;
    }
}

