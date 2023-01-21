
namespace Barbershop.Produk_Pangkas
{
    partial class frmTambahProduk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTambahProduk));
            this.lblAtas = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHargaProduk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamaProduk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKodeProduk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDataProduk = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblBottom = new System.Windows.Forms.Label();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.lblexit = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataProduk)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAtas
            // 
            this.lblAtas.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblAtas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAtas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAtas.Font = new System.Drawing.Font("Segoe UI Historic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtas.ForeColor = System.Drawing.Color.Transparent;
            this.lblAtas.Location = new System.Drawing.Point(0, 0);
            this.lblAtas.Name = "lblAtas";
            this.lblAtas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblAtas.Size = new System.Drawing.Size(800, 36);
            this.lblAtas.TabIndex = 15;
            this.lblAtas.Text = "Menu Produk";
            this.lblAtas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnHapus);
            this.groupBox1.Controls.Add(this.btnBatal);
            this.groupBox1.Controls.Add(this.btnSimpan);
            this.groupBox1.Controls.Add(this.nudQty);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtHargaProduk);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNamaProduk);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKodeProduk);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(24, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 210);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(300, 1);
            this.label8.TabIndex = 46;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "edit_modify_icon-icons.com_49882.png");
            this.imageList1.Images.SetKeyName(1, "searchmagnifierinterfacesymbol1_79893.png");
            this.imageList1.Images.SetKeyName(2, "delete_4219.png");
            this.imageList1.Images.SetKeyName(3, "text-document-cancel-button_icon-icons.com_71554.png");
            this.imageList1.Images.SetKeyName(4, "twocirclingarrows1_120592.png");
            this.imageList1.Images.SetKeyName(5, "addnewdocument_118445.png");
            this.imageList1.Images.SetKeyName(6, "cancel_close_delete_exit_logout_remove_x_icon_123217.png");
            // 
            // nudQty
            // 
            this.nudQty.Location = new System.Drawing.Point(142, 111);
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(64, 20);
            this.nudQty.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Qty";
            // 
            // txtHargaProduk
            // 
            this.txtHargaProduk.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtHargaProduk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHargaProduk.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHargaProduk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtHargaProduk.Location = new System.Drawing.Point(142, 75);
            this.txtHargaProduk.MaxLength = 8980;
            this.txtHargaProduk.Multiline = true;
            this.txtHargaProduk.Name = "txtHargaProduk";
            this.txtHargaProduk.Size = new System.Drawing.Size(176, 24);
            this.txtHargaProduk.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Harga Produk";
            // 
            // txtNamaProduk
            // 
            this.txtNamaProduk.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNamaProduk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamaProduk.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaProduk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNamaProduk.Location = new System.Drawing.Point(142, 45);
            this.txtNamaProduk.MaxLength = 50;
            this.txtNamaProduk.Multiline = true;
            this.txtNamaProduk.Name = "txtNamaProduk";
            this.txtNamaProduk.Size = new System.Drawing.Size(176, 24);
            this.txtNamaProduk.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nama Produk";
            // 
            // txtKodeProduk
            // 
            this.txtKodeProduk.BackColor = System.Drawing.Color.Gainsboro;
            this.txtKodeProduk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKodeProduk.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKodeProduk.Location = new System.Drawing.Point(142, 14);
            this.txtKodeProduk.MaxLength = 10;
            this.txtKodeProduk.Multiline = true;
            this.txtKodeProduk.Name = "txtKodeProduk";
            this.txtKodeProduk.ReadOnly = true;
            this.txtKodeProduk.Size = new System.Drawing.Size(107, 24);
            this.txtKodeProduk.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(25, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Kode Produk";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(23, 50);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(748, 25);
            this.label1.TabIndex = 52;
            this.label1.Text = "Data Produk";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvDataProduk
            // 
            this.dgvDataProduk.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDataProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataProduk.Location = new System.Drawing.Point(373, 78);
            this.dgvDataProduk.Name = "dgvDataProduk";
            this.dgvDataProduk.Size = new System.Drawing.Size(398, 202);
            this.dgvDataProduk.TabIndex = 53;
            this.dgvDataProduk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataProduk_CellContentClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DimGray;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Lavender;
            this.label11.Location = new System.Drawing.Point(12, 332);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 57;
            this.label11.Text = "User : ";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.BackColor = System.Drawing.Color.DimGray;
            this.lbluser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbluser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbluser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbluser.Location = new System.Drawing.Point(59, 331);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(17, 22);
            this.lbluser.TabIndex = 58;
            this.lbluser.Text = "-";
            this.lbluser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DimGray;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Lavender;
            this.label10.Location = new System.Drawing.Point(674, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 20);
            this.label10.TabIndex = 56;
            this.label10.Text = "Tambah Produk";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // lblBottom
            // 
            this.lblBottom.BackColor = System.Drawing.Color.DimGray;
            this.lblBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblBottom.Location = new System.Drawing.Point(0, 328);
            this.lblBottom.Name = "lblBottom";
            this.lblBottom.Size = new System.Drawing.Size(800, 31);
            this.lblBottom.TabIndex = 55;
            // 
            // lblJumlah
            // 
            this.lblJumlah.BackColor = System.Drawing.Color.Gainsboro;
            this.lblJumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJumlah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblJumlah.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlah.Location = new System.Drawing.Point(717, 283);
            this.lblJumlah.MaximumSize = new System.Drawing.Size(54, 23);
            this.lblJumlah.MinimumSize = new System.Drawing.Size(54, 23);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(54, 23);
            this.lblJumlah.TabIndex = 59;
            this.lblJumlah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblexit
            // 
            this.lblexit.BackColor = System.Drawing.Color.OrangeRed;
            this.lblexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblexit.Location = new System.Drawing.Point(761, 2);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(37, 31);
            this.lblexit.TabIndex = 60;
            this.lblexit.Text = "X";
            this.lblexit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.MistyRose;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRefresh.ImageKey = "twocirclingarrows1_120592.png";
            this.btnRefresh.ImageList = this.imageList1;
            this.btnRefresh.Location = new System.Drawing.Point(161, 146);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(35, 36);
            this.btnRefresh.TabIndex = 51;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Honeydew;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHapus.ImageIndex = 2;
            this.btnHapus.ImageList = this.imageList1;
            this.btnHapus.Location = new System.Drawing.Point(74, 148);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(38, 35);
            this.btnHapus.TabIndex = 45;
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBatal.ImageKey = "cancel_close_delete_exit_logout_remove_x_icon_123217.png";
            this.btnBatal.ImageList = this.imageList1;
            this.btnBatal.Location = new System.Drawing.Point(118, 147);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(38, 35);
            this.btnBatal.TabIndex = 44;
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSimpan.ImageKey = "addnewdocument_118445.png";
            this.btnSimpan.ImageList = this.imageList1;
            this.btnSimpan.Location = new System.Drawing.Point(28, 147);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(39, 35);
            this.btnSimpan.TabIndex = 43;
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // frmTambahProduk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 359);
            this.Controls.Add(this.lblexit);
            this.Controls.Add(this.lblJumlah);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblBottom);
            this.Controls.Add(this.dgvDataProduk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAtas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(800, 359);
            this.MinimumSize = new System.Drawing.Size(800, 359);
            this.Name = "frmTambahProduk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTambahProduk";
            this.Load += new System.EventHandler(this.frmTambahProduk_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataProduk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtHargaProduk;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNamaProduk;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtKodeProduk;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnHapus;
        public System.Windows.Forms.Button btnBatal;
        public System.Windows.Forms.Button btnSimpan;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label lbluser;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label lblBottom;
        public System.Windows.Forms.Label lblJumlah;
        public System.Windows.Forms.Label lblexit;
        public System.Windows.Forms.Label lblAtas;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.NumericUpDown nudQty;
        public System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.DataGridView dgvDataProduk;
        public System.Windows.Forms.Button btnRefresh;
    }
}