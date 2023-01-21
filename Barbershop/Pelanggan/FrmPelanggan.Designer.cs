
namespace Barbershop.Pelanggan
{
    partial class FrmTambahPelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTambahPelanggan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAtas = new System.Windows.Forms.Label();
            this.grpMenuTambah = new System.Windows.Forms.GroupBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.ImlIcon = new System.Windows.Forms.ImageList(this.components);
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNoHp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUmur = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoPelanggan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTampilData = new System.Windows.Forms.DataGridView();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.lblBottom = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblexit = new System.Windows.Forms.Label();
            this.grpMenuTambah.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTampilData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAtas
            // 
            this.lblAtas.BackColor = System.Drawing.Color.DimGray;
            this.lblAtas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAtas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAtas.Font = new System.Drawing.Font("Segoe UI Historic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtas.ForeColor = System.Drawing.Color.White;
            this.lblAtas.Location = new System.Drawing.Point(0, 0);
            this.lblAtas.Name = "lblAtas";
            this.lblAtas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblAtas.Size = new System.Drawing.Size(720, 35);
            this.lblAtas.TabIndex = 15;
            this.lblAtas.Text = "Menu Pelanggan";
            this.lblAtas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpMenuTambah
            // 
            this.grpMenuTambah.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpMenuTambah.Controls.Add(this.btnHapus);
            this.grpMenuTambah.Controls.Add(this.btnBatal);
            this.grpMenuTambah.Controls.Add(this.btnRefresh);
            this.grpMenuTambah.Controls.Add(this.btnSimpan);
            this.grpMenuTambah.Controls.Add(this.label8);
            this.grpMenuTambah.Controls.Add(this.label7);
            this.grpMenuTambah.Controls.Add(this.txtAlamat);
            this.grpMenuTambah.Controls.Add(this.label6);
            this.grpMenuTambah.Controls.Add(this.txtNoHp);
            this.grpMenuTambah.Controls.Add(this.label5);
            this.grpMenuTambah.Controls.Add(this.txtUmur);
            this.grpMenuTambah.Controls.Add(this.label4);
            this.grpMenuTambah.Controls.Add(this.txtNama);
            this.grpMenuTambah.Controls.Add(this.label2);
            this.grpMenuTambah.Controls.Add(this.txtNoPelanggan);
            this.grpMenuTambah.Controls.Add(this.label3);
            this.grpMenuTambah.Location = new System.Drawing.Point(12, 62);
            this.grpMenuTambah.Name = "grpMenuTambah";
            this.grpMenuTambah.Size = new System.Drawing.Size(338, 229);
            this.grpMenuTambah.TabIndex = 16;
            this.grpMenuTambah.TabStop = false;
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHapus.ImageIndex = 2;
            this.btnHapus.ImageList = this.ImlIcon;
            this.btnHapus.Location = new System.Drawing.Point(68, 187);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(38, 35);
            this.btnHapus.TabIndex = 42;
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // ImlIcon
            // 
            this.ImlIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImlIcon.ImageStream")));
            this.ImlIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.ImlIcon.Images.SetKeyName(0, "iconfinder_floppy_285657.png");
            this.ImlIcon.Images.SetKeyName(1, "iconfinder_simpline_21_2305593.png");
            this.ImlIcon.Images.SetKeyName(2, "iconfinder_delete_2199105.png");
            this.ImlIcon.Images.SetKeyName(3, "iconfinder_simpline_15_2305637.png");
            this.ImlIcon.Images.SetKeyName(4, "iconfinder_refresh_3688457.png");
            this.ImlIcon.Images.SetKeyName(5, "refresh_icon-icons.com_69964.png");
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBatal.ImageIndex = 1;
            this.btnBatal.ImageList = this.ImlIcon;
            this.btnBatal.Location = new System.Drawing.Point(114, 187);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(38, 35);
            this.btnBatal.TabIndex = 41;
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.MistyRose;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRefresh.ImageIndex = 4;
            this.btnRefresh.ImageList = this.ImlIcon;
            this.btnRefresh.Location = new System.Drawing.Point(158, 186);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(35, 36);
            this.btnRefresh.TabIndex = 43;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.Linen;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSimpan.ImageIndex = 0;
            this.btnSimpan.ImageList = this.ImlIcon;
            this.btnSimpan.Location = new System.Drawing.Point(23, 187);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(38, 35);
            this.btnSimpan.TabIndex = 40;
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.TextChanged += new System.EventHandler(this.txtNoPelanggan_TextChanged);
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DarkKhaki;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(317, 1);
            this.label8.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(190, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Tahun";
            // 
            // txtAlamat
            // 
            this.txtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlamat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlamat.Location = new System.Drawing.Point(141, 129);
            this.txtAlamat.MaxLength = 50;
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(164, 45);
            this.txtAlamat.TabIndex = 37;
            this.txtAlamat.TextChanged += new System.EventHandler(this.txtNoPelanggan_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Alamat";
            // 
            // txtNoHp
            // 
            this.txtNoHp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoHp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoHp.Location = new System.Drawing.Point(141, 101);
            this.txtNoHp.MaxLength = 12;
            this.txtNoHp.Multiline = true;
            this.txtNoHp.Name = "txtNoHp";
            this.txtNoHp.Size = new System.Drawing.Size(164, 24);
            this.txtNoHp.TabIndex = 35;
            this.txtNoHp.TextChanged += new System.EventHandler(this.txtNoPelanggan_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "No Hp";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtUmur
            // 
            this.txtUmur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUmur.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUmur.Location = new System.Drawing.Point(141, 73);
            this.txtUmur.MaxLength = 5;
            this.txtUmur.Multiline = true;
            this.txtUmur.Name = "txtUmur";
            this.txtUmur.Size = new System.Drawing.Size(43, 24);
            this.txtUmur.TabIndex = 33;
            this.txtUmur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUmur.TextChanged += new System.EventHandler(this.txtNoPelanggan_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Umur";
            // 
            // txtNama
            // 
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(141, 45);
            this.txtNama.MaxLength = 50;
            this.txtNama.Multiline = true;
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(164, 24);
            this.txtNama.TabIndex = 31;
            this.txtNama.TextChanged += new System.EventHandler(this.txtNoPelanggan_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nama Pelanggan";
            // 
            // txtNoPelanggan
            // 
            this.txtNoPelanggan.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNoPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoPelanggan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoPelanggan.Location = new System.Drawing.Point(141, 17);
            this.txtNoPelanggan.MaxLength = 10;
            this.txtNoPelanggan.Multiline = true;
            this.txtNoPelanggan.Name = "txtNoPelanggan";
            this.txtNoPelanggan.ReadOnly = true;
            this.txtNoPelanggan.Size = new System.Drawing.Size(136, 24);
            this.txtNoPelanggan.TabIndex = 29;
            this.txtNoPelanggan.TextChanged += new System.EventHandler(this.txtNoPelanggan_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(24, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "No Pelanggan";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(697, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Data Pelanggan\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvTampilData
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTampilData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTampilData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTampilData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTampilData.Location = new System.Drawing.Point(355, 68);
            this.dgvTampilData.Name = "dgvTampilData";
            this.dgvTampilData.Size = new System.Drawing.Size(353, 197);
            this.dgvTampilData.TabIndex = 29;
            // 
            // lblJumlah
            // 
            this.lblJumlah.BackColor = System.Drawing.Color.Gainsboro;
            this.lblJumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJumlah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblJumlah.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlah.Location = new System.Drawing.Point(355, 267);
            this.lblJumlah.MaximumSize = new System.Drawing.Size(54, 23);
            this.lblJumlah.MinimumSize = new System.Drawing.Size(54, 23);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(54, 23);
            this.lblJumlah.TabIndex = 43;
            this.lblJumlah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBottom
            // 
            this.lblBottom.BackColor = System.Drawing.Color.DimGray;
            this.lblBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblBottom.Location = new System.Drawing.Point(0, 316);
            this.lblBottom.Name = "lblBottom";
            this.lblBottom.Size = new System.Drawing.Size(720, 31);
            this.lblBottom.TabIndex = 44;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.BackColor = System.Drawing.Color.DimGray;
            this.lblUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUserID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUserID.Location = new System.Drawing.Point(55, 320);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(17, 22);
            this.lblUserID.TabIndex = 45;
            this.lblUserID.Text = "-";
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DimGray;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Lavender;
            this.label9.Location = new System.Drawing.Point(8, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "User : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DimGray;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Lavender;
            this.label10.Location = new System.Drawing.Point(580, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 20);
            this.label10.TabIndex = 46;
            this.label10.Text = "Tambah Customer";
            // 
            // lblexit
            // 
            this.lblexit.BackColor = System.Drawing.Color.OrangeRed;
            this.lblexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblexit.Location = new System.Drawing.Point(681, 2);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(37, 31);
            this.lblexit.TabIndex = 47;
            this.lblexit.Text = "X";
            this.lblexit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            // 
            // FrmTambahPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 347);
            this.Controls.Add(this.lblexit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.lblBottom);
            this.Controls.Add(this.lblJumlah);
            this.Controls.Add(this.dgvTampilData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpMenuTambah);
            this.Controls.Add(this.lblAtas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(720, 347);
            this.MinimumSize = new System.Drawing.Size(720, 347);
            this.Name = "FrmTambahPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPelanggan";
            this.Load += new System.EventHandler(this.FrmTambahPelanggan_Load);
            this.grpMenuTambah.ResumeLayout(false);
            this.grpMenuTambah.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTampilData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblAtas;
        public System.Windows.Forms.GroupBox grpMenuTambah;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNoHp;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtUmur;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNama;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtNoPelanggan;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtAlamat;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button btnSimpan;
        public System.Windows.Forms.ImageList ImlIcon;
        public System.Windows.Forms.Button btnHapus;
        public System.Windows.Forms.Button btnBatal;
        public System.Windows.Forms.DataGridView dgvTampilData;
        public System.Windows.Forms.Label lblJumlah;
        public System.Windows.Forms.Label lblBottom;
        public System.Windows.Forms.Label lblUserID;
        public System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblexit;
    }
}