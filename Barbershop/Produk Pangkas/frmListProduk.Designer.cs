
namespace Barbershop.Produk_Pangkas
{
    partial class frmListProduk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListProduk));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.lblBottom = new System.Windows.Forms.Label();
            this.lblexit = new System.Windows.Forms.Label();
            this.lblAtas = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDataProduk = new System.Windows.Forms.DataGridView();
            this.rdoStock = new System.Windows.Forms.RadioButton();
            this.rdoKodeUser = new System.Windows.Forms.RadioButton();
            this.rdoKodeProduk = new System.Windows.Forms.RadioButton();
            this.rdoNama = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.txtCariNama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoNonaktif = new System.Windows.Forms.RadioButton();
            this.rdoAktif = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataProduk)).BeginInit();
            this.SuspendLayout();
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
            this.imageList1.Images.SetKeyName(7, "pencil-striped-symbol-for-interface-edit-buttons_icon-icons.com_56782.png");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DimGray;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Lavender;
            this.label10.Location = new System.Drawing.Point(598, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 20);
            this.label10.TabIndex = 85;
            this.label10.Text = "List Produk";
            // 
            // lblJumlah
            // 
            this.lblJumlah.BackColor = System.Drawing.Color.Gainsboro;
            this.lblJumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJumlah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblJumlah.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlah.Location = new System.Drawing.Point(44, 347);
            this.lblJumlah.MaximumSize = new System.Drawing.Size(54, 23);
            this.lblJumlah.MinimumSize = new System.Drawing.Size(54, 23);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(54, 23);
            this.lblJumlah.TabIndex = 83;
            this.lblJumlah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBottom
            // 
            this.lblBottom.BackColor = System.Drawing.Color.DimGray;
            this.lblBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblBottom.Location = new System.Drawing.Point(0, 382);
            this.lblBottom.Name = "lblBottom";
            this.lblBottom.Size = new System.Drawing.Size(695, 31);
            this.lblBottom.TabIndex = 82;
            // 
            // lblexit
            // 
            this.lblexit.BackColor = System.Drawing.Color.OrangeRed;
            this.lblexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblexit.Location = new System.Drawing.Point(656, 2);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(37, 31);
            this.lblexit.TabIndex = 84;
            this.lblexit.Text = "X";
            this.lblexit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
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
            this.lblAtas.Size = new System.Drawing.Size(695, 36);
            this.lblAtas.TabIndex = 78;
            this.lblAtas.Text = "Menu Produk";
            this.lblAtas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAtas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblAtas_MouseDown);
            this.lblAtas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblAtas_MouseMove);
            this.lblAtas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblAtas_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDataProduk);
            this.groupBox1.Controls.Add(this.rdoStock);
            this.groupBox1.Controls.Add(this.rdoKodeUser);
            this.groupBox1.Controls.Add(this.rdoKodeProduk);
            this.groupBox1.Controls.Add(this.rdoNama);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnCari);
            this.groupBox1.Controls.Add(this.txtCariNama);
            this.groupBox1.Location = new System.Drawing.Point(24, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgvDataProduk
            // 
            this.dgvDataProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataProduk.Location = new System.Drawing.Point(20, 73);
            this.dgvDataProduk.Name = "dgvDataProduk";
            this.dgvDataProduk.Size = new System.Drawing.Size(614, 192);
            this.dgvDataProduk.TabIndex = 104;
            this.dgvDataProduk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataProduk_CellContentClick);
            // 
            // rdoStock
            // 
            this.rdoStock.AutoSize = true;
            this.rdoStock.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoStock.Location = new System.Drawing.Point(334, 16);
            this.rdoStock.Name = "rdoStock";
            this.rdoStock.Size = new System.Drawing.Size(57, 21);
            this.rdoStock.TabIndex = 103;
            this.rdoStock.TabStop = true;
            this.rdoStock.Text = "Stock";
            this.rdoStock.UseVisualStyleBackColor = true;
            this.rdoStock.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdoKodeUser
            // 
            this.rdoKodeUser.AutoSize = true;
            this.rdoKodeUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoKodeUser.Location = new System.Drawing.Point(240, 16);
            this.rdoKodeUser.Name = "rdoKodeUser";
            this.rdoKodeUser.Size = new System.Drawing.Size(88, 21);
            this.rdoKodeUser.TabIndex = 102;
            this.rdoKodeUser.TabStop = true;
            this.rdoKodeUser.Text = "Kode User";
            this.rdoKodeUser.UseVisualStyleBackColor = true;
            // 
            // rdoKodeProduk
            // 
            this.rdoKodeProduk.AutoSize = true;
            this.rdoKodeProduk.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoKodeProduk.Location = new System.Drawing.Point(132, 16);
            this.rdoKodeProduk.Name = "rdoKodeProduk";
            this.rdoKodeProduk.Size = new System.Drawing.Size(102, 21);
            this.rdoKodeProduk.TabIndex = 101;
            this.rdoKodeProduk.TabStop = true;
            this.rdoKodeProduk.Text = "Kode Produk";
            this.rdoKodeProduk.UseVisualStyleBackColor = true;
            // 
            // rdoNama
            // 
            this.rdoNama.AutoSize = true;
            this.rdoNama.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNama.Location = new System.Drawing.Point(20, 16);
            this.rdoNama.Name = "rdoNama";
            this.rdoNama.Size = new System.Drawing.Size(106, 21);
            this.rdoNama.TabIndex = 100;
            this.rdoNama.TabStop = true;
            this.rdoNama.Text = "Nama Produk";
            this.rdoNama.UseVisualStyleBackColor = true;
            this.rdoNama.CheckedChanged += new System.EventHandler(this.rdoNama_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.PeachPuff;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRefresh.ImageKey = "twocirclingarrows1_120592.png";
            this.btnRefresh.ImageList = this.imageList1;
            this.btnRefresh.Location = new System.Drawing.Point(441, 39);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(35, 29);
            this.btnRefresh.TabIndex = 99;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.MintCream;
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCari.ImageIndex = 1;
            this.btnCari.ImageList = this.imageList1;
            this.btnCari.Location = new System.Drawing.Point(397, 39);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(38, 29);
            this.btnCari.TabIndex = 97;
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // txtCariNama
            // 
            this.txtCariNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCariNama.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCariNama.Location = new System.Drawing.Point(20, 43);
            this.txtCariNama.Multiline = true;
            this.txtCariNama.Name = "txtCariNama";
            this.txtCariNama.Size = new System.Drawing.Size(371, 24);
            this.txtCariNama.TabIndex = 98;
            this.txtCariNama.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightYellow;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(25, 51);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(646, 25);
            this.label1.TabIndex = 86;
            this.label1.Text = "Data Produk";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdoNonaktif
            // 
            this.rdoNonaktif.AutoSize = true;
            this.rdoNonaktif.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNonaktif.Location = new System.Drawing.Point(586, 349);
            this.rdoNonaktif.Name = "rdoNonaktif";
            this.rdoNonaktif.Size = new System.Drawing.Size(80, 21);
            this.rdoNonaktif.TabIndex = 103;
            this.rdoNonaktif.TabStop = true;
            this.rdoNonaktif.Text = "Non Aktif";
            this.rdoNonaktif.UseVisualStyleBackColor = true;
            // 
            // rdoAktif
            // 
            this.rdoAktif.AutoSize = true;
            this.rdoAktif.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAktif.Location = new System.Drawing.Point(529, 349);
            this.rdoAktif.Name = "rdoAktif";
            this.rdoAktif.Size = new System.Drawing.Size(51, 21);
            this.rdoAktif.TabIndex = 102;
            this.rdoAktif.TabStop = true;
            this.rdoAktif.Text = "Aktif";
            this.rdoAktif.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(434, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 104;
            this.label3.Text = "Status Produk";
            // 
            // frmListProduk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 413);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdoNonaktif);
            this.Controls.Add(this.rdoAktif);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblJumlah);
            this.Controls.Add(this.lblBottom);
            this.Controls.Add(this.lblexit);
            this.Controls.Add(this.lblAtas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(695, 413);
            this.MinimumSize = new System.Drawing.Size(695, 413);
            this.Name = "frmListProduk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListProduk";
            this.Load += new System.EventHandler(this.frmListProduk_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataProduk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label lblJumlah;
        public System.Windows.Forms.Label lblBottom;
        public System.Windows.Forms.Label lblexit;
        public System.Windows.Forms.Label lblAtas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoStock;
        private System.Windows.Forms.RadioButton rdoKodeUser;
        private System.Windows.Forms.RadioButton rdoKodeProduk;
        private System.Windows.Forms.RadioButton rdoNama;
        public System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.Button btnCari;
        public System.Windows.Forms.TextBox txtCariNama;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoNonaktif;
        private System.Windows.Forms.RadioButton rdoAktif;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dgvDataProduk;
    }
}