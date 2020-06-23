namespace Chip8_NET20
{
    partial class FrmRegInspect
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
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.tlpGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.lblPC = new System.Windows.Forms.Label();
            this.txtI = new System.Windows.Forms.TextBox();
            this.lblSP = new System.Windows.Forms.Label();
            this.txtSP = new System.Windows.Forms.TextBox();
            this.lblI = new System.Windows.Forms.Label();
            this.txtPC = new System.Windows.Forms.TextBox();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.grpTimers = new System.Windows.Forms.GroupBox();
            this.tlpTimers = new System.Windows.Forms.TableLayoutPanel();
            this.lblDelay = new System.Windows.Forms.Label();
            this.txtSound = new System.Windows.Forms.TextBox();
            this.lblSound = new System.Windows.Forms.Label();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.grpRegs = new System.Windows.Forms.GroupBox();
            this.tlpRegs = new System.Windows.Forms.TableLayoutPanel();
            this.txtVF = new System.Windows.Forms.TextBox();
            this.txtVE = new System.Windows.Forms.TextBox();
            this.txtVD = new System.Windows.Forms.TextBox();
            this.txtVC = new System.Windows.Forms.TextBox();
            this.txtVB = new System.Windows.Forms.TextBox();
            this.txtVA = new System.Windows.Forms.TextBox();
            this.txtV9 = new System.Windows.Forms.TextBox();
            this.txtV8 = new System.Windows.Forms.TextBox();
            this.lblVF = new System.Windows.Forms.Label();
            this.lblVE = new System.Windows.Forms.Label();
            this.lblVD = new System.Windows.Forms.Label();
            this.lblVC = new System.Windows.Forms.Label();
            this.lblVB = new System.Windows.Forms.Label();
            this.lblVA = new System.Windows.Forms.Label();
            this.lblV9 = new System.Windows.Forms.Label();
            this.lblV8 = new System.Windows.Forms.Label();
            this.txtV7 = new System.Windows.Forms.TextBox();
            this.txtV6 = new System.Windows.Forms.TextBox();
            this.txtV5 = new System.Windows.Forms.TextBox();
            this.txtV4 = new System.Windows.Forms.TextBox();
            this.txtV3 = new System.Windows.Forms.TextBox();
            this.txtV2 = new System.Windows.Forms.TextBox();
            this.txtV1 = new System.Windows.Forms.TextBox();
            this.lblV7 = new System.Windows.Forms.Label();
            this.lblV6 = new System.Windows.Forms.Label();
            this.lblV5 = new System.Windows.Forms.Label();
            this.lblV4 = new System.Windows.Forms.Label();
            this.lblV3 = new System.Windows.Forms.Label();
            this.lblV2 = new System.Windows.Forms.Label();
            this.lblV1 = new System.Windows.Forms.Label();
            this.lblV0 = new System.Windows.Forms.Label();
            this.txtV0 = new System.Windows.Forms.TextBox();
            this.grpGeneral.SuspendLayout();
            this.tlpGeneral.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.grpTimers.SuspendLayout();
            this.tlpTimers.SuspendLayout();
            this.grpRegs.SuspendLayout();
            this.tlpRegs.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.tlpGeneral);
            this.grpGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGeneral.Location = new System.Drawing.Point(3, 3);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(230, 81);
            this.grpGeneral.TabIndex = 0;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General";
            // 
            // tlpGeneral
            // 
            this.tlpGeneral.ColumnCount = 3;
            this.tlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpGeneral.Controls.Add(this.lblPC, 0, 0);
            this.tlpGeneral.Controls.Add(this.txtI, 2, 1);
            this.tlpGeneral.Controls.Add(this.lblSP, 1, 0);
            this.tlpGeneral.Controls.Add(this.txtSP, 1, 1);
            this.tlpGeneral.Controls.Add(this.lblI, 2, 0);
            this.tlpGeneral.Controls.Add(this.txtPC, 0, 1);
            this.tlpGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGeneral.Location = new System.Drawing.Point(3, 16);
            this.tlpGeneral.Name = "tlpGeneral";
            this.tlpGeneral.RowCount = 2;
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGeneral.Size = new System.Drawing.Size(224, 62);
            this.tlpGeneral.TabIndex = 6;
            // 
            // lblPC
            // 
            this.lblPC.AutoSize = true;
            this.lblPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPC.Location = new System.Drawing.Point(3, 0);
            this.lblPC.Name = "lblPC";
            this.lblPC.Size = new System.Drawing.Size(68, 31);
            this.lblPC.TabIndex = 0;
            this.lblPC.Text = "PC";
            this.lblPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtI
            // 
            this.txtI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtI.Location = new System.Drawing.Point(151, 34);
            this.txtI.MaxLength = 6;
            this.txtI.Name = "txtI";
            this.txtI.ReadOnly = true;
            this.txtI.Size = new System.Drawing.Size(70, 20);
            this.txtI.TabIndex = 5;
            this.txtI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSP
            // 
            this.lblSP.AutoSize = true;
            this.lblSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSP.Location = new System.Drawing.Point(77, 0);
            this.lblSP.Name = "lblSP";
            this.lblSP.Size = new System.Drawing.Size(68, 31);
            this.lblSP.TabIndex = 1;
            this.lblSP.Text = "SP";
            this.lblSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSP
            // 
            this.txtSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSP.Location = new System.Drawing.Point(77, 34);
            this.txtSP.MaxLength = 6;
            this.txtSP.Name = "txtSP";
            this.txtSP.ReadOnly = true;
            this.txtSP.Size = new System.Drawing.Size(68, 20);
            this.txtSP.TabIndex = 4;
            this.txtSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblI
            // 
            this.lblI.AutoSize = true;
            this.lblI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblI.Location = new System.Drawing.Point(151, 0);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(70, 31);
            this.lblI.TabIndex = 2;
            this.lblI.Text = "I";
            this.lblI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPC
            // 
            this.txtPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPC.Location = new System.Drawing.Point(3, 34);
            this.txtPC.MaxLength = 6;
            this.txtPC.Name = "txtPC";
            this.txtPC.ReadOnly = true;
            this.txtPC.Size = new System.Drawing.Size(68, 20);
            this.txtPC.TabIndex = 3;
            this.txtPC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpMain.Controls.Add(this.grpGeneral, 0, 0);
            this.tlpMain.Controls.Add(this.grpTimers, 1, 0);
            this.tlpMain.Controls.Add(this.grpRegs, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpMain.Size = new System.Drawing.Size(394, 218);
            this.tlpMain.TabIndex = 1;
            // 
            // grpTimers
            // 
            this.grpTimers.Controls.Add(this.tlpTimers);
            this.grpTimers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTimers.Location = new System.Drawing.Point(239, 3);
            this.grpTimers.Name = "grpTimers";
            this.grpTimers.Size = new System.Drawing.Size(152, 81);
            this.grpTimers.TabIndex = 1;
            this.grpTimers.TabStop = false;
            this.grpTimers.Text = "Timers";
            // 
            // tlpTimers
            // 
            this.tlpTimers.ColumnCount = 2;
            this.tlpTimers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTimers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTimers.Controls.Add(this.lblDelay, 0, 0);
            this.tlpTimers.Controls.Add(this.txtSound, 1, 1);
            this.tlpTimers.Controls.Add(this.lblSound, 1, 0);
            this.tlpTimers.Controls.Add(this.txtDelay, 0, 1);
            this.tlpTimers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTimers.Location = new System.Drawing.Point(3, 16);
            this.tlpTimers.Name = "tlpTimers";
            this.tlpTimers.RowCount = 2;
            this.tlpTimers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTimers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTimers.Size = new System.Drawing.Size(146, 62);
            this.tlpTimers.TabIndex = 4;
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDelay.Location = new System.Drawing.Point(3, 0);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(67, 31);
            this.lblDelay.TabIndex = 2;
            this.lblDelay.Text = "Delay";
            this.lblDelay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSound
            // 
            this.txtSound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSound.Location = new System.Drawing.Point(76, 34);
            this.txtSound.MaxLength = 6;
            this.txtSound.Name = "txtSound";
            this.txtSound.ReadOnly = true;
            this.txtSound.Size = new System.Drawing.Size(67, 20);
            this.txtSound.TabIndex = 1;
            this.txtSound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSound
            // 
            this.lblSound.AutoSize = true;
            this.lblSound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSound.Location = new System.Drawing.Point(76, 0);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(67, 31);
            this.lblSound.TabIndex = 3;
            this.lblSound.Text = "Sound";
            this.lblSound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDelay
            // 
            this.txtDelay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDelay.Location = new System.Drawing.Point(3, 34);
            this.txtDelay.MaxLength = 6;
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.ReadOnly = true;
            this.txtDelay.Size = new System.Drawing.Size(67, 20);
            this.txtDelay.TabIndex = 0;
            this.txtDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpRegs
            // 
            this.tlpMain.SetColumnSpan(this.grpRegs, 2);
            this.grpRegs.Controls.Add(this.tlpRegs);
            this.grpRegs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRegs.Location = new System.Drawing.Point(3, 90);
            this.grpRegs.Name = "grpRegs";
            this.grpRegs.Size = new System.Drawing.Size(388, 125);
            this.grpRegs.TabIndex = 2;
            this.grpRegs.TabStop = false;
            this.grpRegs.Text = "Registers";
            // 
            // tlpRegs
            // 
            this.tlpRegs.ColumnCount = 8;
            this.tlpRegs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpRegs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpRegs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpRegs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpRegs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpRegs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpRegs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpRegs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpRegs.Controls.Add(this.txtVF, 7, 3);
            this.tlpRegs.Controls.Add(this.txtVE, 6, 3);
            this.tlpRegs.Controls.Add(this.txtVD, 5, 3);
            this.tlpRegs.Controls.Add(this.txtVC, 4, 3);
            this.tlpRegs.Controls.Add(this.txtVB, 3, 3);
            this.tlpRegs.Controls.Add(this.txtVA, 2, 3);
            this.tlpRegs.Controls.Add(this.txtV9, 1, 3);
            this.tlpRegs.Controls.Add(this.txtV8, 0, 3);
            this.tlpRegs.Controls.Add(this.lblVF, 7, 2);
            this.tlpRegs.Controls.Add(this.lblVE, 6, 2);
            this.tlpRegs.Controls.Add(this.lblVD, 5, 2);
            this.tlpRegs.Controls.Add(this.lblVC, 4, 2);
            this.tlpRegs.Controls.Add(this.lblVB, 3, 2);
            this.tlpRegs.Controls.Add(this.lblVA, 2, 2);
            this.tlpRegs.Controls.Add(this.lblV9, 1, 2);
            this.tlpRegs.Controls.Add(this.lblV8, 0, 2);
            this.tlpRegs.Controls.Add(this.txtV7, 7, 1);
            this.tlpRegs.Controls.Add(this.txtV6, 6, 1);
            this.tlpRegs.Controls.Add(this.txtV5, 5, 1);
            this.tlpRegs.Controls.Add(this.txtV4, 4, 1);
            this.tlpRegs.Controls.Add(this.txtV3, 3, 1);
            this.tlpRegs.Controls.Add(this.txtV2, 2, 1);
            this.tlpRegs.Controls.Add(this.txtV1, 1, 1);
            this.tlpRegs.Controls.Add(this.lblV7, 7, 0);
            this.tlpRegs.Controls.Add(this.lblV6, 6, 0);
            this.tlpRegs.Controls.Add(this.lblV5, 5, 0);
            this.tlpRegs.Controls.Add(this.lblV4, 4, 0);
            this.tlpRegs.Controls.Add(this.lblV3, 3, 0);
            this.tlpRegs.Controls.Add(this.lblV2, 2, 0);
            this.tlpRegs.Controls.Add(this.lblV1, 1, 0);
            this.tlpRegs.Controls.Add(this.lblV0, 0, 0);
            this.tlpRegs.Controls.Add(this.txtV0, 0, 1);
            this.tlpRegs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRegs.Location = new System.Drawing.Point(3, 16);
            this.tlpRegs.Name = "tlpRegs";
            this.tlpRegs.RowCount = 4;
            this.tlpRegs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpRegs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpRegs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpRegs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpRegs.Size = new System.Drawing.Size(382, 106);
            this.tlpRegs.TabIndex = 0;
            // 
            // txtVF
            // 
            this.txtVF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVF.Location = new System.Drawing.Point(332, 81);
            this.txtVF.MaxLength = 4;
            this.txtVF.Name = "txtVF";
            this.txtVF.ReadOnly = true;
            this.txtVF.Size = new System.Drawing.Size(47, 20);
            this.txtVF.TabIndex = 31;
            this.txtVF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVE
            // 
            this.txtVE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVE.Location = new System.Drawing.Point(285, 81);
            this.txtVE.MaxLength = 4;
            this.txtVE.Name = "txtVE";
            this.txtVE.ReadOnly = true;
            this.txtVE.Size = new System.Drawing.Size(41, 20);
            this.txtVE.TabIndex = 30;
            this.txtVE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVD
            // 
            this.txtVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVD.Location = new System.Drawing.Point(238, 81);
            this.txtVD.MaxLength = 4;
            this.txtVD.Name = "txtVD";
            this.txtVD.ReadOnly = true;
            this.txtVD.Size = new System.Drawing.Size(41, 20);
            this.txtVD.TabIndex = 29;
            this.txtVD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVC
            // 
            this.txtVC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVC.Location = new System.Drawing.Point(191, 81);
            this.txtVC.MaxLength = 4;
            this.txtVC.Name = "txtVC";
            this.txtVC.ReadOnly = true;
            this.txtVC.Size = new System.Drawing.Size(41, 20);
            this.txtVC.TabIndex = 28;
            this.txtVC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVB
            // 
            this.txtVB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVB.Location = new System.Drawing.Point(144, 81);
            this.txtVB.MaxLength = 4;
            this.txtVB.Name = "txtVB";
            this.txtVB.ReadOnly = true;
            this.txtVB.Size = new System.Drawing.Size(41, 20);
            this.txtVB.TabIndex = 27;
            this.txtVB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVA
            // 
            this.txtVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVA.Location = new System.Drawing.Point(97, 81);
            this.txtVA.MaxLength = 4;
            this.txtVA.Name = "txtVA";
            this.txtVA.ReadOnly = true;
            this.txtVA.Size = new System.Drawing.Size(41, 20);
            this.txtVA.TabIndex = 26;
            this.txtVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtV9
            // 
            this.txtV9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtV9.Location = new System.Drawing.Point(50, 81);
            this.txtV9.MaxLength = 4;
            this.txtV9.Name = "txtV9";
            this.txtV9.ReadOnly = true;
            this.txtV9.Size = new System.Drawing.Size(41, 20);
            this.txtV9.TabIndex = 25;
            this.txtV9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtV8
            // 
            this.txtV8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtV8.Location = new System.Drawing.Point(3, 81);
            this.txtV8.MaxLength = 4;
            this.txtV8.Name = "txtV8";
            this.txtV8.ReadOnly = true;
            this.txtV8.Size = new System.Drawing.Size(41, 20);
            this.txtV8.TabIndex = 24;
            this.txtV8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVF
            // 
            this.lblVF.AutoSize = true;
            this.lblVF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVF.Location = new System.Drawing.Point(332, 52);
            this.lblVF.Name = "lblVF";
            this.lblVF.Size = new System.Drawing.Size(47, 26);
            this.lblVF.TabIndex = 23;
            this.lblVF.Text = "VF";
            this.lblVF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVE
            // 
            this.lblVE.AutoSize = true;
            this.lblVE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVE.Location = new System.Drawing.Point(285, 52);
            this.lblVE.Name = "lblVE";
            this.lblVE.Size = new System.Drawing.Size(41, 26);
            this.lblVE.TabIndex = 22;
            this.lblVE.Text = "VE";
            this.lblVE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVD
            // 
            this.lblVD.AutoSize = true;
            this.lblVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVD.Location = new System.Drawing.Point(238, 52);
            this.lblVD.Name = "lblVD";
            this.lblVD.Size = new System.Drawing.Size(41, 26);
            this.lblVD.TabIndex = 21;
            this.lblVD.Text = "VD";
            this.lblVD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVC
            // 
            this.lblVC.AutoSize = true;
            this.lblVC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVC.Location = new System.Drawing.Point(191, 52);
            this.lblVC.Name = "lblVC";
            this.lblVC.Size = new System.Drawing.Size(41, 26);
            this.lblVC.TabIndex = 20;
            this.lblVC.Text = "VC";
            this.lblVC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVB
            // 
            this.lblVB.AutoSize = true;
            this.lblVB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVB.Location = new System.Drawing.Point(144, 52);
            this.lblVB.Name = "lblVB";
            this.lblVB.Size = new System.Drawing.Size(41, 26);
            this.lblVB.TabIndex = 19;
            this.lblVB.Text = "VB";
            this.lblVB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVA
            // 
            this.lblVA.AutoSize = true;
            this.lblVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVA.Location = new System.Drawing.Point(97, 52);
            this.lblVA.Name = "lblVA";
            this.lblVA.Size = new System.Drawing.Size(41, 26);
            this.lblVA.TabIndex = 18;
            this.lblVA.Text = "VA";
            this.lblVA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblV9
            // 
            this.lblV9.AutoSize = true;
            this.lblV9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblV9.Location = new System.Drawing.Point(50, 52);
            this.lblV9.Name = "lblV9";
            this.lblV9.Size = new System.Drawing.Size(41, 26);
            this.lblV9.TabIndex = 17;
            this.lblV9.Text = "V9";
            this.lblV9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblV8
            // 
            this.lblV8.AutoSize = true;
            this.lblV8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblV8.Location = new System.Drawing.Point(3, 52);
            this.lblV8.Name = "lblV8";
            this.lblV8.Size = new System.Drawing.Size(41, 26);
            this.lblV8.TabIndex = 16;
            this.lblV8.Text = "V8";
            this.lblV8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtV7
            // 
            this.txtV7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtV7.Location = new System.Drawing.Point(332, 29);
            this.txtV7.MaxLength = 4;
            this.txtV7.Name = "txtV7";
            this.txtV7.ReadOnly = true;
            this.txtV7.Size = new System.Drawing.Size(47, 20);
            this.txtV7.TabIndex = 15;
            this.txtV7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtV6
            // 
            this.txtV6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtV6.Location = new System.Drawing.Point(285, 29);
            this.txtV6.MaxLength = 4;
            this.txtV6.Name = "txtV6";
            this.txtV6.ReadOnly = true;
            this.txtV6.Size = new System.Drawing.Size(41, 20);
            this.txtV6.TabIndex = 14;
            this.txtV6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtV5
            // 
            this.txtV5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtV5.Location = new System.Drawing.Point(238, 29);
            this.txtV5.MaxLength = 4;
            this.txtV5.Name = "txtV5";
            this.txtV5.ReadOnly = true;
            this.txtV5.Size = new System.Drawing.Size(41, 20);
            this.txtV5.TabIndex = 13;
            this.txtV5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtV4
            // 
            this.txtV4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtV4.Location = new System.Drawing.Point(191, 29);
            this.txtV4.MaxLength = 4;
            this.txtV4.Name = "txtV4";
            this.txtV4.ReadOnly = true;
            this.txtV4.Size = new System.Drawing.Size(41, 20);
            this.txtV4.TabIndex = 12;
            this.txtV4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtV3
            // 
            this.txtV3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtV3.Location = new System.Drawing.Point(144, 29);
            this.txtV3.MaxLength = 4;
            this.txtV3.Name = "txtV3";
            this.txtV3.ReadOnly = true;
            this.txtV3.Size = new System.Drawing.Size(41, 20);
            this.txtV3.TabIndex = 11;
            this.txtV3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtV2
            // 
            this.txtV2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtV2.Location = new System.Drawing.Point(97, 29);
            this.txtV2.MaxLength = 4;
            this.txtV2.Name = "txtV2";
            this.txtV2.ReadOnly = true;
            this.txtV2.Size = new System.Drawing.Size(41, 20);
            this.txtV2.TabIndex = 10;
            this.txtV2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtV1
            // 
            this.txtV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtV1.Location = new System.Drawing.Point(50, 29);
            this.txtV1.MaxLength = 4;
            this.txtV1.Name = "txtV1";
            this.txtV1.ReadOnly = true;
            this.txtV1.Size = new System.Drawing.Size(41, 20);
            this.txtV1.TabIndex = 9;
            this.txtV1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblV7
            // 
            this.lblV7.AutoSize = true;
            this.lblV7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblV7.Location = new System.Drawing.Point(332, 0);
            this.lblV7.Name = "lblV7";
            this.lblV7.Size = new System.Drawing.Size(47, 26);
            this.lblV7.TabIndex = 7;
            this.lblV7.Text = "V7";
            this.lblV7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblV6
            // 
            this.lblV6.AutoSize = true;
            this.lblV6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblV6.Location = new System.Drawing.Point(285, 0);
            this.lblV6.Name = "lblV6";
            this.lblV6.Size = new System.Drawing.Size(41, 26);
            this.lblV6.TabIndex = 6;
            this.lblV6.Text = "V6";
            this.lblV6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblV5
            // 
            this.lblV5.AutoSize = true;
            this.lblV5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblV5.Location = new System.Drawing.Point(238, 0);
            this.lblV5.Name = "lblV5";
            this.lblV5.Size = new System.Drawing.Size(41, 26);
            this.lblV5.TabIndex = 5;
            this.lblV5.Text = "V5";
            this.lblV5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblV4
            // 
            this.lblV4.AutoSize = true;
            this.lblV4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblV4.Location = new System.Drawing.Point(191, 0);
            this.lblV4.Name = "lblV4";
            this.lblV4.Size = new System.Drawing.Size(41, 26);
            this.lblV4.TabIndex = 4;
            this.lblV4.Text = "V4";
            this.lblV4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblV3
            // 
            this.lblV3.AutoSize = true;
            this.lblV3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblV3.Location = new System.Drawing.Point(144, 0);
            this.lblV3.Name = "lblV3";
            this.lblV3.Size = new System.Drawing.Size(41, 26);
            this.lblV3.TabIndex = 3;
            this.lblV3.Text = "V3";
            this.lblV3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblV2
            // 
            this.lblV2.AutoSize = true;
            this.lblV2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblV2.Location = new System.Drawing.Point(97, 0);
            this.lblV2.Name = "lblV2";
            this.lblV2.Size = new System.Drawing.Size(41, 26);
            this.lblV2.TabIndex = 2;
            this.lblV2.Text = "V2";
            this.lblV2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblV1
            // 
            this.lblV1.AutoSize = true;
            this.lblV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblV1.Location = new System.Drawing.Point(50, 0);
            this.lblV1.Name = "lblV1";
            this.lblV1.Size = new System.Drawing.Size(41, 26);
            this.lblV1.TabIndex = 1;
            this.lblV1.Text = "V1";
            this.lblV1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblV0
            // 
            this.lblV0.AutoSize = true;
            this.lblV0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblV0.Location = new System.Drawing.Point(3, 0);
            this.lblV0.Name = "lblV0";
            this.lblV0.Size = new System.Drawing.Size(41, 26);
            this.lblV0.TabIndex = 0;
            this.lblV0.Text = "V0";
            this.lblV0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtV0
            // 
            this.txtV0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtV0.Location = new System.Drawing.Point(3, 29);
            this.txtV0.MaxLength = 4;
            this.txtV0.Name = "txtV0";
            this.txtV0.ReadOnly = true;
            this.txtV0.Size = new System.Drawing.Size(41, 20);
            this.txtV0.TabIndex = 8;
            this.txtV0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmRegInspect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 218);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmRegInspect";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register inspector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRegInspect_FormClosing);
            this.Load += new System.EventHandler(this.FrmRegInspect_Load);
            this.grpGeneral.ResumeLayout(false);
            this.tlpGeneral.ResumeLayout(false);
            this.tlpGeneral.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.grpTimers.ResumeLayout(false);
            this.tlpTimers.ResumeLayout(false);
            this.tlpTimers.PerformLayout();
            this.grpRegs.ResumeLayout(false);
            this.tlpRegs.ResumeLayout(false);
            this.tlpRegs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblI;
        private System.Windows.Forms.Label lblSP;
        private System.Windows.Forms.Label lblPC;
        private System.Windows.Forms.TextBox txtPC;
        private System.Windows.Forms.TextBox txtI;
        private System.Windows.Forms.TextBox txtSP;
        private System.Windows.Forms.GroupBox grpTimers;
        private System.Windows.Forms.TextBox txtSound;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.Label lblSound;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.GroupBox grpRegs;
        private System.Windows.Forms.TableLayoutPanel tlpRegs;
        private System.Windows.Forms.Label lblV0;
        private System.Windows.Forms.TextBox txtVF;
        private System.Windows.Forms.TextBox txtVE;
        private System.Windows.Forms.TextBox txtVD;
        private System.Windows.Forms.TextBox txtVC;
        private System.Windows.Forms.TextBox txtVB;
        private System.Windows.Forms.TextBox txtVA;
        private System.Windows.Forms.TextBox txtV9;
        private System.Windows.Forms.TextBox txtV8;
        private System.Windows.Forms.Label lblVF;
        private System.Windows.Forms.Label lblVE;
        private System.Windows.Forms.Label lblVD;
        private System.Windows.Forms.Label lblVC;
        private System.Windows.Forms.Label lblVB;
        private System.Windows.Forms.Label lblVA;
        private System.Windows.Forms.Label lblV9;
        private System.Windows.Forms.Label lblV8;
        private System.Windows.Forms.TextBox txtV7;
        private System.Windows.Forms.TextBox txtV6;
        private System.Windows.Forms.TextBox txtV5;
        private System.Windows.Forms.TextBox txtV4;
        private System.Windows.Forms.TextBox txtV3;
        private System.Windows.Forms.TextBox txtV2;
        private System.Windows.Forms.TextBox txtV1;
        private System.Windows.Forms.Label lblV7;
        private System.Windows.Forms.Label lblV6;
        private System.Windows.Forms.Label lblV5;
        private System.Windows.Forms.Label lblV4;
        private System.Windows.Forms.Label lblV3;
        private System.Windows.Forms.Label lblV2;
        private System.Windows.Forms.Label lblV1;
        private System.Windows.Forms.TextBox txtV0;
        private System.Windows.Forms.TableLayoutPanel tlpGeneral;
        private System.Windows.Forms.TableLayoutPanel tlpTimers;
    }
}