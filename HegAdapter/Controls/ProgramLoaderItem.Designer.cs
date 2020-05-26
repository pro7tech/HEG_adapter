namespace BxAdapter {
    partial class ProgramLoaderItem {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemove = new System.Windows.Forms.LinkLabel();
            this.btnProgramName = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.Controls.Add(this.btnRemove, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnProgramName, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(274, 17);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = true;
            this.btnRemove.LinkColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(219, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(47, 13);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.TabStop = true;
            this.btnRemove.Text = "Remove";
            this.btnRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnRemove_LinkClicked);
            // 
            // btnProgramName
            // 
            this.btnProgramName.AutoEllipsis = true;
            this.btnProgramName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProgramName.Location = new System.Drawing.Point(3, 0);
            this.btnProgramName.Name = "btnProgramName";
            this.btnProgramName.Size = new System.Drawing.Size(210, 20);
            this.btnProgramName.TabIndex = 0;
            this.btnProgramName.TabStop = true;
            this.btnProgramName.Text = "Program Name";
            this.btnProgramName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnProgramName_LinkClicked);
            // 
            // ProgramLoaderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProgramLoaderItem";
            this.Size = new System.Drawing.Size(274, 17);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.LinkLabel btnRemove;
        private System.Windows.Forms.LinkLabel btnProgramName;
    }
}
