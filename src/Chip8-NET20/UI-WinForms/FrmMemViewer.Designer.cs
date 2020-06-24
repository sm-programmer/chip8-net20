namespace Chip8_NET20
{
    partial class FrmMemViewer
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
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.chkAutoUpdate = new System.Windows.Forms.CheckBox();
            this.nudNoBytes = new System.Windows.Forms.NumericUpDown();
            this.chkManualSize = new System.Windows.Forms.CheckBox();
            this.cbMemType = new System.Windows.Forms.ComboBox();
            this.lblMemType = new System.Windows.Forms.Label();
            this.memViewer = new UIControls.MemoryViewer();
            this.grpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoBytes)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.btnUpdate);
            this.grpOptions.Controls.Add(this.chkAutoUpdate);
            this.grpOptions.Controls.Add(this.nudNoBytes);
            this.grpOptions.Controls.Add(this.chkManualSize);
            this.grpOptions.Controls.Add(this.cbMemType);
            this.grpOptions.Controls.Add(this.lblMemType);
            this.grpOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpOptions.Location = new System.Drawing.Point(0, 0);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(312, 77);
            this.grpOptions.TabIndex = 0;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(225, 44);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // chkAutoUpdate
            // 
            this.chkAutoUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAutoUpdate.AutoSize = true;
            this.chkAutoUpdate.Location = new System.Drawing.Point(135, 48);
            this.chkAutoUpdate.Name = "chkAutoUpdate";
            this.chkAutoUpdate.Size = new System.Drawing.Size(84, 17);
            this.chkAutoUpdate.TabIndex = 4;
            this.chkAutoUpdate.Text = "&Auto update";
            this.chkAutoUpdate.UseVisualStyleBackColor = true;
            this.chkAutoUpdate.CheckedChanged += new System.EventHandler(this.chkAutoUpdate_CheckedChanged);
            // 
            // nudNoBytes
            // 
            this.nudNoBytes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudNoBytes.Enabled = false;
            this.nudNoBytes.Location = new System.Drawing.Point(245, 18);
            this.nudNoBytes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNoBytes.Name = "nudNoBytes";
            this.nudNoBytes.Size = new System.Drawing.Size(55, 20);
            this.nudNoBytes.TabIndex = 3;
            this.nudNoBytes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNoBytes.ValueChanged += new System.EventHandler(this.nudNoBytes_ValueChanged);
            // 
            // chkManualSize
            // 
            this.chkManualSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkManualSize.AutoSize = true;
            this.chkManualSize.Location = new System.Drawing.Point(168, 19);
            this.chkManualSize.Name = "chkManualSize";
            this.chkManualSize.Size = new System.Drawing.Size(71, 17);
            this.chkManualSize.TabIndex = 2;
            this.chkManualSize.Text = "No. &bytes";
            this.chkManualSize.UseVisualStyleBackColor = true;
            this.chkManualSize.CheckedChanged += new System.EventHandler(this.cbManualSize_CheckedChanged);
            // 
            // cbMemType
            // 
            this.cbMemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMemType.FormattingEnabled = true;
            this.cbMemType.Items.AddRange(new object[] {
            "Main memory",
            "Video memory"});
            this.cbMemType.Location = new System.Drawing.Point(58, 17);
            this.cbMemType.Name = "cbMemType";
            this.cbMemType.Size = new System.Drawing.Size(104, 21);
            this.cbMemType.TabIndex = 1;
            this.cbMemType.SelectedIndexChanged += new System.EventHandler(this.cbMemType_SelectedIndexChanged);
            // 
            // lblMemType
            // 
            this.lblMemType.AutoSize = true;
            this.lblMemType.Location = new System.Drawing.Point(7, 20);
            this.lblMemType.Name = "lblMemType";
            this.lblMemType.Size = new System.Drawing.Size(45, 13);
            this.lblMemType.TabIndex = 0;
            this.lblMemType.Text = "Inspect:";
            // 
            // memViewer
            // 
            this.memViewer.AutoAdjustWidth = true;
            this.memViewer.BytesPerLine = 8;
            this.memViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memViewer.FirstLine = 0;
            this.memViewer.Location = new System.Drawing.Point(0, 77);
            this.memViewer.Name = "memViewer";
            this.memViewer.Size = new System.Drawing.Size(312, 139);
            this.memViewer.Source = null;
            this.memViewer.TabIndex = 2;
            this.memViewer.VisibleLineCount = 7;
            this.memViewer.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(this.memViewer_PropertyChanged);
            // 
            // FrmMemViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 216);
            this.Controls.Add(this.memViewer);
            this.Controls.Add(this.grpOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(320, 240);
            this.Name = "FrmMemViewer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Memory viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMemViewer_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMemViewer_KeyDown);
            this.Load += new System.EventHandler(this.FrmMemViewer_Load);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoBytes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.ComboBox cbMemType;
        private System.Windows.Forms.Label lblMemType;
        private UIControls.MemoryViewer memViewer;
        private System.Windows.Forms.CheckBox chkManualSize;
        private System.Windows.Forms.NumericUpDown nudNoBytes;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox chkAutoUpdate;
    }
}