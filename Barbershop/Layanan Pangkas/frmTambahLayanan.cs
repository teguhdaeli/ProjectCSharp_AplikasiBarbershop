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


namespace Barbershop.Produk___Layanan_Pangkas
{
    public partial class frmTambahLayanan : Form
    {
        public frmTambahLayanan()
        {
            InitializeComponent();
        }
        FrmHome home;
        public frmTambahLayanan(FrmHome home)
        {
            InitializeComponent();
            this.home = home;
        }

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

        private void loaddata_Layanan()
        {
            ds = new DataSet();
            query = "Select * from LayananPangkas";
            cmd = new SqlCommand(query, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "LayananPangkas");
            dc_1pk[0] = ds.Tables["LayananPangkas"].Columns[0];
            ds.Tables["LayananPangkas"].PrimaryKey = dc_1pk;
        }
        private void tampilDataLayanan()
        {
            dgvDataLayanan.DataSource = ds.Tables["LayananPangkas"];
            dgvDataLayanan.Columns[0].HeaderText = "Kode Layanan";
            dgvDataLayanan.Columns[1].HeaderText = "Nama Layanan";
            dgvDataLayanan.Columns[2].HeaderText = "Harga Layanan";
            dgvDataLayanan.ReadOnly = true;
            dgvDataLayanan.AllowUserToAddRows = false;
            lblJumlah.Text = dgvDataLayanan.Rows.Count.ToString();
        }

        private void loaddata_DetailLayanan()
        {
            ds = new DataSet();
            query = "Select * from DetailLayananPangkas";
            cmd = new SqlCommand(query, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "DetailLayananPangkas");
            dc_2pk[0] = ds.Tables["DetailLayananPangkas"].Columns[0];
            dc_2pk[1] = ds.Tables["DetailLayananPangkas"].Columns[1];
            ds.Tables["DetailLayananPangkas"].PrimaryKey = dc_2pk;
        }
        private void koneksi()
        {
            constr = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = Barbershop; Integrated Security = true";
            conn = new SqlConnection(constr);
            conn.Open();
        }

        private void updatedata_Layanan()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["LayananPangkas"]);
        }
        private void updatedata_DetailLayanan()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["DetailLayananPangkas"]);
        }

        private void lblJumlah_Click(object sender, EventArgs e)
        {

        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin keluar dari Menu Layanan ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            loaddata_Layanan();
            dr = ds.Tables["LayananPangkas"].Rows.Find(txtnoLayanan.Text);
            if (dr == null)
            {
                dr = ds.Tables["LayananPangkas"].NewRow();
                dr[0] = txtnoLayanan.Text;
                dr[1] = txtNamaLayanan.Text;
                dr[2] = txtHarga.Text;
                dr[3] = '1';
                dr[4] = DateTime.Now.ToString("dd-MM-yyyy");
                ds.Tables["LayananPangkas"].Rows.Add(dr);
                updatedata_Layanan();

                //---Detail--//
                loaddata_DetailLayanan();
                cari[0] = lblUserID.Text;
                cari[1] = txtnoLayanan.Text;
                dr = ds.Tables["DetailLayananPangkas"].Rows.Find(cari);
                if (dr == null)
                {
                    dr = ds.Tables["DetailLayananPangkas"].NewRow();
                    dr[0] = lblUserID.Text;
                    dr[1] = txtnoLayanan.Text;
                    dr[2] = DateTime.Now.ToString("dd-MM-yyyy");
                    ds.Tables["DetailLayananPangkas"].Rows.Add(dr);
                    updatedata_DetailLayanan();
                }
                MessageBox.Show("Layanan Pangkas Berhasil Ditambahkan", "Tambah Layanan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hapus();
                kodelayanan();
            }
            else
            {
                MessageBox.Show("ID Layanan Sudah Tersedia !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Hapus()
        {
            txtNamaLayanan.Clear();
            txtHarga.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loaddata_Layanan();
            tampilDataLayanan();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            Hapus();
        }
        private void kodelayanan()
        {
            Random angka = new Random();
            byte[] angkabyte = new byte[2];

            string a;
            for (int i = 1; i <= 2; i++)
            {
                a = "LP"+ angka.Next();
                txtnoLayanan.Text = a.Substring(0, 9);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Apakah anda ingin membatalkan penamabahan Layanan Pangkas ? ", "Batal", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Hapus();
                this.Close();
            }
        }

        private void btnSimpan_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtnoLayanan.Text) && !string.IsNullOrWhiteSpace(txtNamaLayanan.Text) && !string.IsNullOrWhiteSpace(txtHarga.Text))
            {
                btnSimpan.Enabled = true;
            }
            else
            {
                btnSimpan.Enabled = false;
            }
        }

        private void dgvDataLayanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmTambahProduk_Load(object sender, EventArgs e)
        {
            //---
            koneksi();
            loaddata_Layanan();
            tampilDataLayanan();
            kodelayanan();

            //--\

            btnSimpan.Enabled = false;
        }
    }
}
