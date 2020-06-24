namespace Chip8_NET20
{
    partial class FrmStackViewer
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.chkAutoUpdate = new System.Windows.Forms.CheckBox();
            this.grpCounters = new System.Windows.Forms.GroupBox();
            this.txtSP = new System.Windows.Forms.TextBox();
            this.lblSP = new System.Windows.Forms.Label();
            this.grpStack = new System.Windows.Forms.GroupBox();
            this.lstStack = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.grpCounters.SuspendLayout();
            this.grpStack.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.grpOptions, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpCounters, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(312, 52);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.btnUpdate);
            this.grpOptions.Controls.Add(this.chkAutoUpdate);
            this.grpOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpOptions.Location = new System.Drawing.Point(3, 3);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(181, 46);
            this.grpOptions.TabIndex = 2;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(99, 15);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // chkAutoUpdate
            // 
            this.chkAutoUpdate.AutoSize = true;
            this.chkAutoUpdate.Location = new System.Drawing.Point(9, 19);
            this.chkAutoUpdate.Name = "chkAutoUpdate";
            this.chkAutoUpdate.Size = new System.Drawing.Size(84, 17);
            this.chkAutoUpdate.TabIndex = 0;
            this.chkAutoUpdate.Text = "&Auto update";
            this.chkAutoUpdate.UseVisualStyleBackColor = true;
            this.chkAutoUpdate.CheckedChanged += new System.EventHandler(this.chkAutoUpdate_CheckedChanged);
            // 
            // grpCounters
            // 
            this.grpCounters.Controls.Add(this.txtSP);
            this.grpCounters.Controls.Add(this.lblSP);
            this.grpCounters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCounters.Location = new System.Drawing.Point(190, 3);
            this.grpCounters.Name = "grpCounters";
            this.grpCounters.Size = new System.Drawing.Size(119, 46);
            this.grpCounters.TabIndex = 3;
            this.grpCounters.TabStop = false;
            this.grpCounters.Text = "Counters";
            // 
            // txtSP
            // 
            this.txtSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSP.Location = new System.Drawing.Point(33, 17);
            this.txtSP.Name = "txtSP";
            this.txtSP.ReadOnly = true;
            this.txtSP.Size = new System.Drawing.Size(77, 20);
            this.txtSP.TabIndex = 1;
            this.txtSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSP
            // 
            this.lblSP.AutoSize = true;
            this.lblSP.Location = new System.Drawing.Point(6, 20);
            this.lblSP.Name = "lblSP";
            this.lblSP.Size = new System.Drawing.Size(21, 13);
            this.lblSP.TabIndex = 0;
            this.lblSP.Text = "SP";
            // 
            // grpStack
            // 
            this.grpStack.Controls.Add(this.lstStack);
            this.grpStack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpStack.Location = new System.Drawing.Point(0, 52);
            this.grpStack.Name = "grpStack";
            this.grpStack.Size = new System.Drawing.Size(312, 164);
            this.grpStack.TabIndex = 3;
            this.grpStack.TabStop = false;
            this.grpStack.Text = "Stack";
            // 
            // lstStack
            // 
            this.lstStack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstStack.FormattingEnabled = true;
            this.lstStack.Location = new System.Drawing.Point(3, 16);
            this.lstStack.Name = "lstStack";
            this.lstStack.Size = new System.Drawing.Size(306, 134);
            this.lstStack.TabIndex = 0;
            // 
            // FrmStackViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 216);
            this.Controls.Add(this.grpStack);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(320, 240);
            this.Name = "FrmStackViewer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stack viewer";
            this.Load += new System.EventHandler(this.FrmStackViewer_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmStackViewer_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.grpCounters.ResumeLayout(false);
            this.grpCounters.PerformLayout();
            this.grpStack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox chkAutoUpdate;
        private System.Windows.Forms.GroupBox grpCounters;
        private System.Windows.Forms.TextBox txtSP;
        private System.Windows.Forms.Label lblSP;
        private System.Windows.Forms.GroupBox grpStack;
        private System.Windows.Forms.ListBox lstStack;

    }
}