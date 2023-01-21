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
    public partial class frmListLayanan : Form
    {
        public frmListLayanan()
        {
            InitializeComponent();
        }
        Beranda.frmPenjualan Penjualan;
        public frmListLayanan(Beranda.frmPenjualan Penjualan)
        {
            InitializeComponent();
            this.Penjualan = Penjualan;
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
            dgvDatalayanan.DataSource = ds.Tables["LayananPangkas"];
            dgvDatalayanan.Columns[0].HeaderText = "Kode Layanan";
            dgvDatalayanan.Columns[1].HeaderText = "Nama Layanan";
            dgvDatalayanan.Columns[2].HeaderText = "Harga Layanan";
            dgvDatalayanan.ReadOnly = true;
            dgvDatalayanan.AllowUserToAddRows = false;
            lblJumlah.Text = dgvDatalayanan.Rows.Count.ToString();
            lblJumlah.Text = dgvDatalayanan.Rows.Count.ToString();
        }

        private void koneksi()
        {
            constr = "Data Source =localhost\\SQLEXPRESS; Initial Catalog = Barbershop; Integrated Security = true";
            conn = new SqlConnection(constr);
            conn.Open();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rdoAktif_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void grpDataLayanan_Enter(object sender, EventArgs e)
        {

        }

        private void frmListLayanan_Load(object sender, EventArgs e)
        {
            koneksi();
            loaddata_Layanan();
            tampilDataLayanan();
            //--

            rdoAktif.Checked = true;
            rdoNonaktif.Checked = false;
            rdoKodeLayanan.Checked = true;
            rdoNamaLayanan.Checked = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loaddata_Layanan();
            tampilDataLayanan();
            txtNamaLayanan.Clear();
            txtNamaLayanan.Focus();
            rdoAktif.Checked = true;
            rdoNonaktif.Checked = false;
            rdoKodeLayanan.Checked = true;
            rdoNamaLayanan.Checked = false;
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            if (rdoAktif.Checked)
            {
                if (rdoKodeLayanan.Checked)
                {
                    query = "Select * from LayananPangkas where KodeLayanan LIKE '%" + txtNamaLayanan.Text + "%' and Status = '1'";
                }
                else if (rdoNamaLayanan.Checked)
                {
                    query = "Select * from LayananPangkas where NamaLayanan LIKE '%" + txtNamaLayanan.Text + "%'  and Status = '1'";
                }
            }
            else if(rdoNonaktif.Checked)
            {
                if (rdoKodeLayanan.Checked)
                {
                    query = "Select * from LayananPangkas where KodeLayanan LIKE '%" + txtNamaLayanan.Text + "%' and Status = '0'";
                }
                else if (rdoNamaLayanan.Checked)
                {
                    query = "Select * from LayananPangkas where NamaLayanan LIKE '%" + txtNamaLayanan.Text + "%'  and Status = '0'";
                }
            }
            cmd = new SqlCommand(query, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "LayananPangkas");
            dc_1pk[0] = ds.Tables["LayananPangkas"].Columns[0];
            ds.Tables["LayananPangkas"].PrimaryKey = dc_1pk;
            tampilDataLayanan();
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin keluar dari Menu Layanan ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

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
        //----
        int mov;
        int movX;
        int movY;
        //----
        int mov1;
        int movX1;
        int movY1;
        //--0--

        private void lblAtas_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
            mov = 0;
        }

        private void dgvDatalayanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgvDatalayanan.CurrentCell.RowIndex;
            Penjualan.lblKodeLayanan.Text = dgvDatalayanan[0, baris].Value.ToString();
            Penjualan.lblKode.Text = dgvDatalayanan[0, baris].Value.ToString();
            Penjualan.lblNamaPesanan.Text = dgvDatalayanan[1, baris].Value.ToString();
            Penjualan.lblHarga.Text = dgvDatalayanan[2, baris].Value.ToString();

            Penjualan.nudJumlah.Maximum = 50;
            Penjualan.nudJumlah.Minimum = 0;
            this.Close();
        }

        private void rdoNonaktif_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
