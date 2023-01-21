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


namespace Barbershop.Diskon
{
    public partial class FrmDiskon : Form
    {
        public FrmDiskon()
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
        SqlCommandBuilder cb;
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

        private void tampilDiskon()
        {
            dgvdatadiskon.DataSource = ds.Tables["Diskon"];
            dgvdatadiskon.Columns[0].HeaderText = "Kode Diskon";
            dgvdatadiskon.Columns[1].HeaderText = "Nama Diskon";
            dgvdatadiskon.Columns[2].HeaderText = "Potongan Harga";
            dgvdatadiskon.Columns[3].HeaderText = "Tanggal Bergabung";
            dgvdatadiskon.ReadOnly = true;
            dgvdatadiskon.AllowUserToAddRows = false;
            lblJumlah.Text = dgvdatadiskon.Rows.Count.ToString();
        }
        private void updatedata_Diskon()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Diskon"]);
        }
        private void koneksi()
        {
            constr = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = Barbershop; Integrated Security = true";
            conn = new SqlConnection(constr);
            conn.Open();
        }


        private void grpTransaksiBaru_Enter(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin Menambahkan Kode Diskon ini ? "+ lblKodeDiskon.Text , "Input Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                loaddata_diskon();
                dr = ds.Tables["Diskon"].Rows.Find(lblKodeDiskon.Text);
                if (dr == null)
                {
                    dr = ds.Tables["Diskon"].NewRow();
                    dr[0] = lblKodeDiskon.Text;
                    dr[1] = txtnamadiskon.Text;
                    dr[2] = txtpotonganharga.Text;
                    dr[3] = DateTime.Now.ToString("dd-MMM-yyyy");
                    ds.Tables["Diskon"].Rows.Add(dr);
                    updatedata_Diskon();
                    MessageBox.Show("Selamat Kode Diskon " + lblKodeDiskon.Text + "Berhasil Dibuat !", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tampilDiskon();
                }
                else
                {
                    MessageBox.Show("Kode Diskon " + lblKodeDiskon.Text + "Telah Tersedia, Mohon Input Dengan Benar !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                kodediskon();
                Hapus();
            }
           
        }

        private void kodediskon()
        {
            Random angka = new Random();
            byte[] angkabyte = new byte[2];

            string a;
            for (int i = 2; i <= 1000; i++)
            {
                a = "KD" + angka.Next();
                lblKodeDiskon.Text = a.Substring(0, 8);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin Mengubah Nama, Dari Kode Diskon ini ? " + lblKodeDiskon.Text, "Ubah Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                loaddata_diskon();
                dr = ds.Tables["Diskon"].Rows.Find(lblKodeDiskon.Text);
                if (dr != null)
                {
                    dr[1] = txtnamadiskon.Text;
                    dr[2] = txtpotonganharga.Text;
                    dr[3] = DateTime.Now.ToString("dd-MMM-yyyy");
                    updatedata_Diskon();
                    MessageBox.Show("Selamat Kode Diskon " + lblKodeDiskon.Text + "Berhasil Diubah !", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tampilDiskon();
                    Hapus();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin Menghapus Kode Diskon ini ? " + lblKodeDiskon.Text, "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                loaddata_diskon();
                dr = ds.Tables["Diskon"].Rows.Find(lblKodeDiskon.Text);
                if (dr != null)
                {
                    dr.Delete();
                    updatedata_Diskon();
                    MessageBox.Show("Hapus Kode Diskon " + lblKodeDiskon.Text + "Berhasil !", "Hapus Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tampilDiskon();
                    Hapus();
                }
            }
        }

        private void dgvDataPelanggan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgvdatadiskon.CurrentCell.RowIndex;
            lblKodeDiskon.Text = dgvdatadiskon.Rows[baris].Cells[0].Value.ToString();
            txtnamadiskon.Text = dgvdatadiskon.Rows[baris].Cells[1].Value.ToString();
            txtpotonganharga.Text =dgvdatadiskon.Rows[baris].Cells[2].Value.ToString();

            btnSimpan.Enabled = false;
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin keluar dari Menu Diskon ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
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
        //----
        int mov;
        int movX;
        int movY;
        //----
        int mov1;
        int movX1;
        int movY1;
        //--0--
        private void label7_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
            mov = 0;
        }
        private void Hapus()
        {
            txtnamadiskon.Clear();
            txtpotonganharga.Clear();
            txtnamadiskon.Focus();

            btnSimpan.Enabled = true;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin Membatalkan pembuatan Kode Diskon ? ", "Batal", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            query = "Select * from Diskon where NamaDiskon LIKE '%" + txtCari.Text + "%'";
            cmd = new SqlCommand(query, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Diskon");
            dc_1pk[0] = ds.Tables["Diskon"].Columns[0];
            ds.Tables["Diskon"].PrimaryKey = dc_1pk;
            tampilDiskon();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtCari.Clear();
            loaddata_diskon();
            tampilDiskon();
        }

        private void FrmDiskon_Load(object sender, EventArgs e)
        {
            kodediskon();
            koneksi();
            loaddata_diskon();
            tampilDiskon();
        }
    }
}
