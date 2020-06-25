namespace Chip8_NET20
{
    partial class FrmMain
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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuChip8 = new System.Windows.Forms.ToolStripMenuItem();
            this.itemLoadProg = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemStart = new System.Windows.Forms.ToolStripMenuItem();
            this.itemStop = new System.Windows.Forms.ToolStripMenuItem();
            this.itemColdReset = new System.Windows.Forms.ToolStripMenuItem();
            this.itemWarmReset = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.itemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpts = new System.Windows.Forms.ToolStripMenuItem();
            this.itemClearScrStart = new System.Windows.Forms.ToolStripMenuItem();
            this.itemModifyI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.submenuFonts = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFontDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFontAlt = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFont7Seg = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFontLowercase = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuBuzzer = new System.Windows.Forms.ToolStripMenuItem();
            this.itemBuzz736Square = new System.Windows.Forms.ToolStripMenuItem();
            this.itemBuzz787Sine = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuSpeed = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSpeedSlow = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSpeedNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSpeedFast = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.itemShowDevTools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDev = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDevMemViewer = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDevRegInspect = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDevStackViewer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.itemDevCycleStep = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tsContainer = new System.Windows.Forms.ToolStripContainer();
            this.disp = new Display.DisplayUI();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.btnLoadProg = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnStart = new System.Windows.Forms.ToolStripButton();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.btnColdReset = new System.Windows.Forms.ToolStripButton();
            this.btnWarmReset = new System.Windows.Forms.ToolStripButton();
            this.menuBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.tsContainer.ContentPanel.SuspendLayout();
            this.tsContainer.TopToolStripPanel.SuspendLayout();
            this.tsContainer.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuChip8,
            this.menuOpts,
            this.menuDev,
            this.menuHelp});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(504, 24);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // menuChip8
            // 
            this.menuChip8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemLoadProg,
            this.toolStripSeparator1,
            this.itemStart,
            this.itemStop,
            this.itemColdReset,
            this.itemWarmReset,
            this.toolStripSeparator2,
            this.itemExit});
            this.menuChip8.Name = "menuChip8";
            this.menuChip8.Size = new System.Drawing.Size(53, 20);
            this.menuChip8.Text = "&CHIP-8";
            // 
            // itemLoadProg
            // 
            this.itemLoadProg.Name = "itemLoadProg";
            this.itemLoadProg.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.itemLoadProg.Size = new System.Drawing.Size(203, 22);
            this.itemLoadProg.Text = "&Load program...";
            this.itemLoadProg.Click += new System.EventHandler(this.OnLoadProgram);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // itemStart
            // 
            this.itemStart.Enabled = false;
            this.itemStart.Name = "itemStart";
            this.itemStart.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.itemStart.Size = new System.Drawing.Size(203, 22);
            this.itemStart.Text = "&Start";
            this.itemStart.Click += new System.EventHandler(this.OnComputerStart);
            // 
            // itemStop
            // 
            this.itemStop.Enabled = false;
            this.itemStop.Name = "itemStop";
            this.itemStop.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F5)));
            this.itemStop.Size = new System.Drawing.Size(203, 22);
            this.itemStop.Text = "S&top";
            this.itemStop.Click += new System.EventHandler(this.OnComputerStop);
            // 
            // itemColdReset
            // 
            this.itemColdReset.Name = "itemColdReset";
            this.itemColdReset.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.itemColdReset.Size = new System.Drawing.Size(203, 22);
            this.itemColdReset.Text = "&Cold reset";
            this.itemColdReset.Click += new System.EventHandler(this.OnComputerColdReset);
            // 
            // itemWarmReset
            // 
            this.itemWarmReset.Name = "itemWarmReset";
            this.itemWarmReset.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.itemWarmReset.Size = new System.Drawing.Size(203, 22);
            this.itemWarmReset.Text = "&Warm reset";
            this.itemWarmReset.Click += new System.EventHandler(this.OnComputerWarmReset);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(200, 6);
            // 
            // itemExit
            // 
            this.itemExit.Name = "itemExit";
            this.itemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.itemExit.Size = new System.Drawing.Size(203, 22);
            this.itemExit.Text = "&Exit";
            this.itemExit.Click += new System.EventHandler(this.itemExit_Click);
            // 
            // menuOpts
            // 
            this.menuOpts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemClearScrStart,
            this.itemModifyI,
            this.toolStripSeparator3,
            this.submenuFonts,
            this.submenuBuzzer,
            this.submenuSpeed,
            this.toolStripSeparator5,
            this.itemShowDevTools});
            this.menuOpts.Name = "menuOpts";
            this.menuOpts.Size = new System.Drawing.Size(56, 20);
            this.menuOpts.Text = "&Options";
            // 
            // itemClearScrStart
            // 
            this.itemClearScrStart.CheckOnClick = true;
            this.itemClearScrStart.Name = "itemClearScrStart";
            this.itemClearScrStart.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.itemClearScrStart.Size = new System.Drawing.Size(233, 22);
            this.itemClearScrStart.Text = "&Clear screen on start";
            this.itemClearScrStart.CheckedChanged += new System.EventHandler(this.itemClearScrStart_CheckedChanged);
            // 
            // itemModifyI
            // 
            this.itemModifyI.CheckOnClick = true;
            this.itemModifyI.Name = "itemModifyI";
            this.itemModifyI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.itemModifyI.Size = new System.Drawing.Size(233, 22);
            this.itemModifyI.Text = "&Modify I on FX55, FX65";
            this.itemModifyI.CheckedChanged += new System.EventHandler(this.itemModifyI_CheckedChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(230, 6);
            // 
            // submenuFonts
            // 
            this.submenuFonts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemFontDefault,
            this.itemFontAlt,
            this.itemFont7Seg,
            this.itemFontLowercase});
            this.submenuFonts.Name = "submenuFonts";
            this.submenuFonts.Size = new System.Drawing.Size(233, 22);
            this.submenuFonts.Text = "System &font";
            // 
            // itemFontDefault
            // 
            this.itemFontDefault.Name = "itemFontDefault";
            this.itemFontDefault.Size = new System.Drawing.Size(140, 22);
            this.itemFontDefault.Tag = "fonts\\default.ch8";
            this.itemFontDefault.Text = "&Default";
            this.itemFontDefault.Click += new System.EventHandler(this.itemFont_Click);
            // 
            // itemFontAlt
            // 
            this.itemFontAlt.Name = "itemFontAlt";
            this.itemFontAlt.Size = new System.Drawing.Size(140, 22);
            this.itemFontAlt.Tag = "fonts\\alt.ch8";
            this.itemFontAlt.Text = "&Alternative";
            this.itemFontAlt.Click += new System.EventHandler(this.itemFont_Click);
            // 
            // itemFont7Seg
            // 
            this.itemFont7Seg.Name = "itemFont7Seg";
            this.itemFont7Seg.Size = new System.Drawing.Size(140, 22);
            this.itemFont7Seg.Tag = "fonts\\7seg.ch8";
            this.itemFont7Seg.Text = "&7 segments";
            this.itemFont7Seg.Click += new System.EventHandler(this.itemFont_Click);
            // 
            // itemFontLowercase
            // 
            this.itemFontLowercase.Name = "itemFontLowercase";
            this.itemFontLowercase.Size = new System.Drawing.Size(140, 22);
            this.itemFontLowercase.Tag = "fonts\\lowercase.ch8";
            this.itemFontLowercase.Text = "&Lowercase";
            this.itemFontLowercase.Click += new System.EventHandler(this.itemFont_Click);
            // 
            // submenuBuzzer
            // 
            this.submenuBuzzer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemBuzz736Square,
            this.itemBuzz787Sine});
            this.submenuBuzzer.Name = "submenuBuzzer";
            this.submenuBuzzer.Size = new System.Drawing.Size(233, 22);
            this.submenuBuzzer.Text = "&Buzzer";
            // 
            // itemBuzz736Square
            // 
            this.itemBuzz736Square.Name = "itemBuzz736Square";
            this.itemBuzz736Square.Size = new System.Drawing.Size(185, 22);
            this.itemBuzz736Square.Tag = "sounds\\736hz-square.wav";
            this.itemBuzz736Square.Text = "(&1) Square @ 736 Hz";
            this.itemBuzz736Square.Click += new System.EventHandler(this.itemBuzzer_Click);
            // 
            // itemBuzz787Sine
            // 
            this.itemBuzz787Sine.Name = "itemBuzz787Sine";
            this.itemBuzz787Sine.Size = new System.Drawing.Size(185, 22);
            this.itemBuzz787Sine.Tag = "sounds\\787hz-sine.wav";
            this.itemBuzz787Sine.Text = "(&2) Sine @ 787 Hz";
            this.itemBuzz787Sine.Click += new System.EventHandler(this.itemBuzzer_Click);
            // 
            // submenuSpeed
            // 
            this.submenuSpeed.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemSpeedSlow,
            this.itemSpeedNormal,
            this.itemSpeedFast});
            this.submenuSpeed.Name = "submenuSpeed";
            this.submenuSpeed.Size = new System.Drawing.Size(233, 22);
            this.submenuSpeed.Text = "&Processor speed";
            // 
            // itemSpeedSlow
            // 
            this.itemSpeedSlow.Name = "itemSpeedSlow";
            this.itemSpeedSlow.Size = new System.Drawing.Size(162, 22);
            this.itemSpeedSlow.Tag = "250";
            this.itemSpeedSlow.Text = "&Slow (250 Hz)";
            this.itemSpeedSlow.Click += new System.EventHandler(this.itemSpeed_Click);
            // 
            // itemSpeedNormal
            // 
            this.itemSpeedNormal.Name = "itemSpeedNormal";
            this.itemSpeedNormal.Size = new System.Drawing.Size(162, 22);
            this.itemSpeedNormal.Tag = "500";
            this.itemSpeedNormal.Text = "&Normal (500 Hz)";
            this.itemSpeedNormal.Click += new System.EventHandler(this.itemSpeed_Click);
            // 
            // itemSpeedFast
            // 
            this.itemSpeedFast.Name = "itemSpeedFast";
            this.itemSpeedFast.Size = new System.Drawing.Size(162, 22);
            this.itemSpeedFast.Tag = "1000";
            this.itemSpeedFast.Text = "&Fast (1000 Hz)";
            this.itemSpeedFast.Click += new System.EventHandler(this.itemSpeed_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(230, 6);
            // 
            // itemShowDevTools
            // 
            this.itemShowDevTools.CheckOnClick = true;
            this.itemShowDevTools.Name = "itemShowDevTools";
            this.itemShowDevTools.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.itemShowDevTools.Size = new System.Drawing.Size(233, 22);
            this.itemShowDevTools.Text = "Show &developer tools";
            this.itemShowDevTools.CheckedChanged += new System.EventHandler(this.itemShowDevTools_CheckedChanged);
            // 
            // menuDev
            // 
            this.menuDev.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemDevMemViewer,
            this.itemDevRegInspect,
            this.itemDevStackViewer,
            this.toolStripSeparator6,
            this.itemDevCycleStep});
            this.menuDev.Name = "menuDev";
            this.menuDev.Size = new System.Drawing.Size(68, 20);
            this.menuDev.Text = "&Developer";
            this.menuDev.Visible = false;
            // 
            // itemDevMemViewer
            // 
            this.itemDevMemViewer.Enabled = false;
            this.itemDevMemViewer.Name = "itemDevMemViewer";
            this.itemDevMemViewer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.itemDevMemViewer.Size = new System.Drawing.Size(211, 22);
            this.itemDevMemViewer.Text = "&Memory viewer";
            this.itemDevMemViewer.Click += new System.EventHandler(this.itemDevMemViewer_Click);
            // 
            // itemDevRegInspect
            // 
            this.itemDevRegInspect.Enabled = false;
            this.itemDevRegInspect.Name = "itemDevRegInspect";
            this.itemDevRegInspect.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.itemDevRegInspect.Size = new System.Drawing.Size(211, 22);
            this.itemDevRegInspect.Text = "&Register inspector";
            this.itemDevRegInspect.Click += new System.EventHandler(this.itemDevRegInspect_Click);
            // 
            // itemDevStackViewer
            // 
            this.itemDevStackViewer.Enabled = false;
            this.itemDevStackViewer.Name = "itemDevStackViewer";
            this.itemDevStackViewer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.itemDevStackViewer.Size = new System.Drawing.Size(211, 22);
            this.itemDevStackViewer.Text = "&Stack viewer";
            this.itemDevStackViewer.Click += new System.EventHandler(this.itemDevStackViewer_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(208, 6);
            // 
            // itemDevCycleStep
            // 
            this.itemDevCycleStep.CheckOnClick = true;
            this.itemDevCycleStep.Enabled = false;
            this.itemDevCycleStep.Name = "itemDevCycleStep";
            this.itemDevCycleStep.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.itemDevCycleStep.Size = new System.Drawing.Size(211, 22);
            this.itemDevCycleStep.Text = "&Cycle step";
            this.itemDevCycleStep.CheckedChanged += new System.EventHandler(this.itemDevCycleStep_CheckedChanged);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(40, 20);
            this.menuHelp.Text = "&Help";
            // 
            // itemAbout
            // 
            this.itemAbout.Name = "itemAbout";
            this.itemAbout.Size = new System.Drawing.Size(126, 22);
            this.itemAbout.Text = "&About...";
            this.itemAbout.Click += new System.EventHandler(this.itemAbout_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusBar.Location = new System.Drawing.Point(0, 335);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(504, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(141, 17);
            this.lblStatus.Text = "This is the CHIP-8 emulator.";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "CHIP-8 programs (*.c8; *.ch8)|*.c8;*.ch8";
            this.openFileDialog.InitialDirectory = ".";
            this.openFileDialog.Title = "Open CHIP-8 program";
            // 
            // tsContainer
            // 
            // 
            // tsContainer.ContentPanel
            // 
            this.tsContainer.ContentPanel.Controls.Add(this.disp);
            this.tsContainer.ContentPanel.Size = new System.Drawing.Size(504, 272);
            this.tsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsContainer.Location = new System.Drawing.Point(0, 24);
            this.tsContainer.Name = "tsContainer";
            this.tsContainer.Size = new System.Drawing.Size(504, 311);
            this.tsContainer.TabIndex = 4;
            this.tsContainer.Text = "toolStripContainer1";
            // 
            // tsContainer.TopToolStripPanel
            // 
            this.tsContainer.TopToolStripPanel.Controls.Add(this.toolBar);
            // 
            // disp
            // 
            this.disp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disp.Location = new System.Drawing.Point(0, 0);
            this.disp.Name = "disp";
            this.disp.Size = new System.Drawing.Size(504, 272);
            this.disp.TabIndex = 3;
            // 
            // toolBar
            // 
            this.toolBar.Dock = System.Windows.Forms.DockStyle.None;
            this.toolBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoadProg,
            this.toolStripSeparator4,
            this.btnStart,
            this.btnStop,
            this.btnColdReset,
            this.btnWarmReset});
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(504, 39);
            this.toolBar.Stretch = true;
            this.toolBar.TabIndex = 4;
            this.toolBar.Text = "toolStrip1";
            // 
            // btnLoadProg
            // 
            this.btnLoadProg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLoadProg.Image = global::Chip8_NET20.Icons.open;
            this.btnLoadProg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadProg.Name = "btnLoadProg";
            this.btnLoadProg.Size = new System.Drawing.Size(36, 36);
            this.btnLoadProg.Text = "toolStripButton1";
            this.btnLoadProg.ToolTipText = "Load program...";
            this.btnLoadProg.Click += new System.EventHandler(this.OnLoadProgram);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // btnStart
            // 
            this.btnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStart.Enabled = false;
            this.btnStart.Image = global::Chip8_NET20.Icons.start;
            this.btnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(36, 36);
            this.btnStart.Text = "toolStripButton2";
            this.btnStart.ToolTipText = "Start";
            this.btnStart.Click += new System.EventHandler(this.OnComputerStart);
            // 
            // btnStop
            // 
            this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStop.Enabled = false;
            this.btnStop.Image = global::Chip8_NET20.Icons.stop;
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(36, 36);
            this.btnStop.Text = "toolStripButton3";
            this.btnStop.ToolTipText = "Stop";
            this.btnStop.Click += new System.EventHandler(this.OnComputerStop);
            // 
            // btnColdReset
            // 
            this.btnColdReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnColdReset.Image = global::Chip8_NET20.Icons.coldReset;
            this.btnColdReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnColdReset.Name = "btnColdReset";
            this.btnColdReset.Size = new System.Drawing.Size(36, 36);
            this.btnColdReset.Text = "toolStripButton4";
            this.btnColdReset.ToolTipText = "Cold reset";
            this.btnColdReset.Click += new System.EventHandler(this.OnComputerColdReset);
            // 
            // btnWarmReset
            // 
            this.btnWarmReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnWarmReset.Image = global::Chip8_NET20.Icons.warmReset;
            this.btnWarmReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnWarmReset.Name = "btnWarmReset";
            this.btnWarmReset.Size = new System.Drawing.Size(36, 36);
            this.btnWarmReset.Text = "toolStripButton5";
            this.btnWarmReset.ToolTipText = "Warm reset";
            this.btnWarmReset.Click += new System.EventHandler(this.OnComputerWarmReset);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 357);
            this.Controls.Add(this.tsContainer);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The CHIP-8 emulator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.tsContainer.ContentPanel.ResumeLayout(false);
            this.tsContainer.TopToolStripPanel.ResumeLayout(false);
            this.tsContainer.TopToolStripPanel.PerformLayout();
            this.tsContainer.ResumeLayout(false);
            this.tsContainer.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem menuChip8;
        private System.Windows.Forms.ToolStripMenuItem itemLoadProg;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem itemStart;
        private System.Windows.Forms.ToolStripMenuItem itemStop;
        private System.Windows.Forms.ToolStripMenuItem itemColdReset;
        private System.Windows.Forms.ToolStripMenuItem itemWarmReset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem itemExit;
        private System.Windows.Forms.ToolStripMenuItem menuOpts;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem itemAbout;
        private System.Windows.Forms.ToolStripMenuItem itemClearScrStart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem itemModifyI;
        private System.Windows.Forms.ToolStripMenuItem submenuFonts;
        private System.Windows.Forms.ToolStripMenuItem itemFontDefault;
        private System.Windows.Forms.ToolStripMenuItem itemFontAlt;
        private System.Windows.Forms.ToolStripMenuItem itemFont7Seg;
        private System.Windows.Forms.ToolStripMenuItem itemFontLowercase;
        private System.Windows.Forms.ToolStripMenuItem submenuBuzzer;
        private System.Windows.Forms.ToolStripMenuItem itemBuzz736Square;
        private System.Windows.Forms.ToolStripMenuItem itemBuzz787Sine;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripContainer tsContainer;
        private Display.DisplayUI disp;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton btnLoadProg;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnStart;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ToolStripButton btnColdReset;
        private System.Windows.Forms.ToolStripButton btnWarmReset;
        private System.Windows.Forms.ToolStripMenuItem submenuSpeed;
        private System.Windows.Forms.ToolStripMenuItem itemSpeedSlow;
        private System.Windows.Forms.ToolStripMenuItem itemSpeedNormal;
        private System.Windows.Forms.ToolStripMenuItem itemSpeedFast;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem itemShowDevTools;
        private System.Windows.Forms.ToolStripMenuItem menuDev;
        private System.Windows.Forms.ToolStripMenuItem itemDevMemViewer;
        private System.Windows.Forms.ToolStripMenuItem itemDevRegInspect;
        private System.Windows.Forms.ToolStripMenuItem itemDevStackViewer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem itemDevCycleStep;
    }
}

