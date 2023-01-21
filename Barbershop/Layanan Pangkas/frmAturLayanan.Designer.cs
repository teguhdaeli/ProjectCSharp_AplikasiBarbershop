
namespace Barbershop.Produk___Layanan_Pangkas
{
    partial class frmAturLayanan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAturLayanan));
            this.lblAtas = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoNonaktif = new System.Windows.Forms.RadioButton();
            this.rdoAktif = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHapusData = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamaLayanan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnoLayanan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.lblBottom = new System.Windows.Forms.Label();
            this.lblexit = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvTampilLayanan = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTampilLayanan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAtas
            // 
            this.lblAtas.BackColor = System.Drawing.Color.CadetBlue;
            this.lblAtas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAtas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAtas.Font = new System.Drawing.Font("Segoe UI Historic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtas.ForeColor = System.Drawing.Color.White;
            this.lblAtas.Location = new System.Drawing.Point(0, 0);
            this.lblAtas.Name = "lblAtas";
            this.lblAtas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblAtas.Size = new System.Drawing.Size(751, 36);
            this.lblAtas.TabIndex = 15;
            this.lblAtas.Text = "Menu Layanan";
            this.lblAtas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoNonaktif);
            this.groupBox1.Controls.Add(this.rdoAktif);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnHapusData);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnUbah);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtHarga);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNamaLayanan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtnoLayanan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(367, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 176);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // rdoNonaktif
            // 
            this.rdoNonaktif.AutoSize = true;
            this.rdoNonaktif.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNonaktif.Location = new System.Drawing.Point(207, 101);
            this.rdoNonaktif.Name = "rdoNonaktif";
            this.rdoNonaktif.Size = new System.Drawing.Size(80, 21);
            this.rdoNonaktif.TabIndex = 53;
            this.rdoNonaktif.TabStop = true;
            this.rdoNonaktif.Text = "Non Aktif";
            this.rdoNonaktif.UseVisualStyleBackColor = true;
            // 
            // rdoAktif
            // 
            this.rdoAktif.AutoSize = true;
            this.rdoAktif.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAktif.Location = new System.Drawing.Point(150, 101);
            this.rdoAktif.Name = "rdoAktif";
            this.rdoAktif.Size = new System.Drawing.Size(51, 21);
            this.rdoAktif.TabIndex = 52;
            this.rdoAktif.TabStop = true;
            this.rdoAktif.Text = "Aktif";
            this.rdoAktif.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "Status Layanan";
            // 
            // btnHapusData
            // 
            this.btnHapusData.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnHapusData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapusData.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHapusData.ImageKey = "delete_4219 (1).png";
            this.btnHapusData.ImageList = this.imageList1;
            this.btnHapusData.Location = new System.Drawing.Point(73, 136);
            this.btnHapusData.Name = "btnHapusData";
            this.btnHapusData.Size = new System.Drawing.Size(38, 35);
            this.btnHapusData.TabIndex = 49;
            this.btnHapusData.UseVisualStyleBackColor = false;
            this.btnHapusData.Click += new System.EventHandler(this.btnHapusData_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "list_add_icon_124932.png");
            this.imageList1.Images.SetKeyName(1, "1486504346-cancel-close-delete-exit-remove-x_81304.png");
            this.imageList1.Images.SetKeyName(2, "refresh_icon-icons.com_69964.png");
            this.imageList1.Images.SetKeyName(3, "delete_4219 (1).png");
            this.imageList1.Images.SetKeyName(4, "cancel_close_delete_exit_logout_remove_x_icon_123217.png");
            this.imageList1.Images.SetKeyName(5, "pencil-striped-symbol-for-interface-edit-buttons_icon-icons.com_56782.png");
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.MistyRose;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRefresh.ImageKey = "refresh_icon-icons.com_69964.png";
            this.btnRefresh.ImageList = this.imageList1;
            this.btnRefresh.Location = new System.Drawing.Point(117, 136);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(35, 36);
            this.btnRefresh.TabIndex = 50;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.Linen;
            this.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbah.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUbah.ImageKey = "pencil-striped-symbol-for-interface-edit-buttons_icon-icons.com_56782.png";
            this.btnUbah.ImageList = this.imageList1;
            this.btnUbah.Location = new System.Drawing.Point(28, 136);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(38, 35);
            this.btnUbah.TabIndex = 48;
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.TextChanged += new System.EventHandler(this.txtHarga_TextChanged);
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(15, 129);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(337, 1);
            this.label5.TabIndex = 41;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHarga
            // 
            this.txtHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHarga.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHarga.Location = new System.Drawing.Point(150, 71);
            this.txtHarga.MaxLength = 10;
            this.txtHarga.Multiline = true;
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(184, 24);
            this.txtHarga.TabIndex = 40;
            this.txtHarga.TextChanged += new System.EventHandler(this.txtHarga_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Harga Layanan";
            // 
            // txtNamaLayanan
            // 
            this.txtNamaLayanan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamaLayanan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaLayanan.Location = new System.Drawing.Point(150, 41);
            this.txtNamaLayanan.MaxLength = 50;
            this.txtNamaLayanan.Multiline = true;
            this.txtNamaLayanan.Name = "txtNamaLayanan";
            this.txtNamaLayanan.Size = new System.Drawing.Size(184, 24);
            this.txtNamaLayanan.TabIndex = 38;
            this.txtNamaLayanan.TextChanged += new System.EventHandler(this.txtHarga_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nama Layanan";
            // 
            // txtnoLayanan
            // 
            this.txtnoLayanan.BackColor = System.Drawing.Color.Gainsboro;
            this.txtnoLayanan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnoLayanan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnoLayanan.Location = new System.Drawing.Point(150, 12);
            this.txtnoLayanan.MaxLength = 9;
            this.txtnoLayanan.Multiline = true;
            this.txtnoLayanan.Name = "txtnoLayanan";
            this.txtnoLayanan.ReadOnly = true;
            this.txtnoLayanan.Size = new System.Drawing.Size(136, 24);
            this.txtnoLayanan.TabIndex = 36;
            this.txtnoLayanan.TextChanged += new System.EventHandler(this.txtHarga_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(27, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Kode Layanan";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(31, 49);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(702, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Data Layanan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblJumlah
            // 
            this.lblJumlah.BackColor = System.Drawing.Color.Gainsboro;
            this.lblJumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJumlah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblJumlah.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlah.Location = new System.Drawing.Point(31, 228);
            this.lblJumlah.MaximumSize = new System.Drawing.Size(54, 23);
            this.lblJumlah.MinimumSize = new System.Drawing.Size(54, 23);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(54, 23);
            this.lblJumlah.TabIndex = 49;
            this.lblJumlah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBottom
            // 
            this.lblBottom.BackColor = System.Drawing.Color.DimGray;
            this.lblBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblBottom.Location = new System.Drawing.Point(0, 275);
            this.lblBottom.Name = "lblBottom";
            this.lblBottom.Size = new System.Drawing.Size(751, 31);
            this.lblBottom.TabIndex = 50;
            // 
            // lblexit
            // 
            this.lblexit.BackColor = System.Drawing.Color.OrangeRed;
            this.lblexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblexit.Location = new System.Drawing.Point(712, 3);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(37, 31);
            this.lblexit.TabIndex = 51;
            this.lblexit.Text = "X";
            this.lblexit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DimGray;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Lavender;
            this.label10.Location = new System.Drawing.Point(633, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 20);
            this.label10.TabIndex = 52;
            this.label10.Text = "Edit Layanan";
            // 
            // dgvTampilLayanan
            // 
            this.dgvTampilLayanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTampilLayanan.Location = new System.Drawing.Point(31, 75);
            this.dgvTampilLayanan.Name = "dgvTampilLayanan";
            this.dgvTampilLayanan.Size = new System.Drawing.Size(332, 150);
            this.dgvTampilLayanan.TabIndex = 53;
            this.dgvTampilLayanan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTampilLayanan_CellContentClick);
            // 
            // frmAturLayanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 306);
            this.Controls.Add(this.dgvTampilLayanan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblexit);
            this.Controls.Add(this.lblBottom);
            this.Controls.Add(this.lblJumlah);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAtas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(751, 306);
            this.MinimumSize = new System.Drawing.Size(751, 306);
            this.Name = "frmAturLayanan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAturLayanan";
            this.Load += new System.EventHandler(this.frmAturLayanan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTampilLayanan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAtas;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtHarga;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNamaLayanan;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtnoLayanan;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblJumlah;
        public System.Windows.Forms.Label lblBottom;
        public System.Windows.Forms.Label lblexit;
        public System.Windows.Forms.Button btnHapusData;
        public System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.Button btnUbah;
        public System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdoNonaktif;
        private System.Windows.Forms.RadioButton rdoAktif;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvTampilLayanan;
    }
}