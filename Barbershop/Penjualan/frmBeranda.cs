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

namespace Barbershop.Beranda
{
    public partial class frmPenjualan : Form
    {
        public frmPenjualan()
        {
            InitializeComponent();
        }
        frmStruk struk;
        public frmPenjualan(frmStruk struk)
        {
            InitializeComponent();
            this.struk = struk;
        }

        FrmHome Home;
       public frmPenjualan(FrmHome Home)
        {
            InitializeComponent();
            this.Home = Home;
        }

        SqlConnection conn;
        string constr, query;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        DataRow dr;
        DataColumn[] dc_1pk = new DataColumn[1];
        DataColumn[] dc_2pk = new DataColumn[2];
        DataColumn[] dc_3pk = new DataColumn[3];
        SqlCommandBuilder cb;
        string[] cari = new string[3];
        string[] caripesanan = new string[2];
        string[] caripembayaran = new string[2];


        //-----------------------------------
        private void loaddata_Penjualan()
        {
            ds = new DataSet();
            query = "Select * from Penjualan where StatusPenjualan = 'Not Clear'";
            cmd = new SqlCommand(query, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Penjualan");
            dc_3pk[0] = ds.Tables["Penjualan"].Columns[0];
            dc_3pk[1] = ds.Tables["Penjualan"].Columns[1];
            dc_3pk[2] = ds.Tables["Penjualan"].Columns[3];
            ds.Tables["Penjualan"].PrimaryKey = dc_3pk;
        }

        private void loaddata_DetailPesanan()
        {
            ds = new DataSet();
            query = "Select dp.IdPesanan,dp.IdDataPemesanan,dp.NamaPesanan,dp.Qty,dp.HargaPesanan,p.TotalHarga from DataPesanan dp inner join Penjualan p on dp.IdPesanan = p.IdPesanan where p.IdPesanan LIKE '%" + txtNoPesanan.Text + "%'";
            cmd = new SqlCommand(query, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "DataPesanan");
            dc_2pk[0] = ds.Tables["DataPesanan"].Columns[0];
            dc_2pk[1] = ds.Tables["DataPesanan"].Columns[1];
            ds.Tables["DataPesanan"].PrimaryKey = dc_2pk;
        }
        private void detailpesananTampilan()
        {
            dgvDataDetailPesanan.DataSource = ds.Tables["DataPesanan"];
            dgvDataDetailPesanan.Columns[0].HeaderText = "Kode Pesanan";
            dgvDataDetailPesanan.Columns[1].HeaderText = "Kode Data Pesanan";
            dgvDataDetailPesanan.Columns[2].HeaderText = "Nama Pesanan ";
            dgvDataDetailPesanan.Columns[3].HeaderText = "Qty";
            dgvDataDetailPesanan.Columns[4].HeaderText = "Harga Pesanan";
            dgvDataDetailPesanan.Columns[5].HeaderText = "Total";
            dgvDataDetailPesanan.ReadOnly = true;
            dgvDataDetailPesanan.AllowUserToAddRows = false;
        }

        private void loaddata_DataPesananPelanggan()
        {
            ds = new DataSet();
            query = "Select * from DataPesanan";
            cmd = new SqlCommand(query, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "DataPesanan");
            dc_2pk[0] = ds.Tables["DataPesanan"].Columns[0];
            dc_2pk[1] = ds.Tables["DataPesanan"].Columns[1];
            ds.Tables["DataPesanan"].PrimaryKey = dc_2pk;
        }
        private void loaddata_HapusDataPesanan()
        {
            ds = new DataSet();
            query = "delete from DataPesanan where IdPesanan Like '"+ txtNoPesanan.Text + "'";
            cmd = new SqlCommand(query, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "DataPesanan");
            dc_2pk[0] = ds.Tables["DataPesanan"].Columns[0];
            dc_2pk[1] = ds.Tables["DataPesanan"].Columns[1];
            ds.Tables["DataPesanan"].PrimaryKey = dc_2pk;
        }
        private void loaddata_DetailPenjualan()
        {
            ds = new DataSet();
            query = "Select * from DetailPenjualan";
            cmd = new SqlCommand(query, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "DetailPenjualan");
            dc_2pk[0] = ds.Tables["DetailPenjualan"].Columns[0];
            dc_2pk[1] = ds.Tables["DetailPenjualan"].Columns[1];
            ds.Tables["DetailPenjualan"].PrimaryKey = dc_2pk;
        }

        private void updatedata_Penjualan()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Penjualan"]);
        }
        private void updatedata_DataPesanan()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["DataPesanan"]);
        }
        private void updatedata_DetailPenjualan()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["DetailPenjualan"]);
        }
        private void loaddata_Produk()
        {
            ds = new DataSet();
            query = "Select * from Produk";
            cmd = new SqlCommand(query, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Produk");
            dc_1pk[0] = ds.Tables["Produk"].Columns[0];
            ds.Tables["Produk"].PrimaryKey = dc_1pk;
        }
        private void updatedata_TambahProduk()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Produk"]);
        }


        private void tampilDataPenjualan()
        {
            dgvdatapesanan.DataSource = ds.Tables["Penjualan"];
            dgvdatapesanan.Columns[0].HeaderText = "Kode Produk";
            dgvdatapesanan.Columns[1].HeaderText = "Kode User";
            dgvdatapesanan.Columns[2].HeaderText = "Nama Produk ";
            dgvdatapesanan.Columns[3].HeaderText = "Stock";
            dgvdatapesanan.Columns[4].HeaderText = "Tanggal Terbit";
            dgvdatapesanan.ReadOnly = true;
            dgvdatapesanan.AllowUserToAddRows = false;
        }

        //--Pembayaran------------------//
        private void loaddata_Pembayaran()
        {
            ds = new DataSet();
            query = "Select * from Pembayaran";
            cmd = new SqlCommand(query, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Pembayaran");
            dc_2pk[0] = ds.Tables["Pembayaran"].Columns[0];
            dc_2pk[1] = ds.Tables["Pembayaran"].Columns[1];
            ds.Tables["Pembayaran"].PrimaryKey = dc_2pk;
        }
        private void update_Pembayaran()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Pembayaran"]);
        }
        //-------====================----------------//

        private void koneksi()
        {
            constr = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = Barbershop; Integrated Security = true";
            conn = new SqlConnection(constr);
            conn.Open();
        }



        Produk_Pangkas.frmListProduk ListProduk;
        public frmPenjualan(Produk_Pangkas.frmListProduk ListProduk)
        {
            InitializeComponent();
            this.ListProduk = ListProduk;
        }
        Pelanggan.frmListPelanggan pelanggan;
        public frmPenjualan(Pelanggan.frmListPelanggan pelanggan)
        {
            InitializeComponent();
            this.pelanggan = pelanggan;
        }

        Produk___Layanan_Pangkas.frmListLayanan listlayanan;
        public frmPenjualan(Produk___Layanan_Pangkas.frmListLayanan listlayanan)
        {
            InitializeComponent();
            this.listlayanan = listlayanan;
        }
        private void loaddata_diskon()
        {
            ds = new DataSet();
            query = "Select * from Diskon";
            cmd = new SqlCommand(query, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Diskon");
            dc_1pk[0] = ds.Tables["Diskon"].Columns[0];
            ds.Tables["Diskon"].PrimaryKey = dc_1pk;
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Apakah anda ingin keluar dari Beranda ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                    this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnBrowsePelanggan.FlatStyle = FlatStyle.Flat;
            Pelanggan.frmListPelanggan pelanggan = new Pelanggan.frmListPelanggan(this);
            pelanggan.Show();

        }
        private void Hover()
        {
        }
        private void kodepembayaran()
        {
            Random angka = new Random();
            byte[] angkabyte = new byte[2];

            string a;
            for (int i = 1; i < 4530; i++)
            {
                a = "PA" +( angka.Next() * 2);
                lblNoPembayaran.Text = a.Substring(0, 8);
            }
        }
        private void FrmBeranda_Load(object sender, EventArgs e)
        {
            koneksi();
            loaddata_DataPesananPelanggan();
            loaddata_Penjualan();
            tampilpesanan();
            //--------------------
            TampilDataPesanan();
            btntambah.Enabled = false;
            chkUbahPesanan.Checked = false;

            //--
            btnUbah.Enabled = false;
            btnHapus.Enabled = false;
            //--
            KodeTransaksi();
            kodepesanan();
            kodepembayaran();
            btntambah.Enabled = false;
            //-----------------
            cmbMetodeBayar.Items.Add("Tunai");
            cmbMetodeBayar.Items.Add("Gopay");
            cmbMetodeBayar.Items.Add("Ovo");
            cmbMetodeBayar.Items.Add("Kartu Kredit");
            //-


            txtmetodebayar.Enabled = false;
            chkDiskon.Checked = true;
            btnBayar.Enabled = false;
            BtnCetakStruk.Enabled = false;
            btnBersih.Enabled = false;
        }

        private void KodeTransaksi()
        {
            Random angka = new Random();
            byte[] angkabyte = new byte[2];

            string a;
            for (int i = 100; i <= 2762; i++)
            {
                a = "T" + angka.Next();
                lblNoTransaksi.Text = a.Substring(0, 6);
            }
        }

        private void kodepesanan()
        {
            Random angka = new Random();
            byte[] angkabyte = new byte[2];

            string a;
            for (int i = 2; i <= 1000; i++)
            {
                a = "KP" + angka.Next();
                lblKodePesanan.Text = a.Substring(0, 7);
            }
        }

        int jlh, idx;
        private void cek_data()
        {
            jlh = 0;
            for (int i = 0; i < dgvdatapesanan.Rows.Count; i++)
            {
                if (lblKode.Text == dgvdatapesanan.Rows[i].Cells[0].Value.ToString())
                {
                    jlh += 1;
                    idx = i;
                }
            }
        }


        private void TampilDataPesanan()
        {
            dgvdatapesanan.ColumnCount = 6;
            dgvdatapesanan.Columns[0].HeaderText = "Kode Data Pemesanan";
            dgvdatapesanan.Columns[1].HeaderText = "Nama Pemesanan";
            dgvdatapesanan.Columns[2].HeaderText = "Qty";
            dgvdatapesanan.Columns[3].HeaderText = "Jenis Satuan";
            dgvdatapesanan.Columns[4].HeaderText = "Harga ";
            dgvdatapesanan.Columns[5].HeaderText = "Total Harga";
            dgvdatapesanan.ReadOnly = true;
            dgvdatapesanan.MultiSelect = false;
            dgvdatapesanan.AllowUserToAddRows = false;
            dgvdatapesanan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            btnBrowsePelanggan.BackColor = Color.LightPink;
        }

        private void btnBrowseLayananBarber_MouseHover(object sender, EventArgs e)
        {
            btnBrowseLayananBarber.BackColor = Color.LightPink;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            btnBrowseProduk.BackColor = Color.LightPink;
        }
        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            btnBrowsePelanggan.BackColor = Color.Khaki;
        }

        private void btnBrowseProduk_Click(object sender, EventArgs e)
        {
            Produk_Pangkas.frmListProduk listProduk = new Produk_Pangkas.frmListProduk(this);
            listProduk.Show();
            lblJenisJumlah.Text = "Unit";

            //---
            btnBrowseLayananBarber.Enabled = false;
            lblKodeLayanan.Text = "";
        }

        private void btnBrowsePelanggan_MouseClick(object sender, MouseEventArgs e)
        {
            btnBrowsePelanggan.ForeColor = Color.LightYellow;
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void btnBrowsePelanggan_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void btnBrowseLayananBarber_MouseMove(object sender, MouseEventArgs e)
        {

            btnBrowseLayananBarber.BackColor = Color.Beige;
        }

        private void btnBrowseProduk_MouseMove(object sender, MouseEventArgs e)
        {

            btnBrowseProduk.BackColor = Color.Bisque;
        }

        private void btnBrowseLayananBarber_Click(object sender, EventArgs e)
        {
            Produk___Layanan_Pangkas.frmListLayanan listLayanan = new Produk___Layanan_Pangkas.frmListLayanan(this);
            listLayanan.Show();

            lblJenisJumlah.Text = "Orang";
            //--
            btnBrowseProduk.Enabled = false;
            lblKodeProduk.Text = "";
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show("Apakah anda ingin Input data pesanan ini ? ", "Input Pesanan", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (!String.IsNullOrWhiteSpace(lblKode.Text) && nudJumlah.Value != 0)
                    {
                        cek_data();
                        if (jlh == 0)
                        {
                            dgvdatapesanan.Rows.Add(lblKode.Text, lblNamaPesanan.Text, nudJumlah.Value, lblJenisJumlah.Text, lblHarga.Text, lblTotal.Text);
                            loaddata_Produk();
                            dr = ds.Tables["Produk"].Rows.Find(lblKode.Text);
                            if (dr != null)
                            {
                                dr[3] = decimal.Parse(dr[3].ToString()) - nudJumlah.Value;
                                updatedata_TambahProduk();
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Pesanan " + lblKode.Text + " sudah ada, Mohon Untuk Menginput Pesanan Yang Berbeda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.No)
                            {
                                decimal qty, nilai;
                                qty = decimal.Parse(dgvdatapesanan.Rows[idx].Cells[2].Value.ToString());
                                nilai = qty + nudJumlah.Value;
                                dgvdatapesanan.Rows[idx].Cells[2].Value = nilai;

                                qty = decimal.Parse(dgvdatapesanan.Rows[idx].Cells[5].Value.ToString());
                                nilai = qty + decimal.Parse(lblTotalHarga.Text);
                                dgvdatapesanan.Rows[idx].Cells[5].Value = nilai;

                                qty = decimal.Parse(dgvdatapesanan.Rows[idx].Cells[2].Value.ToString());
                                nilai = qty + decimal.Parse(nudJumlah.Value.ToString());
                                dgvdatapesanan.Rows[idx].Cells[2].Value = nilai;
                            }
                        }
                        hitung_jumlahqty();
                        Hapus();
                        hitung_total();
                        btnBrowseLayananBarber.Enabled = true;
                        btnBrowseProduk.Enabled = true;
                        lblKodeProduk.Text = "-";
                        lblKodeLayanan.Text = "-";
                        btntambah.Enabled = false;
                        lblJenisJumlah.Text = "-";
                    }
                    else
                    {
                        MessageBox.Show("Data harus diinput terlebih dahulu Semuanya !", "Gagal Tambah Pesanan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }
        private void hitung_jumlahqty()
        {
            double total = 0;
            for (int i = 0; i < dgvdatapesanan.Rows.Count; i++)
            {
                total += double.Parse(dgvdatapesanan.Rows[i].Cells[2].Value.ToString());
            }
            lbltotalQty.Text = total.ToString();

        }
        private void hitung_total()
        {
            double totall = 0;
            for (int i = 0; i < dgvdatapesanan.Rows.Count; i++)
            {
                totall += double.Parse(dgvdatapesanan.Rows[i].Cells[5].Value.ToString());
            }
            lblTotalHarga.Text = totall.ToString();
        }
            private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblKode_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(lblKode.Text) && !string.IsNullOrWhiteSpace(lblNamaPesanan.Text) && !string.IsNullOrWhiteSpace(lblHarga.Text) && !string.IsNullOrWhiteSpace(lblTotal.Text))
            {
                btntambah.Enabled = true;
                nudJumlah.Enabled = true;

            }
            else
            {
                btntambah.Enabled = false;
                nudJumlah.Enabled = false;

            }
        }

        private void lblHarga_Click(object sender, EventArgs e)
        {

        }

        private void chkUbahPesanan_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvdatapesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (chkUbahPesanan.Checked == true)
            {
                dgvdatapesanan.Enabled = true;
                datapesananKlik();
                //-

                btnUbah.Enabled = true;
                btnHapus.Enabled = true;
            }
            else if (chkUbahPesanan.Checked)
            {
                TampilDataPesanan();
                btnUbah.Enabled = false;
                btnHapus.Enabled = false;
            }
        }
        private void datapesananKlik()
        {
            int baris = dgvdatapesanan.CurrentCell.RowIndex;
            lblKode.Text = dgvdatapesanan.Rows[baris].Cells[0].Value.ToString();
            lblNamaPesanan.Text = dgvdatapesanan.Rows[baris].Cells[1].Value.ToString();
            nudJumlah.Value = decimal.Parse(dgvdatapesanan.Rows[baris].Cells[2].Value.ToString());
            lblHarga.Text = dgvdatapesanan.Rows[baris].Cells[4].Value.ToString();
            lblTotal.Text = dgvdatapesanan.Rows[baris].Cells[5].Value.ToString();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(lblKode.Text) && nudJumlah.Value != 0 )
            {
                cek_data();
                if (jlh != 0)
                {
                    if (MessageBox.Show("Apakah anda yakin ingin mengubah pesanan ini ?", "Konfirmasi Perubahan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        decimal nilai;
                        nilai = nudJumlah.Value;
                        dgvdatapesanan.Rows[idx].Cells[2].Value = nilai;

                        nilai = decimal.Parse(lblTotal.Text);
                        dgvdatapesanan.Rows[idx].Cells[5].Value = nilai;
                    }
                }
                hitung_jumlahqty();
                hitung_total();
                Hapus();
            }
            else
            {
                MessageBox.Show("Data harus diinput terlebih dahulu", "Ubah Pesanan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            chkUbahPesanan.Checked = false;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(lblKode.Text) && nudJumlah.Value != 0)
            {
                cek_data();
                if (jlh != 0)
                {
                    if (MessageBox.Show("Apakah anda yakin mau menghapus pesanan ini ?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dgvdatapesanan.Rows.RemoveAt(idx);
                        loaddata_Produk();
                        dr = ds.Tables["Produk"].Rows.Find(lblKode.Text);
                        if (dr != null)
                        {
                            dr[3] = decimal.Parse(dr[3].ToString()) + nudJumlah.Value;
                            updatedata_TambahProduk();
                        }
                    }
                }
                hitung_jumlahqty();
                Hapus();
                hitung_total();
                chkUbahPesanan.Checked = false;
            }
        }

        private void btnInputPenjualan_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Apakah data diatas sudah benar ?", "Input Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
             
                    loaddata_Penjualan();
                    cari[0] = lblNoTransaksi.Text;
                    cari[1] = txtNoPelanggan.Text;
                    cari[2] = lblKodePesanan.Text;
                    dr = ds.Tables["Penjualan"].Rows.Find(cari);
                    if (dr == null)
                    {
                        dr = ds.Tables["Penjualan"].NewRow();
                        dr[0] = lblNoTransaksi.Text;
                        dr[1] = txtNoPelanggan.Text;
                        dr[2] = txtNamaPelanggan.Text;
                        dr[3] = lblKodePesanan.Text;
                        dr[4] = lbltotalQty.Text;
                        dr[5] = lblTotalHarga.Text;
                        dr[6] = DateTime.Now.ToString("dd-MMM-yyyy");
                        dr[7] = "Not Clear";
                        ds.Tables["Penjualan"].Rows.Add(dr);
                        updatedata_Penjualan();
                        tampilpesanan();

                        //---DetailPenjualan
                        loaddata_DetailPenjualan();
                        caripesanan[0] = lblUserID.Text;
                        caripesanan[1] = lblNoTransaksi.Text;
                        dr = ds.Tables["DetailPenjualan"].Rows.Find(caripesanan);
                        if (dr == null)
                        {
                            dr = ds.Tables["DetailPenjualan"].NewRow();
                            dr[0] = lblUserID.Text;
                            dr[1] = lblNoTransaksi.Text;
                            dr[2] = lbltotalQty.Text;
                            dr[3] = DateTime.Now.ToString("dd-MMM-yyyy");
                            ds.Tables["DetailPenjualan"].Rows.Add(dr);
                            updatedata_DetailPenjualan();
                        }
                        MessageBox.Show("Data Transaksi Berhasil Ditambahkan, Silahkan lanjutkan ke Menu Pembayaran !", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                        //----
                    }
                for (int i = 0; i < dgvdatapesanan.Rows.Count; i++)
                {
                    //----
                    loaddata_DataPesananPelanggan();
                    caripesanan[0] = lblKodePesanan.Text;
                    caripesanan[1] = dgvdatapesanan.Rows[i].Cells[0].Value.ToString();
                    dr = ds.Tables["DataPesanan"].Rows.Find(caripesanan);
                    if (dr == null)
                    {
                        dr = ds.Tables["DataPesanan"].NewRow();
                        dr[0] = lblKodePesanan.Text;
                        dr[1] = dgvdatapesanan.Rows[i].Cells[0].Value.ToString();
                        dr[2] = dgvdatapesanan.Rows[i].Cells[1].Value.ToString();
                        dr[3] = dgvdatapesanan.Rows[i].Cells[4].Value.ToString();
                        dr[4] = dgvdatapesanan.Rows[i].Cells[2].Value.ToString();
                        dr[5] = dgvdatapesanan.Rows[i].Cells[3].Value.ToString();
                        dr[6] = DateTime.Now.ToString("dd-MMM-yyyy");
                        ds.Tables["DataPesanan"].Rows.Add(dr);
                        updatedata_DataPesanan();

                    }
                    btnInputPenjualan.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Error ! Karena ada kesamaan Kode Data , Silahkan Ulangi lagi . ", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Hapus();
            txtNamaPelanggan.Clear();
            txtNoPelanggan.Clear();
            lblTotalHarga.Text = "0";
            lbltotalQty.Text = "0";
            KodeTransaksi();
            kodepesanan();
            dgvdatapesanan.Rows.Clear();

            grpDataPesanan.Enabled = false;
            grpTransaksiBaru.Enabled = false;
            btnInputPenjualan.Enabled = false;

            tabMenu.SelectedTab = tpPembayaran;
            ///
            grpPembayaran.Enabled = true;
            grpDetailPembayaran.Enabled = true;
            grpDetailPesanan.Enabled = true;
            dgvTransaksi.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin Membatalkan Pesanan Ini", "Hapus Pesanan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                    loaddata_Penjualan();
                    cari[0] = lblNoTransaksi.Text;
                    cari[1] = txtNoPelanggan.Text;
                    cari[2] = lblKodePesanan.Text;
                    dr = ds.Tables["Penjualan"].Rows.Find(cari);
                    if (dr != null)
                    {
                        dr.Delete();
                        updatedata_Penjualan();
                        MessageBox.Show("Data Pesanan berhasil di Hapus.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tampilpesanan();
                        Hapus();


                        //---DetailPenjualan
                        loaddata_DetailPenjualan();
                        caripesanan[0] = lblUserID.Text;
                        caripesanan[1] = lblNoTransaksi.Text;
                        dr = ds.Tables["DetailPenjualan"].Rows.Find(caripesanan);
                        if (dr != null)
                        {
                            dr.Delete();
                            updatedata_DetailPenjualan();
                        }
                    }
                txtNoPelanggan.Clear();
                kodepesanan();
                KodeTransaksi();
          
            }
        }
        double pajak, totalpembayaran,totalpajak;
        private void dgvTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
            if (tabMenu.SelectedTab == tpTransaksi)
            {
                int baris = dgvTransaksi.CurrentCell.RowIndex;
                lblNoTransaksi.Text = dgvTransaksi.Rows[baris].Cells[0].Value.ToString();
                lblKodePesanan.Text = dgvTransaksi.Rows[baris].Cells[3].Value.ToString();
                txtNoPelanggan.Text = dgvTransaksi.Rows[baris].Cells[1].Value.ToString();
                btnInputPenjualan.Enabled = false;

            }
            else if(tabMenu.SelectedTab == tpPembayaran)
            {
                int baris = dgvTransaksi.CurrentCell.RowIndex;
                txtNoPesanan.Text = dgvTransaksi.Rows[baris].Cells[3].Value.ToString();
                txtNoTransaksi.Text = dgvTransaksi.Rows[baris].Cells[0].Value.ToString();
                lblNama.Text = dgvTransaksi.Rows[baris].Cells[2].Value.ToString();
                lblbanyakdata.Text = dgvTransaksi.Rows[baris].Cells[4].Value.ToString();
                lbltotalhargabayar.Text = dgvTransaksi.Rows[baris].Cells[5].Value.ToString();

                //----------------
                loaddata_DetailPesanan();
                detailpesananTampilan();
                //---
                totalpajak = 0.05 * double.Parse(lbltotalhargabayar.Text);
                pajak = totalpajak;
                lblPajak.Text = pajak.ToString();

                totalpembayaran = pajak + double.Parse(lbltotalhargabayar.Text);
                txtTotalPembayaran.Text = totalpembayaran.ToString();


            }

        }

        private void btnInputPenjualan_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotalHarga_TextChanged(object sender, EventArgs e)
        {
        }

        private void Hapus()
        {
            lblKode.Text = "-";
            lblNamaPesanan.Text = "";
            lblHarga.Text = "0";
            nudJumlah.Value = 0;
            lblTotal.Text = "0";
        }
        private void tampilpesanan()
        {
            dgvTransaksi.DataSource = ds.Tables["Penjualan"];
            dgvTransaksi.Columns[0].HeaderText = "Kode Transaksi";
            dgvTransaksi.Columns[1].HeaderText = "Kode Pelanggan";
            dgvTransaksi.Columns[2].HeaderText = "Nama Pelanggan ";
            dgvTransaksi.Columns[3].HeaderText = "Kode Pesanan";
            dgvTransaksi.Columns[4].HeaderText = "Jumlah Pesanan";
            dgvTransaksi.Columns[5].HeaderText = "Total Harga";
            dgvTransaksi.Columns[6].HeaderText = "Tanggal Transaksi";
            dgvTransaksi.Columns[7].HeaderText = "Status Penjualan";
            dgvTransaksi.ReadOnly = true;
            dgvdatapesanan.AllowUserToAddRows = false;
            //lblJumlah.Text = dgvdatapesanan.Rows.Count.ToString();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void lblNama_Click(object sender, EventArgs e)
        {

        }

        private void txtNoPelanggan_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbMetodeBayar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbMetodeBayar.SelectedItem.ToString() == "Tunai")
            {
                txtmetodebayar.Clear();
                lblMetode.Text = "Tunai";
                txtmetodebayar.Enabled = false;
            }
            else if(cmbMetodeBayar.SelectedItem.ToString() == "Gopay")
            {
                txtmetodebayar.Clear();
                lblMetode.Text = "Gopay";
                txtmetodebayar.Enabled = true;
                txtmetodebayar.MaxLength = 12;
            }
            else if (cmbMetodeBayar.SelectedItem.ToString() == "Ovo")
            {
                txtmetodebayar.Clear();
                lblMetode.Text = "Ovo";
                txtmetodebayar.Enabled = true;
                txtmetodebayar.MaxLength = 12;
            }
            else if (cmbMetodeBayar.SelectedItem.ToString() == "Kartu Kredit")
            {
                txtmetodebayar.Clear();
                lblMetode.Text = "Kartu Kredit";
                txtmetodebayar.Enabled = true;
                txtmetodebayar.MaxLength = 14;
            }
        }

        private void txtJumlahPembayaran_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
        public double TotalPembayaran,diskon=0;
        private void btnCari_Click(object sender, EventArgs e)
        {
            loaddata_diskon();
            dr = ds.Tables["Diskon"].Rows.Find(txtKodediskon.Text);
            if (dr != null)
            {

                MessageBox.Show("Selamat, Anda Mendapatkan Potongan Harga sebesar Rp." + dr[2].ToString() + "'","Berhasil Mendapatkan Diskon",MessageBoxButtons.OK,MessageBoxIcon.Information);
                diskon = double.Parse(dr[2].ToString());
                totalpembayaran = double.Parse(txtTotalPembayaran.Text) - diskon;
                txtTotalPembayaran.Text = totalpembayaran.ToString();
            }
            else
            {
                MessageBox.Show("Kode Diskon Tidak Ditemukan ! Mohon COba Lagi","Diskon Tidak Tersedia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            btnCari.Enabled = false;
            chkDiskon.Enabled = false;
        }

        private void chkDiskon_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDiskon.Checked == true)
            {
                txtKodediskon.Enabled = true;
                btnCari.Enabled = true;
                txtKodediskon.Clear();
                txtKodediskon.Focus();
            }
            else
            {
                txtKodediskon.Enabled = false;
                btnCari.Enabled = false;
                txtKodediskon.Clear();
                txtKodediskon.Focus();
            }
        }
        double Bayar;
        private void btnBayar_Click(object sender, EventArgs e)
        {
            Bayar = double.Parse(txtJumlahPembayaran.Text);
            if (Bayar < double.Parse(txtTotalPembayaran.Text))
            {
                MessageBox.Show("Pembayaran Tidak Valid !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtJumlahPembayaran.Clear();
                txtJumlahPembayaran.Focus();
            }
            else
            {
                totalpembayaran = Bayar - double.Parse(txtTotalPembayaran.Text);


                //---Database__Table Bayar------//
                loaddata_Pembayaran();
                caripembayaran[0] = lblNoPembayaran.Text;
                caripembayaran[1] = txtNoTransaksi.Text;
                dr = ds.Tables["Pembayaran"].Rows.Find(caripembayaran);
                if (dr == null)
                {
                    dr = ds.Tables["Pembayaran"].NewRow();
                    dr[0] = lblNoPembayaran.Text;
                    dr[1] = txtNoTransaksi.Text;
                    dr[2] = lblNama.Text;
                    dr[3] = lblbanyakdata.Text;
                    dr[4] = lbltotalhargabayar.Text;
                    dr[5] = txtJumlahPembayaran.Text;
                    dr[6] = lblMetode.Text;
                    dr[7] = txtmetodebayar.Text;
                    dr[8] = lblPajak.Text;
                    dr[9] = txtKodediskon.Text;
                    dr[10] = diskon;
                    dr[11] = txtTotalPembayaran.Text;
                    dr[12] = lblKembalian.Text;
                    ds.Tables["Pembayaran"].Rows.Add(dr);
                    update_Pembayaran();

                    //-==---------TablePenjualan==------//
                    loaddata_Penjualan();
                    cari[0] = txtNoTransaksi.Text;
                    cari[1] = dgvTransaksi.Rows[0].Cells[1].Value.ToString();
                    cari[2] = txtNoPesanan.Text;
                    dr = ds.Tables["Penjualan"].Rows.Find(cari);
                    if (dr != null)
                    {
                        dr[7] = "Clear";
                        updatedata_Penjualan();
                        tampilpesanan();
                    }
                    MessageBox.Show("Pembayaran Berhasil ! Kembalian anda sebesar " + totalpembayaran.ToString("Rp#,##0"), "Pembayaran Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Silahkan Tekan Tombol Cetak Struk Pelanggan, Agar dapat kembali Melanjutkan Penjualan !","Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblKembalian.Text = totalpembayaran.ToString();
                    grpPembayaran.Enabled = false;
                    grpDetailPembayaran.Enabled = false;
                    grpDetailPesanan.Enabled = false;
                    dgvTransaksi.Enabled = false;

                    btnBayar.Enabled = false;
                    btnBatalPesanan.Enabled = false;
                    BtnCetakStruk.Focus();
                    BtnCetakStruk.Enabled = true;
                    lblexit.Enabled = false;
                }
            }
        }
        private void HapusMenuBayar()
        {
            kodepembayaran();
            txtNoPesanan.Clear();
            txtNoTransaksi.Clear();
            lblNama.Text = "";
            lblbanyakdata.Text = "";
            lbltotalhargabayar.Text = "0";
            txtJumlahPembayaran.Text = "";
            cmbMetodeBayar.SelectedItem = "Tunai";
            txtmetodebayar.Clear();
            lblPajak.Text = "0";
            btnCari.Enabled = true;
            txtKodediskon.Clear();
            chkDiskon.Checked = true;
            txtTotalPembayaran.Text = "0";
            lblKembalian.Text = "0";
            btnBatalPesanan.Enabled = false;
            BtnCetakStruk.Focus();
            //
     

        }

        private void btnBatalPesanan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin Membatalkan Pesanan Ini", "Hapus Pesanan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                loaddata_Penjualan();
                cari[0] = txtNoTransaksi.Text;
                cari[1] = dgvTransaksi.Rows[0].Cells[1].Value.ToString();
                cari[2] = txtNoPesanan.Text;
                dr = ds.Tables["Penjualan"].Rows.Find(cari);
                if (dr != null)
                {
                    dr.Delete();
                    updatedata_Penjualan();
                    MessageBox.Show("Data Pesanan berhasil di Hapus.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Wah, Penjualan Kosong Lagi Nih ! Transaksi Lagi Yuk ", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tampilpesanan();


                    //---DetailPenjualan
                    loaddata_DetailPenjualan();
                    caripesanan[0] = lblUserID.Text;
                    caripesanan[1] = txtNoTransaksi.Text;
                    dr = ds.Tables["DetailPenjualan"].Rows.Find(caripesanan);
                    if (dr != null)
                    {
                        dr.Delete();
                        updatedata_DetailPenjualan();
                    }
                }
            }
            //----------------
            loaddata_DetailPesanan();
            detailpesananTampilan();
            //---
            tabMenu.SelectedTab = tpTransaksi;
            //
            grpTransaksiBaru.Enabled = true;
            grpDataPesanan.Enabled = true;
            btnInputPenjualan.Enabled = true;
            HapusMenuBayar();
        }

        private void txtJumlahPembayaran_TextChanged_1(object sender, EventArgs e)
        {
      
        }

        private void txtJumlahPembayaran_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(lblNama.Text)&& !string.IsNullOrWhiteSpace(lblbanyakdata.Text)&& !string.IsNullOrWhiteSpace(lbltotalhargabayar.Text)&& !string.IsNullOrWhiteSpace(txtJumlahPembayaran.Text))
            {
                btnBayar.Enabled = true;
            }
            else
            {
                btnBayar.Enabled = false;
            }
        }

        private void BtnCetakStruk_Click(object sender, EventArgs e)
        {
            frmStruk cetak = new frmStruk(this);
            cetak.Show();
            //
            lblexit.Enabled = true;
        }

        private void label7_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void label7_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void label7_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
            mov = 0;
        }
        //----
        int mov;
        int movX;
        int movY;
        //----
        int mov1;
        int movX1;
        int movY1;

        private void lbltotalhargabayar_Click(object sender, EventArgs e)
        {

        }

        private void btnBersih_Click(object sender, EventArgs e)
        {
            HapusMenuBayar();
            btnBersih.Enabled = false;
            grpTransaksiBaru.Enabled = true;
            grpDataPesanan.Enabled = true;
            btnInputPenjualan.Enabled = true;

            tabMenu.SelectedTab = tpTransaksi;
            //
        }

        //--0--

        private void dgvDataDetailPesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNoPelanggan_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tpPembayaran_Click(object sender, EventArgs e)
        {

        }

        double Harga, jumlah, totalharga;
        private void nudJumlah_ValueChanged(object sender, EventArgs e)
        {

            Harga =  double.Parse(lblHarga.Text);
            jumlah = double.Parse(nudJumlah.Value.ToString());

            totalharga = Harga * jumlah;
            //-
            lblTotal.Text = totalharga.ToString();
        }
    }
}
