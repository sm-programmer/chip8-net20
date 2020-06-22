namespace UIControls
{
    partial class MemoryViewer
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
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.txtContents = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // vScrollBar
            // 
            this.vScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar.Location = new System.Drawing.Point(224, 0);
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(16, 160);
            this.vScrollBar.TabIndex = 0;
            this.vScrollBar.ValueChanged += new System.EventHandler(this.vScrollBar_ValueChanged);
            // 
            // txtContents
            // 
            this.txtContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContents.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContents.Location = new System.Drawing.Point(0, 0);
            this.txtContents.Multiline = true;
            this.txtContents.Name = "txtContents";
            this.txtContents.ReadOnly = true;
            this.txtContents.Size = new System.Drawing.Size(224, 160);
            this.txtContents.TabIndex = 1;
            this.txtContents.WordWrap = false;
            // 
            // MemoryViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtContents);
            this.Controls.Add(this.vScrollBar);
            this.Name = "MemoryViewer";
            this.Size = new System.Drawing.Size(240, 160);
            this.Resize += new System.EventHandler(this.MemoryViewer_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBar;
        private System.Windows.Forms.TextBox txtContents;
    }
}
