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

namespace Barbershop.User
{
    public partial class frmUser : Form
    {
        public frmUser()
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
        private void loaddata_Login()
        {
            ds = new DataSet();
            query = "Select * from Login";
            cmd = new SqlCommand(query, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Login");
            dc_1pk[0] = ds.Tables["Login"].Columns[0];
            ds.Tables["Login"].PrimaryKey = dc_1pk;
        }

        private void tampildataLogin()
        {
            dgvDataUser.DataSource = ds.Tables["Login"];
            dgvDataUser.Columns[0].HeaderText = "Kode User";
            dgvDataUser.Columns[1].HeaderText = "Nama ";
            dgvDataUser.Columns[2].HeaderText = "Password ";
            dgvDataUser.ReadOnly = true;
            dgvDataUser.AllowUserToAddRows = false;
            lblJumlah.Text = dgvDataUser.Rows.Count.ToString();
        }
        private void update_Login()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Login"]);
        }
        private void koneksi()
        {
            constr = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = Barbershop; Integrated Security = true";
            conn = new SqlConnection(constr);
            conn.Open();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin Menambahkan Kode User ini ? " + lblKodeUser.Text, "Input Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                loaddata_Login();
                dr = ds.Tables["Login"].Rows.Find(lblKodeUser.Text);
                if (dr == null)
                {
                    dr = ds.Tables["Login"].NewRow();
                    dr[0] = lblKodeUser.Text;
                    dr[1] = txtnama.Text;
                    dr[2] = txtPassword.Text;
                    dr[3] = DateTime.Now.ToString("dd-MMM-yyyy");
                    ds.Tables["Login"].Rows.Add(dr);
                    update_Login();
                    MessageBox.Show("Selamat User Login " + lblKodeUser.Text + "Berhasil Dibuat !", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tampildataLogin();
                }
                else
                {
                    MessageBox.Show("Kode User " + lblKodeUser.Text + "Telah Tersedia, Mohon Input Dengan Benar !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Hapus();
                kodeuser();
            }
        }
        private void kodeuser()
        {
            Random angka = new Random();
            byte[] angkabyte = new byte[2];

            string a;
            for (int i = 9; i <= 800; i++)
            {
                a = "L" + angka.Next();
                lblKodeUser.Text = a.Substring(0, 7);
            }
        }
        private void Hapus()
        {
            txtnama.Clear();
            txtPassword.Clear();
        }

        private void dgvDataUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgvDataUser.CurrentCell.RowIndex;
            lblKodeUser.Text = dgvDataUser.Rows[baris].Cells[0].Value.ToString();
            txtnama.Text = dgvDataUser.Rows[baris].Cells[1].Value.ToString();
            txtPassword.Text = dgvDataUser.Rows[baris].Cells[2].Value.ToString();

        }

        private void btnUbah_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Apakah anda ingin Mengubah Kode User ini ? " + lblKodeUser.Text, "Ubah Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                loaddata_Login();
                dr = ds.Tables["Login"].Rows.Find(lblKodeUser.Text);
                if (dr != null)
                {
                    dr[1] = txtnama.Text;
                    dr[2] = txtPassword.Text;
                    update_Login();
                    MessageBox.Show("Selamat User Login " + lblKodeUser.Text + "Berhasil Diubah !", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tampildataLogin();
                }
                else
                {
                    MessageBox.Show("Kode User " + lblKodeUser.Text + "Telah Tersedia, Mohon Input Dengan Benar !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Hapus();
                kodeuser();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin Menghapus Kode User ini ? " + lblKodeUser.Text, "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                loaddata_Login();
                dr = ds.Tables["Login"].Rows.Find(lblKodeUser.Text);
                if (dr != null)
                {
                    dr.Delete();
                    update_Login();
                    MessageBox.Show("Selamat User Login " + lblKodeUser.Text + "Berhasil Dihapus !", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tampildataLogin();
                }
                else
                {
                    MessageBox.Show("Kode User " + lblKodeUser.Text + "Telah Tersedia, Mohon Input Dengan Benar !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Hapus();
                kodeuser();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {

        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            koneksi();
            loaddata_Login();
            tampildataLogin();
            kodeuser();


        }
    }
}
