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
    public partial class frmAturProduk : Form
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
        public frmAturProduk()
        {
            InitializeComponent();
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

        private void dgvDataProduk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgvDataProduk.CurrentCell.RowIndex;
            txtKodeProduk.Text = dgvDataProduk.Rows[baris].Cells[0].Value.ToString();
            txtNamaProduk.Text = dgvDataProduk.Rows[baris].Cells[1].Value.ToString();
            txtHargaProduk.Text = dgvDataProduk.Rows[baris].Cells[2].Value.ToString();
            nudQty.Value = decimal.Parse(dgvDataProduk.Rows[baris].Cells[3].Value.ToString());
            if( dgvDataProduk.Rows[baris].Cells[4].Value.ToString() == "1")
            {
                rdoAktif.Checked = true;
                rdoNonAktif.Checked = false;
            }
            else if(dgvDataProduk.Rows[baris].Cells[4].Value.ToString() == "0")
            {
                rdoNonAktif.Checked = true;
                rdoAktif.Checked = false;
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin Menghapus Data Produk " + txtNamaProduk.Text + " ? ", "Hapus Produk", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                loaddata_Produk();
                dr = ds.Tables["Produk"].Rows.Find(txtKodeProduk.Text);
                if (dr != null)
                {
                    dr.Delete();
                    updatedata_TambahProduk();
                    tampilDataProduk();


                    //--DetailHapus--
                    loaddata_DetailTambahProduk();
                    cari[0] = lbluser.Text;
                    cari[1] = txtKodeProduk.Text;
                    dr = ds.Tables["DetailTambahProduk"].Rows.Find(cari);
                    if (dr != null)
                    {
                        dr.Delete();
                        updatedata_DetailTambahProduk();
                    }
                    MessageBox.Show("Data Produk berhasil di Hapus.", "Hapus Produk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hapus();
                }
            }
        }
        private void Hapus()
        {
            txtKodeProduk.Clear();
            txtCariNama.Clear();
            txtNamaProduk.Clear();
            txtHargaProduk.Clear();
            rdoAktif.Checked = false;
            rdoNonAktif.Checked = false;
            nudQty.Value = 0;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtCariNama.Clear();
            loaddata_Produk();
            tampilDataProduk();
            txtCariNama.Focus();
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin keluar dari Menu Produk ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin membatalkan Pengaturan Produk", "Batal", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin mengubah data Produk Ini ? ", "Ubah Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                loaddata_Produk();
                dr = ds.Tables["Produk"].Rows.Find(txtKodeProduk.Text);
                if (dr != null)
                {
                    dr[1] = txtNamaProduk.Text;
                    dr[2] = txtHargaProduk.Text;
                    dr[3] = nudQty.Value;
                    if (rdoAktif.Checked)
                    {
                        dr[4] ='1';
                    }
                    else if(rdoNonAktif.Checked)
                    {
                        dr[4] = '0';
                    }
                    updatedata_TambahProduk();
                    MessageBox.Show("Data produk berhasil di Ubah.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tampilDataProduk();
                    Hapus();
                }
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            query = "Select * from Produk where NamaProduk LIKE '%" + txtCariNama.Text + "%'";
            cmd = new SqlCommand(query, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Produk");
            dc_1pk[0] = ds.Tables["Produk"].Columns[0];
            ds.Tables["Produk"].PrimaryKey = dc_1pk;
            tampilDataProduk();
        }

        private void frmAturProduk_Load(object sender, EventArgs e)
        {
            koneksi();
            loaddata_Produk();
            tampilDataProduk();
        }
    }
}
