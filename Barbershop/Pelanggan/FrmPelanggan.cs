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

namespace Barbershop.Pelanggan
{
    public partial class FrmTambahPelanggan : Form
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

        public FrmTambahPelanggan()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void loaddata_Pelanggan()
        {
            ds = new DataSet();
            query = "Select * from Pelanggan";
            cmd = new SqlCommand(query, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Pelanggan");
            dc_1pk[0] = ds.Tables["Pelanggan"].Columns[0];
            ds.Tables["Pelanggan"].PrimaryKey = dc_1pk;
        }
        private void loaddata_DetailPelanggan()
        {
            ds = new DataSet();
            query = "Select * from DetailPelanggan";
            cmd = new SqlCommand(query, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "DetailPelanggan");
            dc_2pk[0] = ds.Tables["DetailPelanggan"].Columns[0];
            dc_2pk[1] = ds.Tables["DetailPelanggan"].Columns[1];
            ds.Tables["DetailPelanggan"].PrimaryKey = dc_2pk;
        }
        private void tampilDataPelanggan()
        {
            dgvTampilData.DataSource = ds.Tables["Pelanggan"];
            dgvTampilData.Columns[0].HeaderText = "No Pelanggan";
            dgvTampilData.Columns[1].HeaderText = "Nama";
            dgvTampilData.Columns[2].HeaderText = "Umur";
            dgvTampilData.Columns[3].HeaderText = "Alamat";
            dgvTampilData.Columns[4].HeaderText = "No Hp";
            dgvTampilData.Columns[5].HeaderText = "Tanggal Bergabung";
            dgvTampilData.ReadOnly = true;
            dgvTampilData.AllowUserToAddRows = false;
            lblJumlah.Text = dgvTampilData.Rows.Count.ToString();
        }
        private void koneksi()
        {
                constr = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = Barbershop; Integrated Security = true";
                conn = new SqlConnection(constr);
                conn.Open();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            loaddata_Pelanggan();
            dr = ds.Tables["Pelanggan"].Rows.Find(txtNoPelanggan.Text);
            if(dr == null)
            {
                dr = ds.Tables["Pelanggan"].NewRow();
                dr[0] = txtNoPelanggan.Text;
                dr[1] = txtNama.Text;
                dr[2] = txtUmur.Text;
                dr[3] = txtAlamat.Text;
                dr[4] = txtNoHp.Text;
                dr[5] = DateTime.Now.ToString("dd-MM-yyyy");
                ds.Tables["Pelanggan"].Rows.Add(dr);
                updatedata_TambahPelanggan();
                tampilDataPelanggan();

                //---Detail--//
                loaddata_DetailPelanggan();
                cari[0] = lblUserID.Text;
                cari[1] = txtNoPelanggan.Text;
                dr = ds.Tables["DetailPelanggan"].Rows.Find(cari);
                if (dr == null)
                {
                    dr = ds.Tables["DetailPelanggan"].NewRow();
                    dr[0] = lblUserID.Text;
                    dr[1] = txtNoPelanggan.Text;
                    dr[2] = DateTime.Now.ToString("dd-MM-yyyy");
                    ds.Tables["DetailPelanggan"].Rows.Add(dr);
                    updatedata_DetailPelanggan();
                  
                }
                MessageBox.Show("Pelanggan Berhasil Ditambahkan", "Tambah Pelanggan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hapus();
                kodepelanggan();
            }
            else
            {
                MessageBox.Show("ID Pelanggan Sudah Tersedia !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Hapus()
        {
            txtNama.Clear();
            txtNoHp.Clear();
            txtAlamat.Clear();
            txtUmur.Clear();

            txtNoPelanggan.Focus();
        }
        private void updatedata_TambahPelanggan()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Pelanggan"]);
        }
        private void updatedata_DetailPelanggan()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["DetailPelanggan"]);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loaddata_Pelanggan();
            tampilDataPelanggan();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Apakah anda ingin menghapus data informasi pelanggan ? ","Hapus",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                Hapus();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin membatalkan penamabahan Pelanggan ? ", "Batal", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Hapus();
                this.Close();
            }
        }

        private void txtNoPelanggan_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtNoPelanggan.Text) && !string.IsNullOrWhiteSpace(txtNama.Text) && !string.IsNullOrWhiteSpace(txtNoHp.Text) && !string.IsNullOrWhiteSpace(txtUmur.Text) && !string.IsNullOrWhiteSpace(txtAlamat.Text))
            {
                btnSimpan.Enabled = true;
            }
            else
            {
                btnSimpan.Enabled = false;
            }
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin keluar dari Menu Pelanggan ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void kodepelanggan()
        {
            Random angka = new Random();
            byte[] angkabyte = new byte[2];

            string a;
            for (int i = 1; i <= 2; i++)
            {
                a = "PL" + angka.Next();
                txtNoPelanggan.Text = a.Substring(0, 9);
            }
        }
        private void FrmTambahPelanggan_Load(object sender, EventArgs e)
        {
            kodepelanggan();
            koneksi();
            loaddata_Pelanggan();
            tampilDataPelanggan();

            //----
            btnSimpan.Enabled = false;
            //----
        }
    }
}
