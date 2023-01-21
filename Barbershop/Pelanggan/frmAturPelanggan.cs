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
    public partial class frmAturPelanggan : Form
    {
        public frmAturPelanggan()
        {
            InitializeComponent();
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
        private void updatedata_TambahPelanggan()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Pelanggan"]);
        }
        private void koneksi()
        {
            constr = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = Barbershop; Integrated Security = true";
            conn = new SqlConnection(constr);
            conn.Open();
        }

        private void dgvTampilData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgvTampilData.CurrentCell.RowIndex;
            txtNoPelanggan.Text = dgvTampilData.Rows[baris].Cells[0].Value.ToString();
            txtNama.Text = dgvTampilData.Rows[baris].Cells[1].Value.ToString();
            txtUmur.Text = dgvTampilData.Rows[baris].Cells[2].Value.ToString();
            txtNoHp.Text = dgvTampilData.Rows[baris].Cells[4].Value.ToString();
            txtAlamat.Text = dgvTampilData.Rows[baris].Cells[3].Value.ToString();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Apakah anda yakin ingin Menghapus Data Customer " + txtNama.Text + " ? ","Hapus",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                loaddata_Pelanggan();
                dr = ds.Tables["Pelanggan"].Rows.Find(txtNoPelanggan.Text);
                if (dr != null)
                {
                    dr.Delete();
                    updatedata_TambahPelanggan();
                    MessageBox.Show("Data Customer berhasil di Hapus.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tampilDataPelanggan();
                    Hapus();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            query = "Select * from Pelanggan where Nama LIKE '%" + txtCariNama.Text + "%'";
            cmd = new SqlCommand(query, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Pelanggan");
            dc_1pk[0] = ds.Tables["Pelanggan"].Columns[0];
            ds.Tables["Pelanggan"].PrimaryKey = dc_1pk;
            tampilDataPelanggan();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtCariNama.Clear();
            loaddata_Pelanggan();
            tampilDataPelanggan();
            txtCariNama.Focus();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Apakah anda yakin ingin mengubah data Customer Ini ? ","Ubah Data",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                loaddata_Pelanggan();
                dr = ds.Tables["Pelanggan"].Rows.Find(txtNoPelanggan.Text);
                if (dr != null)
                {
                    dr[1] = txtNama.Text;
                    dr[2] = txtUmur.Text;
                    dr[3] = txtAlamat.Text;
                    dr[4] = txtNoHp.Text;
                    updatedata_TambahPelanggan();
                    MessageBox.Show("Data Customer berhasil di Ubah.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tampilDataPelanggan();
                    Hapus();
                }
            }
        
        }
        private void Hapus()
        {
            txtNoPelanggan.Clear();
            txtNama.Clear();
            txtNoHp.Clear();
            txtCariNama.Clear();
            txtUmur.Clear();
            txtAlamat.Clear();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin membatalkan Pengaturan Pelanggan ? ", "Batal", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Hapus();
                this.Close();
            }
        }

        private void btnUbah_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNoPelanggan.Text) && !string.IsNullOrWhiteSpace(txtNama.Text) && !string.IsNullOrWhiteSpace(txtNoHp.Text) && !string.IsNullOrWhiteSpace(txtUmur.Text) && !string.IsNullOrWhiteSpace(txtAlamat.Text))
            {
                btnUbah.Enabled = true;
                btnHapusData.Enabled = true;
            }
            else
            {
                btnUbah.Enabled = false;
                btnHapusData.Enabled = false;
            }
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin keluar dari Menu Pelanggan ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmAturPelanggan_Load(object sender, EventArgs e)
        {
            koneksi();
            loaddata_Pelanggan();
            tampilDataPelanggan();
            txtCariNama.Focus();

            //--
            btnUbah.Enabled = false;
            btnHapusData.Enabled = false;
        }
    }
}
