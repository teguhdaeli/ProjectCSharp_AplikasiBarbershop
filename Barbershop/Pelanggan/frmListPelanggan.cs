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
    public partial class frmListPelanggan : Form
    {
        public frmListPelanggan()
        {
            InitializeComponent();
        }

        Beranda.frmPenjualan beranda;
        public frmListPelanggan(Beranda.frmPenjualan beranda)
        {
            InitializeComponent();
            this.beranda = beranda;
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
            dgvDataPelanggan.DataSource = ds.Tables["Pelanggan"];
            dgvDataPelanggan.Columns[0].HeaderText = "No Pelanggan";
            dgvDataPelanggan.Columns[1].HeaderText = "Nama";
            dgvDataPelanggan.Columns[2].HeaderText = "Umur";
            dgvDataPelanggan.Columns[3].HeaderText = "Alamat";
            dgvDataPelanggan.Columns[4].HeaderText = "No Hp";
            dgvDataPelanggan.Columns[5].HeaderText = "Tanggal Bergabung";
            dgvDataPelanggan.ReadOnly = true;
            dgvDataPelanggan.AllowUserToAddRows = false;
            lblJumlah.Text = dgvDataPelanggan.Rows.Count.ToString();
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

        private void btnCari_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            if (rdoID.Checked)
            {
                query = "Select * from Pelanggan where IdPelanggan LIKE '%" + txtCari.Text + "%'";
            }
            else if (rdoNama.Checked)
            {
                query = "Select * from Pelanggan where Nama LIKE '%" + txtCari.Text + "%'";
            }
            else if (rdoUmur.Checked)
            {
                query = "Select * from Pelanggan where Umur LIKE '%" + txtCari.Text + "%'";
            }
            else
            {
                MessageBox.Show("Mohon Pilih Salah Satu Pencarian Di Atas !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cmd = new SqlCommand(query, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Pelanggan");
            dc_1pk[0] = ds.Tables["Pelanggan"].Columns[0];
            ds.Tables["Pelanggan"].PrimaryKey = dc_1pk;
            tampilDataPelanggan();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loaddata_Pelanggan();
            tampilDataPelanggan();
            txtCari.Clear();
            txtCari.Focus();

            rdoID.Checked = false;
            rdoNama.Checked = false;
            rdoUmur.Checked = false;

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

        private void lblexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin keluar dari Menu Pelanggan ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvDataPelanggan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgvDataPelanggan.CurrentCell.RowIndex;
            beranda.txtNoPelanggan.Text = dgvDataPelanggan[0,baris].Value.ToString();
            beranda.txtNamaPelanggan.Text = dgvDataPelanggan[1, baris].Value.ToString();
            this.Close();
        }

        private void rdoNama_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblAtas_Click(object sender, EventArgs e)
        {

        }

        private void frmListPelanggan_Load(object sender, EventArgs e)
        {
            koneksi();
            loaddata_Pelanggan();
            tampilDataPelanggan();

            //---
            txtCari.Focus();
        }
    }
}
