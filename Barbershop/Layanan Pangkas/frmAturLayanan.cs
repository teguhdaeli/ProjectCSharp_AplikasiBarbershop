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
    public partial class frmAturLayanan : Form
    {
        public frmAturLayanan()
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

        private void loaddata_Layanan()
        {
            ds = new DataSet();
            query = "Select KodeLayanan,NamaLayanan,HargaLayanan,Status from LayananPangkas";
            cmd = new SqlCommand(query, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "LayananPangkas");
            dc_1pk[0] = ds.Tables["LayananPangkas"].Columns[0];
            ds.Tables["LayananPangkas"].PrimaryKey = dc_1pk;
        }
        private void tampilDataLayanan()
        {
            dgvTampilLayanan.DataSource = ds.Tables["LayananPangkas"];
            dgvTampilLayanan.Columns[0].HeaderText = "Kode Layanan";
            dgvTampilLayanan.Columns[1].HeaderText = "Nama Layanan";
            dgvTampilLayanan.Columns[2].HeaderText = "Harga Layanan";
            dgvTampilLayanan.ReadOnly = true;
            dgvTampilLayanan.AllowUserToAddRows = false;
            lblJumlah.Text = dgvTampilLayanan.Rows.Count.ToString();
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

        private void lblexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin keluar dari Menu Layanan ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loaddata_Layanan();
            tampilDataLayanan();
            Hapus();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin mengubah data Layanan Ini ? ", "Ubah Layanan", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                loaddata_Layanan();
                dr = ds.Tables["LayananPangkas"].Rows.Find(txtnoLayanan.Text);
                if (dr != null)
                {
                    dr[1] = txtNamaLayanan.Text;
                    dr[2] = txtHarga.Text;
                    if (rdoAktif.Checked)
                    {
                        dr[3] = '1';
                    }
                    else if (rdoNonaktif.Checked)
                    {
                        dr[3] = '0';
                    }
                    updatedata_Layanan();
                    MessageBox.Show("Layanan Pangkas Berhasil Diubah", "Ubah Layanan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hapus();
                    tampilDataLayanan();
                }
            }
        }
        private void Hapus()
        {
            txtnoLayanan.Clear();
            txtNamaLayanan.Clear();
            txtHarga.Clear();
            rdoAktif.Checked = false;
            rdoNonaktif.Checked = false;
        }

        private void dgvTampilLayanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgvTampilLayanan.CurrentCell.RowIndex;
            txtnoLayanan.Text = dgvTampilLayanan.Rows[baris].Cells[0].Value.ToString();
            txtNamaLayanan.Text = dgvTampilLayanan.Rows[baris].Cells[1].Value.ToString();
            txtHarga.Text = dgvTampilLayanan.Rows[baris].Cells[2].Value.ToString();
            if (dgvTampilLayanan.Rows[baris].Cells[3].Value.ToString() == "1")
            {
                rdoAktif.Checked = true;
            }
            else
            {
                rdoNonaktif.Checked = true;

            }
        }

        private void btnHapusData_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin Menghapus data Layanan Ini ? ", "Hapus Layanan", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                loaddata_Layanan();
                dr = ds.Tables["LayananPangkas"].Rows.Find(txtnoLayanan.Text);
                if (dr != null)
                {
                    dr.Delete();
                    updatedata_Layanan();
                    MessageBox.Show("Layanan Pangkas Berhasil Di Hapus", "Hapus Layanan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hapus();
                    tampilDataLayanan();
                }
            }
        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtnoLayanan.Text) && !string.IsNullOrWhiteSpace(txtNamaLayanan.Text) && !string.IsNullOrWhiteSpace(txtHarga.Text))
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

        private void frmAturLayanan_Load(object sender, EventArgs e)
        {
            koneksi();
            loaddata_Layanan();
            tampilDataLayanan();
        }
    }
}
