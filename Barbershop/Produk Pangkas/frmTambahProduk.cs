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
    public partial class frmTambahProduk : Form
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

        //-----------------
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
        //----
        private void loaddata_DetailTambahProduk()
        {
            ds = new DataSet();
            query = "Select * from DetailTambahProduk";
            cmd = new SqlCommand(query, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "DetailTambahProduk");
            dc_2pk[0] = ds.Tables["DetailTambahProduk"].Columns[0];
            dc_2pk[1] = ds.Tables["DetailTambahProduk"].Columns[1];
            ds.Tables["DetailTambahProduk"].PrimaryKey = dc_2pk;
        }
        private void updatedata_DetailTambahProduk()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["DetailTambahProduk"]);
        }
        private void koneksi()
        {
            constr = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = Barbershop; Integrated Security = true";
            conn = new SqlConnection(constr);
            conn.Open();
        }

        public frmTambahProduk()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            loaddata_Produk();
            dr = ds.Tables["Produk"].Rows.Find(txtKodeProduk.Text);
            if (dr == null)
            {
                dr = ds.Tables["Produk"].NewRow();
                dr[0] = txtKodeProduk.Text;
                dr[1] = txtNamaProduk.Text;
                dr[2] = txtHargaProduk.Text;
                dr[3] = nudQty.Value;
                dr[4] = '1';
                dr[5] = DateTime.Now.ToString("dd-MMMM-yyyy");
                ds.Tables["Produk"].Rows.Add(dr);
                updatedata_TambahProduk();

                //---Detail--//
                loaddata_DetailTambahProduk();
                cari[0] = lbluser.Text;
                cari[1] = txtKodeProduk.Text;
                dr = ds.Tables["DetailTambahProduk"].Rows.Find(cari);
                if (dr == null)
                {
                    dr = ds.Tables["DetailTambahProduk"].NewRow();
                    dr[0] = lbluser.Text;
                    dr[1] = txtKodeProduk.Text;
                    dr[2] = nudQty.Value;
                    dr[3] = DateTime.Now.ToString("dd-MMMM-yyyy");
                    ds.Tables["DetailTambahProduk"].Rows.Add(dr);
                    updatedata_DetailTambahProduk();
                }
                MessageBox.Show("Produk Pangkas Berhasil Ditambahkan", "Tambah Produk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hapus();
                kodeproduk();

            }
            else
            {
                MessageBox.Show("ID Produk Sudah Tersedia !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Hapus()
        {
            txtNamaProduk.Clear();
            txtHargaProduk.Clear();
            nudQty.Value = 0;
            txtNamaProduk.Focus();
        }
        private void tampilDataProduk()
        {
            dgvDataProduk.DataSource = ds.Tables["Produk"];
            dgvDataProduk.Columns[0].HeaderText = "Kode Produk";
            dgvDataProduk.Columns[1].HeaderText = "Nama Produk";
            dgvDataProduk.Columns[2].HeaderText = "Harga Produk ";
            dgvDataProduk.Columns[3].HeaderText = "Stock";
            dgvDataProduk.ReadOnly = true;
            dgvDataProduk.AllowUserToAddRows = false;
            lblJumlah.Text = dgvDataProduk.Rows.Count.ToString();
        }
        private void kodeproduk()
        {
            Random angka = new Random();
            byte[] angkabyte = new byte[2];

            string a;
            for (int i = 1; i <= 2; i++)
            {
                a = "P" + angka.Next();
                txtKodeProduk.Text = a.Substring(0, 8);
            }
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin keluar dari Menu Produk ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            Hapus();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Apakah anda ingin membatalkan penambahan Produk", "Batal", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK){

                this.Close();
            }

        }

        private void dgvDataProduk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loaddata_Produk();
            tampilDataProduk();
        }

        private void frmTambahProduk_Load(object sender, EventArgs e)
        {
            kodeproduk();
            koneksi();
            loaddata_Produk();
            tampilDataProduk();
        }
    }
}
