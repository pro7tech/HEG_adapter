namespace BxAdapter {
    partial class ProgramSelector {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.listWindows = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefreshList = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.listRecentPrograms = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.flowAllPrograms = new System.Windows.Forms.FlowLayoutPanel();
            this.listFrequentPrograms = new System.Windows.Forms.ListBox();
            this.btnLoaderHelp = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // listWindows
            // 
            this.listWindows.FormattingEnabled = true;
            this.listWindows.Location = new System.Drawing.Point(13, 64);
            this.listWindows.Name = "listWindows";
            this.listWindows.Size = new System.Drawing.Size(248, 95);
            this.listWindows.TabIndex = 0;
            this.listWindows.SelectedIndexChanged += new System.EventHandler(this.listWindows_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Recent Programs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "All Programs Linked in Past";
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.AutoSize = true;
            this.btnRefreshList.LinkColor = System.Drawing.Color.Black;
            this.btnRefreshList.Location = new System.Drawing.Point(98, 48);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(44, 13);
            this.btnRefreshList.TabIndex = 9;
            this.btnRefreshList.TabStop = true;
            this.btnRefreshList.Text = "Refresh";
            this.btnRefreshList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnRefreshList_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Open Programs";
            // 
            // listRecentPrograms
            // 
            this.listRecentPrograms.FormattingEnabled = true;
            this.listRecentPrograms.Location = new System.Drawing.Point(13, 181);
            this.listRecentPrograms.Name = "listRecentPrograms";
            this.listRecentPrograms.Size = new System.Drawing.Size(119, 108);
            this.listRecentPrograms.TabIndex = 14;
            this.listRecentPrograms.SelectedIndexChanged += new System.EventHandler(this.listRecentPrograms_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Frequent Programs";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(15, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(455, 24);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Click Button to Close  this screen (Or use Alt-F2 to toggle it)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // flowAllPrograms
            // 
            this.flowAllPrograms.AutoScroll = true;
            this.flowAllPrograms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowAllPrograms.Location = new System.Drawing.Point(289, 64);
            this.flowAllPrograms.Name = "flowAllPrograms";
            this.flowAllPrograms.Size = new System.Drawing.Size(237, 225);
            this.flowAllPrograms.TabIndex = 17;
            // 
            // listFrequentPrograms
            // 
            this.listFrequentPrograms.FormattingEnabled = true;
            this.listFrequentPrograms.Location = new System.Drawing.Point(141, 181);
            this.listFrequentPrograms.Name = "listFrequentPrograms";
            this.listFrequentPrograms.Size = new System.Drawing.Size(120, 108);
            this.listFrequentPrograms.TabIndex = 19;
            this.listFrequentPrograms.SelectedIndexChanged += new System.EventHandler(this.listFrequentPrograms_SelectedIndexChanged);
            // 
            // btnLoaderHelp
            // 
            this.btnLoaderHelp.AutoSize = true;
            this.btnLoaderHelp.LinkColor = System.Drawing.Color.Blue;
            this.btnLoaderHelp.Location = new System.Drawing.Point(488, 13);
            this.btnLoaderHelp.Name = "btnLoaderHelp";
            this.btnLoaderHelp.Size = new System.Drawing.Size(29, 13);
            this.btnLoaderHelp.TabIndex = 23;
            this.btnLoaderHelp.TabStop = true;
            this.btnLoaderHelp.Text = "Help";
            this.btnLoaderHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnloaderHelp_LinkClicked);
            // 
            // ProgramSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 299);
            this.Controls.Add(this.btnLoaderHelp);
            this.Controls.Add(this.listFrequentPrograms);
            this.Controls.Add(this.flowAllPrograms);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.listRecentPrograms);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRefreshList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listWindows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgramSelector";
            this.ShowInTaskbar = false;
            this.Text = "Link a Program to BioExplorer";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.ProgramSelector_Activated);
            this.VisibleChanged += new System.EventHandler(this.ProgramSelector_VisibleChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProgramSelector_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listWindows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel btnRefreshList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listRecentPrograms;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FlowLayoutPanel flowAllPrograms;
        private System.Windows.Forms.ListBox listFrequentPrograms;
        private System.Windows.Forms.LinkLabel btnLoaderHelp;
    }
}