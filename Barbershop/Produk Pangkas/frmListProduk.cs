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

namespace Barbershop.Produk_Pangkas
{
    public partial class frmListProduk : Form
    {
        SqlConnection conn;
        string constr, query;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        DataRow dr;
        DataColumn[] dc_1pk = new DataColumn[1];
        DataColumn[] dc_2pk = new DataColumn[2];
        SqlCommandBuilder cb;
        string[] cari = new string[2];

        private void loaddata_Produk()
        {
            ds = new DataSet();
            query = "Select p.KodeProduk,dtp.Userid,p.NamaProduk,p.HargaProduk, p.StockProduk,p.TanggalProduk from Produk  p inner join DetailTambahProduk dtp on p.KodeProduk = dtp.KodeProduk";
            cmd = new SqlCommand(query, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Produk");
            dc_2pk[0] = ds.Tables["Produk"].Columns[0];
            dc_2pk[1] = ds.Tables["Produk"].Columns[1];
            ds.Tables["Produk"].PrimaryKey = dc_2pk;
        }


        private void tampilDataProduk()
        {
            dgvDataProduk.DataSource = ds.Tables["Produk"];
            dgvDataProduk.Columns[0].HeaderText = "Kode Produk";
            dgvDataProduk.Columns[1].HeaderText = "Kode User";
            dgvDataProduk.Columns[2].HeaderText = "Nama Produk ";
            dgvDataProduk.Columns[3].HeaderText = "Stock";
            dgvDataProduk.Columns[4].HeaderText = "Tanggal Terbit";
            dgvDataProduk.ReadOnly = true;
            dgvDataProduk.AllowUserToAddRows = false;
            lblJumlah.Text = dgvDataProduk.Rows.Count.ToString();
        }

        private void koneksi()
        {
            constr = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = Barbershop; Integrated Security = true";
            conn = new SqlConnection(constr);
            conn.Open();
        }
        public frmListProduk()
        {
            InitializeComponent();
        }
        Beranda.frmPenjualan penjualan;
        public frmListProduk(Beranda.frmPenjualan penjualan)
        {
            InitializeComponent();
            this.penjualan = penjualan;
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            if (rdoAktif.Checked)
            {
                if (rdoKodeProduk.Checked)
                {
                    query = "Select p.KodeProduk,dtp.Userid,p.NamaProduk,p.HargaProduk, p.StockProduk,p.TanggalProduk from Produk  p inner join DetailTambahProduk dtp on p.KodeProduk = dtp.KodeProduk where p.KodeProduk LIKE '%" + txtCariNama.Text + "%' and StatusProduk = '1'";
                }
                else if (rdoKodeUser.Checked)
                {
                    query = "Select p.KodeProduk,dtp.Userid,p.NamaProduk,p.HargaProduk, p.StockProduk,p.TanggalProduk from Produk  p inner join DetailTambahProduk dtp on p.KodeProduk = dtp.KodeProduk where dtp.Userid LIKE '%" + txtCariNama.Text + "%' and StatusProduk = '1'";
                }
                else if (rdoNama.Checked)
                {
                    query = "Select p.KodeProduk,dtp.Userid,p.NamaProduk,p.HargaProduk, p.StockProduk,p.TanggalProduk from Produk  p inner join DetailTambahProduk dtp on p.KodeProduk = dtp.KodeProduk where p.NamaProduk LIKE '%" + txtCariNama.Text + "%' and StatusProduk = '1'";
                }
                else if (rdoStock.Checked)
                {
                    query = "Select p.KodeProduk,dtp.Userid,p.NamaProduk,p.HargaProduk, p.StockProduk,p.TanggalProduk from Produk  p inner join DetailTambahProduk dtp on p.KodeProduk = dtp.KodeProduk where p.StockProduk LIKE '%" + txtCariNama.Text + "%' and StatusProduk = '1'";
                }
            }
            else if (rdoNonaktif.Checked)
            {
                if (rdoKodeProduk.Checked)
                {
                    query = "Select p.KodeProduk,dtp.Userid,p.NamaProduk,p.HargaProduk, p.StockProduk,p.TanggalProduk from Produk  p inner join DetailTambahProduk dtp on p.KodeProduk = dtp.KodeProduk where p.KodeProduk LIKE '%" + txtCariNama.Text + "%' and StatusProduk = '0'";
                }
                else if (rdoKodeUser.Checked)
                {
                    query = "Select p.KodeProduk,dtp.Userid,p.NamaProduk,p.HargaProduk, p.StockProduk,p.TanggalProduk from Produk  p inner join DetailTambahProduk dtp on p.KodeProduk = dtp.KodeProduk where dtp.Userid LIKE '%" + txtCariNama.Text + "%' and StatusProduk = '0'";
                }
                else if (rdoNama.Checked)
                {
                    query = "Select p.KodeProduk,dtp.Userid,p.NamaProduk,p.HargaProduk, p.StockProduk,p.TanggalProduk from Produk  p inner join DetailTambahProduk dtp on p.KodeProduk = dtp.KodeProduk where p.NamaProduk LIKE '%" + txtCariNama.Text + "%' and StatusProduk = '0'";
                }
                else if (rdoStock.Checked)
                {
                    query = "Select p.KodeProduk,dtp.Userid,p.NamaProduk,p.HargaProduk, p.StockProduk,p.TanggalProduk from Produk  p inner join DetailTambahProduk dtp on p.KodeProduk = dtp.KodeProduk where p.StockProduk LIKE '%" + txtCariNama.Text + "%' and StatusProduk = '0'";
                }
            }
            cmd = new SqlCommand(query, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Produk");
            dc_1pk[0] = ds.Tables["Produk"].Columns[0];
            ds.Tables["Produk"].PrimaryKey = dc_1pk;
            tampilDataProduk();
        }

        private void frmListProduk_Load(object sender, EventArgs e)
        {
            koneksi();
            loaddata_Produk();
            tampilDataProduk();
            rdoAktif.Checked = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loaddata_Produk();
            tampilDataProduk();
            txtCariNama.Clear();
            txtCariNama.Focus();

            rdoAktif.Checked = true;
            rdoNama.Checked = true;
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin keluar dari Menu Produk ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //----
        int mov;
        int movX;
        int movY;
        //----
        int mov1;
        int movX1;
        int movY1;
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
        public decimal d;
        public int baris;
        private void dgvDataProduk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              baris = dgvDataProduk.CurrentCell.RowIndex;

            d = decimal.Parse(dgvDataProduk[4, baris].Value.ToString());
            if ( d < 1)
            {
                MessageBox.Show("Mohon Untuk menambahkan Jumlah Produk Anda !","Erro Menambahkan",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
                penjualan.btnBrowseLayananBarber.Enabled = true;
            }
            else
            {
                penjualan.nudJumlah.Maximum = decimal.Parse(dgvDataProduk[4, baris].Value.ToString());
                penjualan.lblKodeProduk.Text = dgvDataProduk[0, baris].Value.ToString();
                penjualan.lblKode.Text = dgvDataProduk[0, baris].Value.ToString();
                penjualan.lblNamaPesanan.Text = dgvDataProduk[2, baris].Value.ToString();
                penjualan.lblHarga.Text = dgvDataProduk[3, baris].Value.ToString();
                this.Close();
            }
            
        }

        private void rdoNama_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        
        }
    }
}
