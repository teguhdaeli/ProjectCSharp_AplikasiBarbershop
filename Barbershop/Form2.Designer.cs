
namespace Barbershop
{
    partial class FrmHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.lblexit = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stpMenu = new System.Windows.Forms.MenuStrip();
            this.lblAtas = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblBottom = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblwaktu = new System.Windows.Forms.Label();
            this.waktuTimer = new System.Windows.Forms.Timer(this.components);
            this.BerandaTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.PelangganTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahPelangganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daftarPelangganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listPelangganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProdukTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.layananPangkasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahProdukToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aturProdukToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listProdukToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produkPangkasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahProdukToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aturProdukToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listProdukToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LaporanTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanPenjuakanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanPembelianPordukRambutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DiskonTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblexit
            // 
            this.lblexit.BackColor = System.Drawing.Color.OrangeRed;
            this.lblexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblexit.Location = new System.Drawing.Point(1280, 3);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(37, 31);
            this.lblexit.TabIndex = 15;
            this.lblexit.Text = "X";
            this.lblexit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // stpMenu
            // 
            this.stpMenu.BackColor = System.Drawing.Color.Khaki;
            this.stpMenu.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stpMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BerandaTsm,
            this.PelangganTsm,
            this.ProdukTsm,
            this.LaporanTsm,
            this.DiskonTsm,
            this.userToolStripMenuItem});
            this.stpMenu.Location = new System.Drawing.Point(0, 36);
            this.stpMenu.Name = "stpMenu";
            this.stpMenu.Padding = new System.Windows.Forms.Padding(20, 2, 0, 2);
            this.stpMenu.Size = new System.Drawing.Size(1319, 31);
            this.stpMenu.TabIndex = 23;
            this.stpMenu.Text = "menuStrip1";
            // 
            // lblAtas
            // 
            this.lblAtas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAtas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAtas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAtas.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtas.ForeColor = System.Drawing.Color.White;
            this.lblAtas.Location = new System.Drawing.Point(0, 0);
            this.lblAtas.Name = "lblAtas";
            this.lblAtas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblAtas.Size = new System.Drawing.Size(1319, 36);
            this.lblAtas.TabIndex = 14;
            this.lblAtas.Text = "Barbershop Sistem";
            this.lblAtas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAtas.Click += new System.EventHandler(this.lblAtas_Click);
            this.lblAtas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblAtas_MouseDown);
            this.lblAtas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblAtas_MouseMove);
            this.lblAtas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblAtas_MouseUp);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "search.png");
            // 
            // lblBottom
            // 
            this.lblBottom.BackColor = System.Drawing.Color.DimGray;
            this.lblBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblBottom.Location = new System.Drawing.Point(0, 675);
            this.lblBottom.Name = "lblBottom";
            this.lblBottom.Size = new System.Drawing.Size(1319, 35);
            this.lblBottom.TabIndex = 24;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.DimGray;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblUser.Location = new System.Drawing.Point(6, 681);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(56, 21);
            this.lblUser.TabIndex = 25;
            this.lblUser.Text = "User : ";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.BackColor = System.Drawing.Color.DimGray;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.Snow;
            this.lblUserID.Location = new System.Drawing.Point(55, 681);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(16, 21);
            this.lblUserID.TabIndex = 26;
            this.lblUserID.Text = "-";
            // 
            // lblwaktu
            // 
            this.lblwaktu.BackColor = System.Drawing.Color.DimGray;
            this.lblwaktu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwaktu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblwaktu.Location = new System.Drawing.Point(1112, 676);
            this.lblwaktu.Name = "lblwaktu";
            this.lblwaktu.Size = new System.Drawing.Size(207, 33);
            this.lblwaktu.TabIndex = 27;
            this.lblwaktu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // waktuTimer
            // 
            this.waktuTimer.Enabled = true;
            this.waktuTimer.Interval = 1000;
            this.waktuTimer.Tick += new System.EventHandler(this.waktuTimer_Tick);
            // 
            // BerandaTsm
            // 
            this.BerandaTsm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BerandaTsm.Image = global::Barbershop.Properties.Resources.iconfinder_icons_home_1564508;
            this.BerandaTsm.Name = "BerandaTsm";
            this.BerandaTsm.Size = new System.Drawing.Size(112, 27);
            this.BerandaTsm.Text = "Penjualan";
            this.BerandaTsm.Click += new System.EventHandler(this.berandaToolStripMenuItem_Click);
            // 
            // PelangganTsm
            // 
            this.PelangganTsm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahPelangganToolStripMenuItem,
            this.daftarPelangganToolStripMenuItem,
            this.listPelangganToolStripMenuItem});
            this.PelangganTsm.Image = global::Barbershop.Properties.Resources.iconfinder_service_mind_support_customer_satisfaction_3802004;
            this.PelangganTsm.Name = "PelangganTsm";
            this.PelangganTsm.Size = new System.Drawing.Size(118, 27);
            this.PelangganTsm.Text = "Pelanggan";
            // 
            // tambahPelangganToolStripMenuItem
            // 
            this.tambahPelangganToolStripMenuItem.Name = "tambahPelangganToolStripMenuItem";
            this.tambahPelangganToolStripMenuItem.Size = new System.Drawing.Size(225, 28);
            this.tambahPelangganToolStripMenuItem.Text = "Tambah Pelanggan";
            this.tambahPelangganToolStripMenuItem.Click += new System.EventHandler(this.tambahPelangganToolStripMenuItem_Click);
            // 
            // daftarPelangganToolStripMenuItem
            // 
            this.daftarPelangganToolStripMenuItem.Name = "daftarPelangganToolStripMenuItem";
            this.daftarPelangganToolStripMenuItem.Size = new System.Drawing.Size(225, 28);
            this.daftarPelangganToolStripMenuItem.Text = "Atur Pelanggan";
            this.daftarPelangganToolStripMenuItem.Click += new System.EventHandler(this.daftarPelangganToolStripMenuItem_Click);
            // 
            // listPelangganToolStripMenuItem
            // 
            this.listPelangganToolStripMenuItem.Name = "listPelangganToolStripMenuItem";
            this.listPelangganToolStripMenuItem.Size = new System.Drawing.Size(225, 28);
            this.listPelangganToolStripMenuItem.Text = "List Pelanggan";
            this.listPelangganToolStripMenuItem.Click += new System.EventHandler(this.listPelangganToolStripMenuItem_Click);
            // 
            // ProdukTsm
            // 
            this.ProdukTsm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layananPangkasToolStripMenuItem,
            this.produkPangkasToolStripMenuItem});
            this.ProdukTsm.Image = global::Barbershop.Properties.Resources.box__1_;
            this.ProdukTsm.Name = "ProdukTsm";
            this.ProdukTsm.Size = new System.Drawing.Size(92, 27);
            this.ProdukTsm.Text = "Produk";
            this.ProdukTsm.Click += new System.EventHandler(this.produkToolStripMenuItem_Click);
            // 
            // layananPangkasToolStripMenuItem
            // 
            this.layananPangkasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahProdukToolStripMenuItem,
            this.aturProdukToolStripMenuItem,
            this.listProdukToolStripMenuItem});
            this.layananPangkasToolStripMenuItem.Name = "layananPangkasToolStripMenuItem";
            this.layananPangkasToolStripMenuItem.Size = new System.Drawing.Size(210, 28);
            this.layananPangkasToolStripMenuItem.Text = "Layanan Pangkas";
            // 
            // tambahProdukToolStripMenuItem
            // 
            this.tambahProdukToolStripMenuItem.Name = "tambahProdukToolStripMenuItem";
            this.tambahProdukToolStripMenuItem.Size = new System.Drawing.Size(208, 28);
            this.tambahProdukToolStripMenuItem.Text = "Tambah Layanan";
            this.tambahProdukToolStripMenuItem.Click += new System.EventHandler(this.tambahProdukToolStripMenuItem_Click);
            // 
            // aturProdukToolStripMenuItem
            // 
            this.aturProdukToolStripMenuItem.Name = "aturProdukToolStripMenuItem";
            this.aturProdukToolStripMenuItem.Size = new System.Drawing.Size(208, 28);
            this.aturProdukToolStripMenuItem.Text = "Atur Layanan";
            this.aturProdukToolStripMenuItem.Click += new System.EventHandler(this.aturProdukToolStripMenuItem_Click);
            // 
            // listProdukToolStripMenuItem
            // 
            this.listProdukToolStripMenuItem.Name = "listProdukToolStripMenuItem";
            this.listProdukToolStripMenuItem.Size = new System.Drawing.Size(208, 28);
            this.listProdukToolStripMenuItem.Text = "List Layanan";
            this.listProdukToolStripMenuItem.Click += new System.EventHandler(this.listProdukToolStripMenuItem_Click);
            // 
            // produkPangkasToolStripMenuItem
            // 
            this.produkPangkasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahProdukToolStripMenuItem1,
            this.aturProdukToolStripMenuItem1,
            this.listProdukToolStripMenuItem1});
            this.produkPangkasToolStripMenuItem.Name = "produkPangkasToolStripMenuItem";
            this.produkPangkasToolStripMenuItem.Size = new System.Drawing.Size(210, 28);
            this.produkPangkasToolStripMenuItem.Text = "Produk Pangkas";
            // 
            // tambahProdukToolStripMenuItem1
            // 
            this.tambahProdukToolStripMenuItem1.Name = "tambahProdukToolStripMenuItem1";
            this.tambahProdukToolStripMenuItem1.Size = new System.Drawing.Size(199, 28);
            this.tambahProdukToolStripMenuItem1.Text = "Tambah Produk";
            this.tambahProdukToolStripMenuItem1.Click += new System.EventHandler(this.tambahProdukToolStripMenuItem1_Click);
            // 
            // aturProdukToolStripMenuItem1
            // 
            this.aturProdukToolStripMenuItem1.Name = "aturProdukToolStripMenuItem1";
            this.aturProdukToolStripMenuItem1.Size = new System.Drawing.Size(199, 28);
            this.aturProdukToolStripMenuItem1.Text = "Atur Produk";
            this.aturProdukToolStripMenuItem1.Click += new System.EventHandler(this.aturProdukToolStripMenuItem1_Click);
            // 
            // listProdukToolStripMenuItem1
            // 
            this.listProdukToolStripMenuItem1.Name = "listProdukToolStripMenuItem1";
            this.listProdukToolStripMenuItem1.Size = new System.Drawing.Size(199, 28);
            this.listProdukToolStripMenuItem1.Text = "List Produk";
            this.listProdukToolStripMenuItem1.Click += new System.EventHandler(this.listProdukToolStripMenuItem1_Click);
            // 
            // LaporanTsm
            // 
            this.LaporanTsm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laporanPenjuakanToolStripMenuItem,
            this.laporanPembelianPordukRambutToolStripMenuItem});
            this.LaporanTsm.Image = global::Barbershop.Properties.Resources.business_report;
            this.LaporanTsm.Name = "LaporanTsm";
            this.LaporanTsm.Size = new System.Drawing.Size(100, 27);
            this.LaporanTsm.Text = "Laporan";
            this.LaporanTsm.Click += new System.EventHandler(this.LaporanTsm_Click);
            // 
            // laporanPenjuakanToolStripMenuItem
            // 
            this.laporanPenjuakanToolStripMenuItem.Name = "laporanPenjuakanToolStripMenuItem";
            this.laporanPenjuakanToolStripMenuItem.Size = new System.Drawing.Size(266, 28);
            this.laporanPenjuakanToolStripMenuItem.Text = "Laporan Penjualan";
            this.laporanPenjuakanToolStripMenuItem.Click += new System.EventHandler(this.laporanPenjuakanToolStripMenuItem_Click);
            // 
            // laporanPembelianPordukRambutToolStripMenuItem
            // 
            this.laporanPembelianPordukRambutToolStripMenuItem.Name = "laporanPembelianPordukRambutToolStripMenuItem";
            this.laporanPembelianPordukRambutToolStripMenuItem.Size = new System.Drawing.Size(266, 28);
            this.laporanPembelianPordukRambutToolStripMenuItem.Text = "Laporan Produk Rambut";
            this.laporanPembelianPordukRambutToolStripMenuItem.Click += new System.EventHandler(this.laporanPembelianPordukRambutToolStripMenuItem_Click);
            // 
            // DiskonTsm
            // 
            this.DiskonTsm.Image = global::Barbershop.Properties.Resources.discount;
            this.DiskonTsm.Name = "DiskonTsm";
            this.DiskonTsm.Size = new System.Drawing.Size(89, 27);
            this.DiskonTsm.Text = "Diskon";
            this.DiskonTsm.Click += new System.EventHandler(this.DiskonTsm_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Image = global::Barbershop.Properties.Resources.usermaleadd_1010511;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(72, 27);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1319, 710);
            this.Controls.Add(this.lblwaktu);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblBottom);
            this.Controls.Add(this.stpMenu);
            this.Controls.Add(this.lblexit);
            this.Controls.Add(this.lblAtas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.stpMenu.ResumeLayout(false);
            this.stpMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblexit;
        private System.Windows.Forms.Label lblAtas;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip stpMenu;
        private System.Windows.Forms.ToolStripMenuItem BerandaTsm;
        private System.Windows.Forms.ToolStripMenuItem PelangganTsm;
        private System.Windows.Forms.ToolStripMenuItem ProdukTsm;
        private System.Windows.Forms.ToolStripMenuItem LaporanTsm;
        private System.Windows.Forms.ToolStripMenuItem laporanPenjuakanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahPelangganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layananPangkasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produkPangkasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanPembelianPordukRambutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DiskonTsm;
        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblBottom;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblwaktu;
        private System.Windows.Forms.Timer waktuTimer;
        private System.Windows.Forms.ToolStripMenuItem daftarPelangganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listPelangganToolStripMenuItem;
        public System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.ToolStripMenuItem tambahProdukToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aturProdukToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listProdukToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahProdukToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aturProdukToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listProdukToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
    }
}