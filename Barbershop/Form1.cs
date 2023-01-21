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

namespace Barbershop
{
    public partial class Form1 : Form
    {

        SqlConnection conn;
        string constr, query;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        DataRow dr;
        DataColumn[] dc_1pk = new DataColumn[1];
        SqlCommandBuilder cb;
        string[] cari = new string[2];



        //----
        int mov;
        int movX;
        int movY;
        //----
        int mov1;
        int movX1;
        int movY1;
        //--0--
        public Form1()
        {
            InitializeComponent();
        }
        FrmHome Home;
        public Form1(FrmHome Home)
        {
            InitializeComponent();
            this.Home = Home;

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            koneksi();
            waktu = DateTime.Now;
            lblwaktu.Text = waktu.ToString("dd.MMM.yyyy - hh:mm:ss tt");
            //-
            Loading.Hide();
            //--
            chkPassword.Checked = true;
            txtuser.Focus();
        }
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
        private void koneksi()
        {
            try
            {
                constr = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = Barbershop; Integrated Security = true";
                conn = new SqlConnection(constr);
                conn.Open();
                lblstatuskoneksi.ForeColor = Color.GreenYellow;
                lblstatuskoneksi.Text = "Database Terkoneksi";
            }
            catch
            {
                lblstatuskoneksi.Text = "Koneksi Database Terputus";

            }

        }
        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Silahkan Login terlebih dahulu, Untuk mengakses penukaran kata sandi anda , melalui Menu User !", "Message System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblwaktu_Click(object sender, EventArgs e)
        {

        }
        DateTime waktu;
        private void timer1_Tick(object sender, EventArgs e)
        {
            waktu = DateTime.Now;
            lblwaktu.Text = waktu.ToString("dd.MM.yyyy - hh:mm:ss tt");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin keluar dari Aplikasi ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            loaddata_Login();
            dr = ds.Tables["Login"].Rows.Find(txtuser.Text);
            if (dr != null)
            {
                if (dr[2].ToString() == txtpass.Text)
                {
                    this.tmLoading.Start();
                    Loading.Show();
                 
                    MessageBox.Show("Login Berhasil", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Password Salah !", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpass.Clear();
                    txtpass.Focus();
                }
            }
            else
            {
                MessageBox.Show("User ID Tidak Ditemukan !", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtuser.Clear();
                txtpass.Clear();
                txtuser.Focus();
            }

        }

        private void tmLoading_Tick(object sender, EventArgs e)
        {
            this.Loading.Increment(3);
            if (Loading.Value >= Loading.Maximum)
            {
                tmLoading.Stop();
                FrmHome frm2 = new FrmHome();
                frm2.Show();
                frm2.lblUserID.Text = txtuser.Text;
                this.Hide();
                Loading.Hide();
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

        private void label7_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
            mov = 0;
        }

        private void txtuser_MouseHover(object sender, EventArgs e)
        {
            txtuser.BackColor = Color.Gainsboro;
            txtuser.ForeColor = Color.Red;
        }

        private void txtuser_MouseLeave(object sender, EventArgs e)
        {
            txtuser.BackColor = Color.Snow;
            txtuser.ForeColor = Color.Black;
        }

        private void txtuser_MouseClick(object sender, MouseEventArgs e)
        {
            txtuser.BackColor = Color.PeachPuff;
            txtuser.ForeColor = Color.Green;
        }

        private void txtpass_MouseHover(object sender, EventArgs e)
        {
            txtpass.BackColor = Color.Tan;
            txtpass.ForeColor = Color.White;
        }

        private void txtpass_MouseLeave(object sender, EventArgs e)
        {
            txtpass.BackColor = Color.Snow;
            txtpass.ForeColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov1 == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX1, MousePosition.Y - movY1);
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            mov1 = 0;
            mov1 = 0;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            mov1 = 1;
            movX1 = e.X;
            movY1 = e.Y;
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassword.Checked == true)
            {
                txtpass.UseSystemPasswordChar = false;
                txtpass.PasswordChar = '*';
                txtpass.Focus();
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
                txtpass.Focus();
            }
        }

        private void linkLabel1_MouseHover(object sender, EventArgs e)
        {
            linkpass.LinkColor = Color.Blue;
        }

        private void linkLabel1_MouseLeave(object sender, EventArgs e)
        {
            linkpass.LinkColor = Color.Black;

        }

        private void btnlogin_MouseHover(object sender, EventArgs e)
        {
            btnlogin.BackColor = Color.Red;
        }

        private void btnlogin_MouseMove(object sender, MouseEventArgs e)
        {
            btnlogin.BackColor = Color.Goldenrod;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Silahkan hubungi nomor ini untuk mendapatkan Bantuan Lebih (Yolanda -- 083168867455)", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
