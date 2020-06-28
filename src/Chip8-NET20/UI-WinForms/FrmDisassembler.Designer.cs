namespace Chip8_NET20
{
    partial class FrmDisassembler
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
            this.chkAutoDisasm = new System.Windows.Forms.CheckBox();
            this.btnDisassemble = new System.Windows.Forms.Button();
            this.nudStartAddr = new UIControls.AddressNumericUpDown();
            this.lblAddr = new System.Windows.Forms.Label();
            this.txtDisasm = new System.Windows.Forms.TextBox();
            this.chkAutoSize = new System.Windows.Forms.CheckBox();
            this.nudEndAddr = new UIControls.AddressNumericUpDown();
            this.grpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndAddr)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.nudEndAddr);
            this.grpOptions.Controls.Add(this.chkAutoSize);
            this.grpOptions.Controls.Add(this.chkAutoDisasm);
            this.grpOptions.Controls.Add(this.btnDisassemble);
            this.grpOptions.Controls.Add(this.nudStartAddr);
            this.grpOptions.Controls.Add(this.lblAddr);
            this.grpOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpOptions.Location = new System.Drawing.Point(0, 0);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(312, 75);
            this.grpOptions.TabIndex = 0;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // chkAutoDisasm
            // 
            this.chkAutoDisasm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAutoDisasm.AutoSize = true;
            this.chkAutoDisasm.Location = new System.Drawing.Point(111, 50);
            this.chkAutoDisasm.Name = "chkAutoDisasm";
            this.chkAutoDisasm.Size = new System.Drawing.Size(108, 17);
            this.chkAutoDisasm.TabIndex = 2;
            this.chkAutoDisasm.Text = "&Auto disassemble";
            this.chkAutoDisasm.UseVisualStyleBackColor = true;
            this.chkAutoDisasm.CheckedChanged += new System.EventHandler(this.chkAutoDisasm_CheckedChanged);
            // 
            // btnDisassemble
            // 
            this.btnDisassemble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisassemble.Location = new System.Drawing.Point(225, 46);
            this.btnDisassemble.Name = "btnDisassemble";
            this.btnDisassemble.Size = new System.Drawing.Size(75, 23);
            this.btnDisassemble.TabIndex = 1;
            this.btnDisassemble.Text = "&Disassemble";
            this.btnDisassemble.UseVisualStyleBackColor = true;
            this.btnDisassemble.Click += new System.EventHandler(this.btnDisassemble_Click);
            // 
            // nudStartAddr
            // 
            this.nudStartAddr.Hexadecimal = true;
            this.nudStartAddr.Location = new System.Drawing.Point(97, 18);
            this.nudStartAddr.Maximum = new decimal(new int[] {
            4095,
            0,
            0,
            0});
            this.nudStartAddr.Name = "nudStartAddr";
            this.nudStartAddr.Size = new System.Drawing.Size(73, 20);
            this.nudStartAddr.TabIndex = 0;
            this.nudStartAddr.ValueChanged += new System.EventHandler(this.nudStartAddr_ValueChanged);
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.Location = new System.Drawing.Point(13, 20);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(78, 13);
            this.lblAddr.TabIndex = 0;
            this.lblAddr.Text = "Address range:";
            // 
            // txtDisasm
            // 
            this.txtDisasm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDisasm.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisasm.Location = new System.Drawing.Point(0, 75);
            this.txtDisasm.Multiline = true;
            this.txtDisasm.Name = "txtDisasm";
            this.txtDisasm.ReadOnly = true;
            this.txtDisasm.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDisasm.Size = new System.Drawing.Size(312, 141);
            this.txtDisasm.TabIndex = 2;
            this.txtDisasm.WordWrap = false;
            // 
            // chkAutoSize
            // 
            this.chkAutoSize.AutoSize = true;
            this.chkAutoSize.Location = new System.Drawing.Point(12, 50);
            this.chkAutoSize.Name = "chkAutoSize";
            this.chkAutoSize.Size = new System.Drawing.Size(69, 17);
            this.chkAutoSize.TabIndex = 3;
            this.chkAutoSize.Text = "Auto &size";
            this.chkAutoSize.UseVisualStyleBackColor = true;
            this.chkAutoSize.CheckedChanged += new System.EventHandler(this.chkAutoSize_CheckedChanged);
            // 
            // nudEndAddr
            // 
            this.nudEndAddr.Hexadecimal = true;
            this.nudEndAddr.Location = new System.Drawing.Point(176, 18);
            this.nudEndAddr.Maximum = new decimal(new int[] {
            4095,
            0,
            0,
            0});
            this.nudEndAddr.Name = "nudEndAddr";
            this.nudEndAddr.Size = new System.Drawing.Size(73, 20);
            this.nudEndAddr.TabIndex = 4;
            this.nudEndAddr.ValueChanged += new System.EventHandler(this.nudEndAddr_ValueChanged);
            // 
            // FrmDisassembler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 216);
            this.Controls.Add(this.txtDisasm);
            this.Controls.Add(this.grpOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmDisassembler";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Disassembler";
            this.Load += new System.EventHandler(this.FrmDisassembler_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDisassembler_FormClosing);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndAddr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOptions;
        private UIControls.AddressNumericUpDown nudStartAddr;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.TextBox txtDisasm;
        private System.Windows.Forms.Button btnDisassemble;
        private System.Windows.Forms.CheckBox chkAutoDisasm;
        private UIControls.AddressNumericUpDown nudEndAddr;
        private System.Windows.Forms.CheckBox chkAutoSize;
    }
}