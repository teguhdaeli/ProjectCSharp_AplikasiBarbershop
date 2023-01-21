
namespace Barbershop.Produk___Layanan_Pangkas
{
    partial class frmTambahLayanan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTambahLayanan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAtas = new System.Windows.Forms.Label();
            this.grpDataLayanan = new System.Windows.Forms.GroupBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamaLayanan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnoLayanan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDataLayanan = new System.Windows.Forms.DataGridView();
            this.lblBottom = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblexit = new System.Windows.Forms.Label();
            this.grpDataLayanan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataLayanan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAtas
            // 
            this.lblAtas.BackColor = System.Drawing.Color.SeaGreen;
            this.lblAtas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAtas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAtas.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtas.ForeColor = System.Drawing.Color.Transparent;
            this.lblAtas.Location = new System.Drawing.Point(0, 0);
            this.lblAtas.Name = "lblAtas";
            this.lblAtas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblAtas.Size = new System.Drawing.Size(749, 35);
            this.lblAtas.TabIndex = 15;
            this.lblAtas.Text = "Menu Layanan Pangkas";
            this.lblAtas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpDataLayanan
            // 
            this.grpDataLayanan.Controls.Add(this.btnHapus);
            this.grpDataLayanan.Controls.Add(this.btnBatal);
            this.grpDataLayanan.Controls.Add(this.btnRefresh);
            this.grpDataLayanan.Controls.Add(this.btnSimpan);
            this.grpDataLayanan.Controls.Add(this.label5);
            this.grpDataLayanan.Controls.Add(this.txtHarga);
            this.grpDataLayanan.Controls.Add(this.label4);
            this.grpDataLayanan.Controls.Add(this.txtNamaLayanan);
            this.grpDataLayanan.Controls.Add(this.label2);
            this.grpDataLayanan.Controls.Add(this.txtnoLayanan);
            this.grpDataLayanan.Controls.Add(this.label3);
            this.grpDataLayanan.Location = new System.Drawing.Point(25, 77);
            this.grpDataLayanan.Name = "grpDataLayanan";
            this.grpDataLayanan.Size = new System.Drawing.Size(367, 172);
            this.grpDataLayanan.TabIndex = 16;
            this.grpDataLayanan.TabStop = false;
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHapus.ImageKey = "delete_4219 (1).png";
            this.btnHapus.ImageList = this.imageList1;
            this.btnHapus.Location = new System.Drawing.Point(81, 112);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(38, 35);
            this.btnHapus.TabIndex = 46;
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
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
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBatal.ImageIndex = 4;
            this.btnBatal.ImageList = this.imageList1;
            this.btnBatal.Location = new System.Drawing.Point(127, 112);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(38, 35);
            this.btnBatal.TabIndex = 45;
            this.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.MistyRose;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRefresh.ImageKey = "refresh_icon-icons.com_69964.png";
            this.btnRefresh.ImageList = this.imageList1;
            this.btnRefresh.Location = new System.Drawing.Point(171, 111);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(35, 36);
            this.btnRefresh.TabIndex = 47;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.Linen;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSimpan.ImageIndex = 0;
            this.btnSimpan.ImageList = this.imageList1;
            this.btnSimpan.Location = new System.Drawing.Point(36, 112);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(38, 35);
            this.btnSimpan.TabIndex = 44;
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.TextChanged += new System.EventHandler(this.btnSimpan_TextChanged);
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(17, 101);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(337, 1);
            this.label5.TabIndex = 31;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHarga
            // 
            this.txtHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHarga.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHarga.Location = new System.Drawing.Point(152, 71);
            this.txtHarga.MaxLength = 10;
            this.txtHarga.Multiline = true;
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(184, 24);
            this.txtHarga.TabIndex = 34;
            this.txtHarga.TextChanged += new System.EventHandler(this.btnSimpan_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Harga Layanan";
            // 
            // txtNamaLayanan
            // 
            this.txtNamaLayanan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamaLayanan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaLayanan.Location = new System.Drawing.Point(152, 41);
            this.txtNamaLayanan.MaxLength = 50;
            this.txtNamaLayanan.Multiline = true;
            this.txtNamaLayanan.Name = "txtNamaLayanan";
            this.txtNamaLayanan.Size = new System.Drawing.Size(184, 24);
            this.txtNamaLayanan.TabIndex = 32;
            this.txtNamaLayanan.TextChanged += new System.EventHandler(this.btnSimpan_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nama Layanan";
            // 
            // txtnoLayanan
            // 
            this.txtnoLayanan.BackColor = System.Drawing.Color.Gainsboro;
            this.txtnoLayanan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnoLayanan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnoLayanan.Location = new System.Drawing.Point(152, 12);
            this.txtnoLayanan.MaxLength = 9;
            this.txtnoLayanan.Multiline = true;
            this.txtnoLayanan.Name = "txtnoLayanan";
            this.txtnoLayanan.ReadOnly = true;
            this.txtnoLayanan.Size = new System.Drawing.Size(136, 24);
            this.txtnoLayanan.TabIndex = 30;
            this.txtnoLayanan.TextChanged += new System.EventHandler(this.btnSimpan_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(29, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Kode Layanan";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(25, 56);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(701, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Data Layanan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvDataLayanan
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDataLayanan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataLayanan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataLayanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataLayanan.Location = new System.Drawing.Point(396, 84);
            this.dgvDataLayanan.Name = "dgvDataLayanan";
            this.dgvDataLayanan.Size = new System.Drawing.Size(330, 165);
            this.dgvDataLayanan.TabIndex = 31;
            this.dgvDataLayanan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataLayanan_CellContentClick);
            // 
            // lblBottom
            // 
            this.lblBottom.BackColor = System.Drawing.Color.DimGray;
            this.lblBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblBottom.Location = new System.Drawing.Point(0, 280);
            this.lblBottom.Name = "lblBottom";
            this.lblBottom.Size = new System.Drawing.Size(749, 31);
            this.lblBottom.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DimGray;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Lavender;
            this.label9.Location = new System.Drawing.Point(9, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "User : ";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.BackColor = System.Drawing.Color.DimGray;
            this.lblUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUserID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUserID.Location = new System.Drawing.Point(56, 285);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(17, 22);
            this.lblUserID.TabIndex = 47;
            this.lblUserID.Text = "-";
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblJumlah
            // 
            this.lblJumlah.BackColor = System.Drawing.Color.Gainsboro;
            this.lblJumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJumlah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblJumlah.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlah.Location = new System.Drawing.Point(672, 253);
            this.lblJumlah.MaximumSize = new System.Drawing.Size(54, 23);
            this.lblJumlah.MinimumSize = new System.Drawing.Size(54, 23);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(54, 23);
            this.lblJumlah.TabIndex = 48;
            this.lblJumlah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblJumlah.Click += new System.EventHandler(this.lblJumlah_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DimGray;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Lavender;
            this.label10.Location = new System.Drawing.Point(614, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 20);
            this.label10.TabIndex = 49;
            this.label10.Text = "Tambah Layanan";
            // 
            // lblexit
            // 
            this.lblexit.BackColor = System.Drawing.Color.OrangeRed;
            this.lblexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblexit.Location = new System.Drawing.Point(710, 2);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(37, 31);
            this.lblexit.TabIndex = 50;
            this.lblexit.Text = "X";
            this.lblexit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            // 
            // frmTambahLayanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 311);
            this.Controls.Add(this.lblexit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblJumlah);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.lblBottom);
            this.Controls.Add(this.dgvDataLayanan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpDataLayanan);
            this.Controls.Add(this.lblAtas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(749, 311);
            this.MinimumSize = new System.Drawing.Size(749, 311);
            this.Name = "frmTambahLayanan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTambahProduk";
            this.Load += new System.EventHandler(this.frmTambahProduk_Load);
            this.grpDataLayanan.ResumeLayout(false);
            this.grpDataLayanan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataLayanan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtHarga;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNamaLayanan;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtnoLayanan;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnHapus;
        public System.Windows.Forms.Button btnBatal;
        public System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.Button btnSimpan;
        public System.Windows.Forms.Label lblBottom;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label lblUserID;
        public System.Windows.Forms.Label lblJumlah;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label lblAtas;
        public System.Windows.Forms.GroupBox grpDataLayanan;
        public System.Windows.Forms.DataGridView dgvDataLayanan;
        public System.Windows.Forms.Label lblexit;
        public System.Windows.Forms.ImageList imageList1;
    }
}