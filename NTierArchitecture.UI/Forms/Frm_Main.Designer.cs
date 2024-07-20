namespace NTierArchitecture.UI.Forms
{
    partial class Frm_Main
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
            mENUToolStripMenuItem = new ToolStripMenuItem();
            tANIMLAMALARToolStripMenuItem = new ToolStripMenuItem();
            kategoriTanımlarıToolStripMenuItem = new ToolStripMenuItem();
            ürünTanımlarıToolStripMenuItem = new ToolStripMenuItem();
            tedarikçiTanımlarıToolStripMenuItem = new ToolStripMenuItem();
            iŞLEMLERToolStripMenuItem = new ToolStripMenuItem();
            siparişOluşturToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 20F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mENUToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(814, 45);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            mENUToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tANIMLAMALARToolStripMenuItem, iŞLEMLERToolStripMenuItem });
            mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            mENUToolStripMenuItem.Size = new Size(129, 41);
            mENUToolStripMenuItem.Text = "MENU #";
            // 
            // tANIMLAMALARToolStripMenuItem
            // 
            tANIMLAMALARToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kategoriTanımlarıToolStripMenuItem, ürünTanımlarıToolStripMenuItem, tedarikçiTanımlarıToolStripMenuItem });
            tANIMLAMALARToolStripMenuItem.Name = "tANIMLAMALARToolStripMenuItem";
            tANIMLAMALARToolStripMenuItem.Size = new Size(293, 42);
            tANIMLAMALARToolStripMenuItem.Text = "TANIMLAMALAR";
            // 
            // kategoriTanımlarıToolStripMenuItem
            // 
            kategoriTanımlarıToolStripMenuItem.Name = "kategoriTanımlarıToolStripMenuItem";
            kategoriTanımlarıToolStripMenuItem.Size = new Size(311, 42);
            kategoriTanımlarıToolStripMenuItem.Text = "Kategori Tanımları";
            kategoriTanımlarıToolStripMenuItem.Click += kategoriTanımlarıToolStripMenuItem_Click;
            // 
            // ürünTanımlarıToolStripMenuItem
            // 
            ürünTanımlarıToolStripMenuItem.Name = "ürünTanımlarıToolStripMenuItem";
            ürünTanımlarıToolStripMenuItem.Size = new Size(311, 42);
            ürünTanımlarıToolStripMenuItem.Text = "Ürün Tanımları";
            ürünTanımlarıToolStripMenuItem.Click += ürünTanımlarıToolStripMenuItem_Click;
            // 
            // tedarikçiTanımlarıToolStripMenuItem
            // 
            tedarikçiTanımlarıToolStripMenuItem.Name = "tedarikçiTanımlarıToolStripMenuItem";
            tedarikçiTanımlarıToolStripMenuItem.Size = new Size(311, 42);
            tedarikçiTanımlarıToolStripMenuItem.Text = "Tedarikçi Tanımları";
            tedarikçiTanımlarıToolStripMenuItem.Click += tedarikçiTanımlarıToolStripMenuItem_Click;
            // 
            // iŞLEMLERToolStripMenuItem
            // 
            iŞLEMLERToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { siparişOluşturToolStripMenuItem });
            iŞLEMLERToolStripMenuItem.Name = "iŞLEMLERToolStripMenuItem";
            iŞLEMLERToolStripMenuItem.Size = new Size(293, 42);
            iŞLEMLERToolStripMenuItem.Text = "İŞLEMLER";
            // 
            // siparişOluşturToolStripMenuItem
            // 
            siparişOluşturToolStripMenuItem.Name = "siparişOluşturToolStripMenuItem";
            siparişOluşturToolStripMenuItem.Size = new Size(265, 42);
            siparişOluşturToolStripMenuItem.Text = "Sipariş Oluştur";
            siparişOluşturToolStripMenuItem.Click += siparişOluşturToolStripMenuItem_Click;
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 568);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 20F);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6, 7, 6, 7);
            Name = "Frm_Main";
            Text = "Frm_Main";
            WindowState = FormWindowState.Maximized;
            Load += Frm_Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mENUToolStripMenuItem;
        private ToolStripMenuItem tANIMLAMALARToolStripMenuItem;
        private ToolStripMenuItem kategoriTanımlarıToolStripMenuItem;
        private ToolStripMenuItem ürünTanımlarıToolStripMenuItem;
        private ToolStripMenuItem tedarikçiTanımlarıToolStripMenuItem;
        private ToolStripMenuItem iŞLEMLERToolStripMenuItem;
        private ToolStripMenuItem siparişOluşturToolStripMenuItem;
    }
}