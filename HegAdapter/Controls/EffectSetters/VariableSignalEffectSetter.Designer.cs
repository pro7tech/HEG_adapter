namespace BxAdapter
{
    partial class VariableSignalEffectSetter
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
            this.chkReverse = new System.Windows.Forms.CheckBox();
            this.updnMaximumThresholdPercent = new System.Windows.Forms.NumericUpDown();
            this.updnMinimumThresholdPercent = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.updnMaximumThresholdPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnMinimumThresholdPercent)).BeginInit();
            this.SuspendLayout();
            // 
            // chkReverse
            // 
            this.chkReverse.AutoSize = true;
            this.chkReverse.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReverse.Location = new System.Drawing.Point(7, 67);
            this.chkReverse.Name = "chkReverse";
            this.chkReverse.Size = new System.Drawing.Size(79, 17);
            this.chkReverse.TabIndex = 11;
            this.chkReverse.Text = "Train down";
            this.chkReverse.UseVisualStyleBackColor = true;
            // 
            // updnMaximumThresholdPercent
            // 
            this.updnMaximumThresholdPercent.Location = new System.Drawing.Point(40, 16);
            this.updnMaximumThresholdPercent.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.updnMaximumThresholdPercent.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.updnMaximumThresholdPercent.Name = "updnMaximumThresholdPercent";
            this.updnMaximumThresholdPercent.Size = new System.Drawing.Size(45, 20);
            this.updnMaximumThresholdPercent.TabIndex = 11;
            this.updnMaximumThresholdPercent.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // updnMinimumThresholdPercent
            // 
            this.updnMinimumThresholdPercent.Location = new System.Drawing.Point(40, 42);
            this.updnMinimumThresholdPercent.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.updnMinimumThresholdPercent.Name = "updnMinimumThresholdPercent";
            this.updnMinimumThresholdPercent.Size = new System.Drawing.Size(45, 20);
            this.updnMinimumThresholdPercent.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Min:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Max:";
            // 
            // VariableSignalEffectSetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.updnMaximumThresholdPercent);
            this.Controls.Add(this.chkReverse);
            this.Controls.Add(this.updnMinimumThresholdPercent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "VariableSignalEffectSetter";
            this.Size = new System.Drawing.Size(99, 101);
            ((System.ComponentModel.ISupportInitialize)(this.updnMaximumThresholdPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnMinimumThresholdPercent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkReverse;
        private System.Windows.Forms.NumericUpDown updnMaximumThresholdPercent;
        private System.Windows.Forms.NumericUpDown updnMinimumThresholdPercent;
    }
}
