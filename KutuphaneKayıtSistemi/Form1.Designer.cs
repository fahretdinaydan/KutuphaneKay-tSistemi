namespace KutuphaneKayıtSistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kitapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKitapEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitaplarıGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ogrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ogrenciToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ogrencileriGoruntuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sayıKitaplarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitaplarıİadeEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.oduncAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iadeEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.Font = new System.Drawing.Font("Book Antiqua", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapToolStripMenuItem,
            this.ogrenciToolStripMenuItem,
            this.sayıKitaplarıToolStripMenuItem,
            this.kitaplarıİadeEtToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(878, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kitapToolStripMenuItem
            // 
            this.kitapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKitapEkleToolStripMenuItem,
            this.kitaplarıGörüntüleToolStripMenuItem});
            this.kitapToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kitapToolStripMenuItem.Image")));
            this.kitapToolStripMenuItem.Name = "kitapToolStripMenuItem";
            this.kitapToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.kitapToolStripMenuItem.Text = "Books";
            this.kitapToolStripMenuItem.Click += new System.EventHandler(this.kitapToolStripMenuItem_Click);
            // 
            // yeniKitapEkleToolStripMenuItem
            // 
            this.yeniKitapEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yeniKitapEkleToolStripMenuItem.Image")));
            this.yeniKitapEkleToolStripMenuItem.Name = "yeniKitapEkleToolStripMenuItem";
            this.yeniKitapEkleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.yeniKitapEkleToolStripMenuItem.Text = "Yeni Kitap Ekle";
            this.yeniKitapEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniKitapEkleToolStripMenuItem_Click);
            // 
            // kitaplarıGörüntüleToolStripMenuItem
            // 
            this.kitaplarıGörüntüleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kitaplarıGörüntüleToolStripMenuItem.Image")));
            this.kitaplarıGörüntüleToolStripMenuItem.Name = "kitaplarıGörüntüleToolStripMenuItem";
            this.kitaplarıGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kitaplarıGörüntüleToolStripMenuItem.Text = "Kitapları Görüntüle";
            this.kitaplarıGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.kitaplarıGörüntüleToolStripMenuItem_Click);
            // 
            // ogrenciToolStripMenuItem
            // 
            this.ogrenciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ogrenciToolStripMenuItem1,
            this.ogrencileriGoruntuleToolStripMenuItem});
            this.ogrenciToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ogrenciToolStripMenuItem.Image")));
            this.ogrenciToolStripMenuItem.Name = "ogrenciToolStripMenuItem";
            this.ogrenciToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.ogrenciToolStripMenuItem.Text = "Ogrenci";
            // 
            // ogrenciToolStripMenuItem1
            // 
            this.ogrenciToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ogrenciToolStripMenuItem1.Image")));
            this.ogrenciToolStripMenuItem1.Name = "ogrenciToolStripMenuItem1";
            this.ogrenciToolStripMenuItem1.Size = new System.Drawing.Size(239, 26);
            this.ogrenciToolStripMenuItem1.Text = "Ogrenci Ekle";
            this.ogrenciToolStripMenuItem1.Click += new System.EventHandler(this.ogrenciToolStripMenuItem1_Click);
            // 
            // ogrencileriGoruntuleToolStripMenuItem
            // 
            this.ogrencileriGoruntuleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ogrencileriGoruntuleToolStripMenuItem.Image")));
            this.ogrencileriGoruntuleToolStripMenuItem.Name = "ogrencileriGoruntuleToolStripMenuItem";
            this.ogrencileriGoruntuleToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.ogrencileriGoruntuleToolStripMenuItem.Text = "Ogrencileri Goruntule";
            this.ogrencileriGoruntuleToolStripMenuItem.Click += new System.EventHandler(this.ogrencileriGoruntuleToolStripMenuItem_Click);
            // 
            // sayıKitaplarıToolStripMenuItem
            // 
            this.sayıKitaplarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oduncAlToolStripMenuItem});
            this.sayıKitaplarıToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sayıKitaplarıToolStripMenuItem.Image")));
            this.sayıKitaplarıToolStripMenuItem.Name = "sayıKitaplarıToolStripMenuItem";
            this.sayıKitaplarıToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.sayıKitaplarıToolStripMenuItem.Text = "Kitap Ödünç Al";
            this.sayıKitaplarıToolStripMenuItem.Click += new System.EventHandler(this.sayıKitaplarıToolStripMenuItem_Click);
            // 
            // kitaplarıİadeEtToolStripMenuItem
            // 
            this.kitaplarıİadeEtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iadeEtToolStripMenuItem});
            this.kitaplarıİadeEtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kitaplarıİadeEtToolStripMenuItem.Image")));
            this.kitaplarıİadeEtToolStripMenuItem.Name = "kitaplarıİadeEtToolStripMenuItem";
            this.kitaplarıİadeEtToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.kitaplarıİadeEtToolStripMenuItem.Text = "Kitapları İade Et";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // oduncAlToolStripMenuItem
            // 
            this.oduncAlToolStripMenuItem.Name = "oduncAlToolStripMenuItem";
            this.oduncAlToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.oduncAlToolStripMenuItem.Text = "Odunc Al";
            this.oduncAlToolStripMenuItem.Click += new System.EventHandler(this.oduncAlToolStripMenuItem_Click);
            // 
            // iadeEtToolStripMenuItem
            // 
            this.iadeEtToolStripMenuItem.Name = "iadeEtToolStripMenuItem";
            this.iadeEtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.iadeEtToolStripMenuItem.Text = "İade Et";
            this.iadeEtToolStripMenuItem.Click += new System.EventHandler(this.iadeEtToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 514);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kitapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniKitapEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitaplarıGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ogrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ogrenciToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sayıKitaplarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitaplarıİadeEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ogrencileriGoruntuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oduncAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iadeEtToolStripMenuItem;
    }
}

