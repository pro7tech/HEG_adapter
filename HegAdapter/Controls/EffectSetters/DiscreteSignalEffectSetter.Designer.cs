namespace BxAdapter
{
    partial class DiscreteSignalEffectSetter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPass = new System.Windows.Forms.Label();
            this.updnFail = new System.Windows.Forms.NumericUpDown();
            this.lblFail = new System.Windows.Forms.Label();
            this.updnPass = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.updnFail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnPass)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(6, 29);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(29, 13);
            this.lblPass.TabIndex = 39;
            this.lblPass.Text = "Pass";
            // 
            // updnFail
            // 
            this.updnFail.Location = new System.Drawing.Point(42, 50);
            this.updnFail.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.updnFail.Name = "updnFail";
            this.updnFail.Size = new System.Drawing.Size(41, 20);
            this.updnFail.TabIndex = 38;
            this.updnFail.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblFail
            // 
            this.lblFail.AutoSize = true;
            this.lblFail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFail.Location = new System.Drawing.Point(12, 52);
            this.lblFail.Name = "lblFail";
            this.lblFail.Size = new System.Drawing.Size(23, 13);
            this.lblFail.TabIndex = 36;
            this.lblFail.Text = "Fail";
            // 
            // updnPass
            // 
            this.updnPass.Location = new System.Drawing.Point(42, 24);
            this.updnPass.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.updnPass.Name = "updnPass";
            this.updnPass.Size = new System.Drawing.Size(41, 20);
            this.updnPass.TabIndex = 37;
            this.updnPass.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // DiscreteSignalEffectSetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.updnFail);
            this.Controls.Add(this.lblFail);
            this.Controls.Add(this.updnPass);
            this.Name = "DiscreteSignalEffectSetter";
            this.Size = new System.Drawing.Size(99, 101);
            ((System.ComponentModel.ISupportInitialize)(this.updnFail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.NumericUpDown updnFail;
        private System.Windows.Forms.Label lblFail;
        private System.Windows.Forms.NumericUpDown updnPass;
    }
}
