using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Barbershop
{
    public partial class frmStruk : Form
    {
        public frmStruk()
        {
            InitializeComponent();
        }
        Beranda.frmPenjualan jual;
        public frmStruk(Beranda.frmPenjualan jual)
        {
            InitializeComponent();
            this.jual = jual;
        }


        private void frmStruk_Load(object sender, EventArgs e)
        {
            lblstruk.Text += new string('=', 44) + "\n";
            lblstruk.Text += new string(' ',18) + "BARBERSHOP" + "\n";
            lblstruk.Text += new string(' ', 14) + "Jln Thamrin No 10" + "\n";
            lblstruk.Text += new string(' ', 15) + "No.Hp : +21 4455" + "\n";
            lblstruk.Text += new string('=', 44) + "\n";
            lblstruk.Text += "Kode Pembayaran   : " + jual.lblNoPembayaran.Text + "\n";
            lblstruk.Text += "Tanggal Transaksi : " + DateTime.Now.ToString("dd-MMM-yyyy") + "\n";
            lblstruk.Text += "ID Kasir          : " + jual.lblUserID.Text + "\n";
            lblstruk.Text += new string('-',44) + "\n";
            lblstruk.Text += "No Pesanan        : " + jual.txtNoPesanan.Text + "\n";
            lblstruk.Text += "Pelanggan         : " + jual.lblNama.Text + "\n";
            lblstruk.Text += new string('-', 44) + "\n";
            lblstruk.Text += "Banyak Pesanan    : " + jual.lblbanyakdata.Text + "\n";
            lblstruk.Text += "Jumlah Biaya      : " + jual.lbltotalhargabayar.Text + "\n";
            lblstruk.Text += "Jumlah Uang       : " + jual.txtJumlahPembayaran.Text + "\n";
            lblstruk.Text += "Metode Bayar      : " + jual.lblMetode.Text + "("+jual.txtmetodebayar.Text +")"  + "\n";
            lblstruk.Text += "Pajak(5%)         : " + jual.lblPajak.Text + "\n";
            lblstruk.Text += "Diskon            : " + jual.txtKodediskon.Text +"("+jual.diskon.ToString("Rp#,##0")+")" + "\n";
            lblstruk.Text += new string('-', 44) + "\n";
            lblstruk.Text += "Total Pembayaran  : " + jual.txtTotalPembayaran.Text + "\n";
            lblstruk.Text += "Kembalian         : " + jual.lblKembalian.Text + "\n";
            lblstruk.Text += new string('-', 44) + "\n";
            lblstruk.Text += new string(' ', 17) + "Terima Kasih" + "\n";
            lblstruk.Text += new string(' ', 15) + "Have A Nice Day" + "\n";
            lblstruk.Text += new string(' ', 11) + "Semoga Berjumpa Kembali" + "\n";
            lblstruk.Text += new string('=', 44) + "\n";
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew)) 
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(lblstruk.Text);
                }
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            jual.btnBersih.Enabled = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream mystream;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                string text = File.ReadAllText(openFileDialog.FileName);
                lblstruk.Text = text;
            }
        }
    }
}
