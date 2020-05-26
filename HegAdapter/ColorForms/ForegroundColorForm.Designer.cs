namespace BxAdapter
{
    partial class ForegroundColorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tmrTopMost = new System.Windows.Forms.Timer();
            this.SuspendLayout();
            // 
            // tmrTopMost
            // 
            this.tmrTopMost.Enabled = true;
            this.tmrTopMost.Interval = 200;
            this.tmrTopMost.Tick += new System.EventHandler(this.tmrTopMost_Tick);
            // 
            // ForegroundColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(90, 26);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForegroundColorForm";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ForegroundColorForm";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrTopMost;
    }
}