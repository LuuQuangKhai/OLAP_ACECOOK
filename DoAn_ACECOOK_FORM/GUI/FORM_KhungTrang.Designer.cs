namespace GUI
{
    partial class FORM_KhungTrang
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
            menuStrip1 = new MenuStrip();
            trangChủToolStripMenuItem = new ToolStripMenuItem();
            quảnTrịToolStripMenuItem = new ToolStripMenuItem();
            panel_KhungTrang = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { trangChủToolStripMenuItem, quảnTrịToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1229, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            trangChủToolStripMenuItem.Size = new Size(71, 20);
            trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // quảnTrịToolStripMenuItem
            // 
            quảnTrịToolStripMenuItem.Name = "quảnTrịToolStripMenuItem";
            quảnTrịToolStripMenuItem.Size = new Size(62, 20);
            quảnTrịToolStripMenuItem.Text = "Quản trị";
            // 
            // panel_KhungTrang
            // 
            panel_KhungTrang.Location = new Point(12, 27);
            panel_KhungTrang.Name = "panel_KhungTrang";
            panel_KhungTrang.Size = new Size(1205, 706);
            panel_KhungTrang.TabIndex = 1;
            // 
            // FORM_KhungTrang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 745);
            Controls.Add(panel_KhungTrang);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FORM_KhungTrang";
            Load += FORM_KhungTrang_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem trangChủToolStripMenuItem;
        private ToolStripMenuItem quảnTrịToolStripMenuItem;
        private Panel panel_KhungTrang;
    }
}