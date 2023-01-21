using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Barbershop
{
    public partial class FrmHome : Form
    {

        SqlConnection conn;
        string constr, query;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet dDataPesanan;
        DataRow dr;
        public FrmHome()
        {
            InitializeComponent();
        }
        Produk_Pangkas.frmTambahProduk TambahProduk;
        public FrmHome(Produk_Pangkas.frmTambahProduk TambahProduk)
        {
            InitializeComponent();
            this.TambahProduk = TambahProduk;

        }
        Form1 frmLogin;
        public FrmHome(Form1 frmLogin)
        {
            InitializeComponent();
            this.frmLogin = frmLogin;
        }

        Pelanggan.FrmTambahPelanggan tPelanggan;
        public FrmHome(Pelanggan.FrmTambahPelanggan tPelanggan)
        {
            InitializeComponent();
            this.tPelanggan = tPelanggan;
        }
        Produk___Layanan_Pangkas.frmTambahLayanan tambahlayanan;
        public FrmHome(Produk___Layanan_Pangkas.frmTambahLayanan tambahlayanan)
        {
            InitializeComponent();
            this.tambahlayanan = tambahlayanan;
        }
        private void loaddataPesanan()
        {
            dDataPesanan = new DataSet();
            query = "Select p.IdTransaksi, p.Nama, dp.NamaPesanan, dp.HargaPesanan, dp.Qty, p.TotalHarga, p.StatusPenjualan from DataPesanan dp inner join Penjualan p on dp.IdPesanan = p.IdPesanan  where p.StatusPenjualan = 'Clear'";
            cmd = new SqlCommand(query, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(dDataPesanan, "DataPesanan");
        }
        private void loadProduk()
        {
            dDataPesanan = new DataSet();
            query = "Select * from Produk";
            cmd = new SqlCommand(query, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(dDataPesanan, "Produk");
        }
        private void koneksi()
        {
            constr = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = Barbershop; Integrated Security = true";
            conn = new SqlConnection(constr);
            conn.Open();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
   
        private void laporanPenjuakanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.csDataPesanan cr = new Report.csDataPesanan();
            Report.frmViewer viewer = new Report.frmViewer();
            loaddataPesanan();
            cr.SetDataSource(dDataPesanan);
            viewer.crystalReportViewer2.ReportSource = cr;

            viewer.WindowState = FormWindowState.Maximized;
            viewer.Show(); 

        }

        private void produkToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void grpTransaksiBaru_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
        DateTime waktu;
        private void Form2_Load(object sender, EventArgs e)
        {
            koneksi();
            waktu = DateTime.Now;
            lblwaktu.Text = waktu.ToString("dd.MM.yyyy - hh:mm:ss tt");
            loaddataPesanan();
            //--
        }

        private void berandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Beranda.frmPenjualan beranda = new Beranda.frmPenjualan(this);
            beranda.Show();
            beranda.lblUserID.Text = lblUserID.Text;
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Apakah anda ingin keluar dari Aplikasi ? ","Application Service",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void waktuTimer_Tick(object sender, EventArgs e)
        {
            waktu = DateTime.Now;
            lblwaktu.Text = waktu.ToString("dd.MM.yyyy - hh:mm:ss tt");
        }

        private void daftarPelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pelanggan.frmAturPelanggan AturPelanggan = new Pelanggan.frmAturPelanggan();
            AturPelanggan.Show();
            AturPelanggan.lbluser.Text = lblUserID.Text;
        }

        private void tambahPelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pelanggan.FrmTambahPelanggan Pelanggan = new Pelanggan.FrmTambahPelanggan();
            Pelanggan.Show();
            Pelanggan.lblUserID.Text = lblUserID.Text;
        }
        //----
        int mov;
        int movX;
        int movY;
        //----
        int mov1;
        int movX1;
        int movY1;
        //--0--
        private void lblAtas_Click(object sender, EventArgs e)
        {

        }

        private void lblAtas_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void lblAtas_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void lblAtas_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
            mov = 0;
        }

        private void LaporanTsm_Click(object sender, EventArgs e)
        {

        }

        private void listPelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pelanggan.frmListPelanggan listPelanggan = new Pelanggan.frmListPelanggan();
            listPelanggan.ShowDialog();
        }

        private void tambahProdukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produk___Layanan_Pangkas.frmTambahLayanan tambahProduk = new Produk___Layanan_Pangkas.frmTambahLayanan();
            tambahProduk.Show();
            tambahProduk.lblUserID.Text = lblUserID.Text;

        }

        private void aturProdukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produk___Layanan_Pangkas.frmAturLayanan editproduk = new Produk___Layanan_Pangkas.frmAturLayanan();
            editproduk.Show();
        }

        private void listProdukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produk___Layanan_Pangkas.frmListLayanan daftarlayanan = new Produk___Layanan_Pangkas.frmListLayanan();
            daftarlayanan.Show();
        }

        private void tambahProdukToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Produk_Pangkas.frmTambahProduk tambahProduk = new Produk_Pangkas.frmTambahProduk();
            tambahProduk.Show();
            tambahProduk.lbluser.Text = lblUserID.Text;

        }

        private void aturProdukToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Produk_Pangkas.frmAturProduk aturProduk = new Produk_Pangkas.frmAturProduk();
            aturProduk.Show();
            aturProduk.lbluser.Text = lblUserID.Text;
        }

        private void listProdukToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Produk_Pangkas.frmListProduk listProduk = new Produk_Pangkas.frmListProduk();
            listProduk.Show();
        }

        private void laporanPenjualanHarianToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void laporanPembelianPordukRambutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.csPembelianProduk cr = new Report.csPembelianProduk();
            Report.frmViewer viewer = new Report.frmViewer();
            loadProduk();
            cr.SetDataSource(dDataPesanan);
            viewer.crystalReportViewer2.ReportSource = cr;

            viewer.WindowState = FormWindowState.Maximized;
            viewer.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.frmUser login = new User.frmUser();
            login.Show();
        }

        private void DiskonTsm_Click(object sender, EventArgs e)
        {
            Diskon.FrmDiskon diskon = new Diskon.FrmDiskon();
            diskon.ShowDialog();
        }
    }
}
