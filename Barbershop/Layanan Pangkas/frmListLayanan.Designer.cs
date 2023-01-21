
namespace Barbershop.Produk___Layanan_Pangkas
{
    partial class frmListLayanan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListLayanan));
            this.label1 = new System.Windows.Forms.Label();
            this.lblAtas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpDataLayanan = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoNonaktif = new System.Windows.Forms.RadioButton();
            this.rdoAktif = new System.Windows.Forms.RadioButton();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.dgvDatalayanan = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCari = new System.Windows.Forms.Button();
            this.txtNamaLayanan = new System.Windows.Forms.TextBox();
            this.rdoNamaLayanan = new System.Windows.Forms.RadioButton();
            this.rdoKodeLayanan = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.lblBottom = new System.Windows.Forms.Label();
            this.lblexit = new System.Windows.Forms.Label();
            this.grpDataLayanan.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatalayanan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(23, 46);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(658, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Data Layanan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAtas
            // 
            this.lblAtas.BackColor = System.Drawing.Color.Black;
            this.lblAtas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAtas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAtas.Font = new System.Drawing.Font("Segoe UI Historic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtas.ForeColor = System.Drawing.Color.Transparent;
            this.lblAtas.Location = new System.Drawing.Point(0, 0);
            this.lblAtas.Name = "lblAtas";
            this.lblAtas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblAtas.Size = new System.Drawing.Size(693, 35);
            this.lblAtas.TabIndex = 31;
            this.lblAtas.Text = "Menu Layanan Pangkas";
            this.lblAtas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAtas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblAtas_MouseDown);
            this.lblAtas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblAtas_MouseMove);
            this.lblAtas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblAtas_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(22, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Status Layanan";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // grpDataLayanan
            // 
            this.grpDataLayanan.Controls.Add(this.panel1);
            this.grpDataLayanan.Controls.Add(this.lblJumlah);
            this.grpDataLayanan.Controls.Add(this.dgvDatalayanan);
            this.grpDataLayanan.Controls.Add(this.btnRefresh);
            this.grpDataLayanan.Controls.Add(this.btnCari);
            this.grpDataLayanan.Controls.Add(this.txtNamaLayanan);
            this.grpDataLayanan.Controls.Add(this.rdoNamaLayanan);
            this.grpDataLayanan.Controls.Add(this.label3);
            this.grpDataLayanan.Controls.Add(this.rdoKodeLayanan);
            this.grpDataLayanan.Location = new System.Drawing.Point(23, 67);
            this.grpDataLayanan.Name = "grpDataLayanan";
            this.grpDataLayanan.Size = new System.Drawing.Size(658, 282);
            this.grpDataLayanan.TabIndex = 32;
            this.grpDataLayanan.TabStop = false;
            this.grpDataLayanan.Enter += new System.EventHandler(this.grpDataLayanan_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoNonaktif);
            this.panel1.Controls.Add(this.rdoAktif);
            this.panel1.Location = new System.Drawing.Point(127, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 27);
            this.panel1.TabIndex = 64;
            // 
            // rdoNonaktif
            // 
            this.rdoNonaktif.AutoSize = true;
            this.rdoNonaktif.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNonaktif.Location = new System.Drawing.Point(66, 3);
            this.rdoNonaktif.Name = "rdoNonaktif";
            this.rdoNonaktif.Size = new System.Drawing.Size(80, 21);
            this.rdoNonaktif.TabIndex = 55;
            this.rdoNonaktif.TabStop = true;
            this.rdoNonaktif.Text = "Non Aktif";
            this.rdoNonaktif.UseVisualStyleBackColor = true;
            this.rdoNonaktif.CheckedChanged += new System.EventHandler(this.rdoNonaktif_CheckedChanged);
            // 
            // rdoAktif
            // 
            this.rdoAktif.AutoSize = true;
            this.rdoAktif.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAktif.Location = new System.Drawing.Point(9, 3);
            this.rdoAktif.Name = "rdoAktif";
            this.rdoAktif.Size = new System.Drawing.Size(51, 21);
            this.rdoAktif.TabIndex = 54;
            this.rdoAktif.TabStop = true;
            this.rdoAktif.Text = "Aktif";
            this.rdoAktif.UseVisualStyleBackColor = true;
            this.rdoAktif.CheckedChanged += new System.EventHandler(this.rdoAktif_CheckedChanged);
            // 
            // lblJumlah
            // 
            this.lblJumlah.BackColor = System.Drawing.Color.Gainsboro;
            this.lblJumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJumlah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblJumlah.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlah.Location = new System.Drawing.Point(592, 241);
            this.lblJumlah.MaximumSize = new System.Drawing.Size(54, 23);
            this.lblJumlah.MinimumSize = new System.Drawing.Size(54, 23);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(54, 23);
            this.lblJumlah.TabIndex = 63;
            this.lblJumlah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDatalayanan
            // 
            this.dgvDatalayanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatalayanan.Location = new System.Drawing.Point(22, 64);
            this.dgvDatalayanan.Name = "dgvDatalayanan";
            this.dgvDatalayanan.Size = new System.Drawing.Size(624, 174);
            this.dgvDatalayanan.TabIndex = 62;
            this.dgvDatalayanan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatalayanan_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.PeachPuff;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRefresh.ImageKey = "twocirclingarrows1_120592.png";
            this.btnRefresh.ImageList = this.imageList1;
            this.btnRefresh.Location = new System.Drawing.Point(373, 30);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(35, 31);
            this.btnRefresh.TabIndex = 61;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "searchmagnifierinterfacesymbol1_79893.png");
            this.imageList1.Images.SetKeyName(1, "twocirclingarrows1_120592.png");
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.MintCream;
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCari.ImageKey = "searchmagnifierinterfacesymbol1_79893.png";
            this.btnCari.ImageList = this.imageList1;
            this.btnCari.Location = new System.Drawing.Point(332, 30);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(35, 31);
            this.btnCari.TabIndex = 60;
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // txtNamaLayanan
            // 
            this.txtNamaLayanan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamaLayanan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaLayanan.Location = new System.Drawing.Point(22, 34);
            this.txtNamaLayanan.MaxLength = 50;
            this.txtNamaLayanan.Multiline = true;
            this.txtNamaLayanan.Name = "txtNamaLayanan";
            this.txtNamaLayanan.Size = new System.Drawing.Size(304, 24);
            this.txtNamaLayanan.TabIndex = 59;
            // 
            // rdoNamaLayanan
            // 
            this.rdoNamaLayanan.AutoSize = true;
            this.rdoNamaLayanan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNamaLayanan.Location = new System.Drawing.Point(136, 10);
            this.rdoNamaLayanan.Name = "rdoNamaLayanan";
            this.rdoNamaLayanan.Size = new System.Drawing.Size(112, 21);
            this.rdoNamaLayanan.TabIndex = 58;
            this.rdoNamaLayanan.TabStop = true;
            this.rdoNamaLayanan.Text = "Nama Layanan";
            this.rdoNamaLayanan.UseVisualStyleBackColor = true;
            // 
            // rdoKodeLayanan
            // 
            this.rdoKodeLayanan.AutoSize = true;
            this.rdoKodeLayanan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoKodeLayanan.Location = new System.Drawing.Point(22, 10);
            this.rdoKodeLayanan.Name = "rdoKodeLayanan";
            this.rdoKodeLayanan.Size = new System.Drawing.Size(108, 21);
            this.rdoKodeLayanan.TabIndex = 57;
            this.rdoKodeLayanan.TabStop = true;
            this.rdoKodeLayanan.Text = "Kode Layanan";
            this.rdoKodeLayanan.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DimGray;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Lavender;
            this.label10.Location = new System.Drawing.Point(590, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 51;
            this.label10.Text = "List Layanan";
            // 
            // lblBottom
            // 
            this.lblBottom.BackColor = System.Drawing.Color.DimGray;
            this.lblBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblBottom.Location = new System.Drawing.Point(0, 367);
            this.lblBottom.Name = "lblBottom";
            this.lblBottom.Size = new System.Drawing.Size(693, 31);
            this.lblBottom.TabIndex = 50;
            // 
            // lblexit
            // 
            this.lblexit.BackColor = System.Drawing.Color.OrangeRed;
            this.lblexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblexit.Location = new System.Drawing.Point(654, 2);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(37, 31);
            this.lblexit.TabIndex = 52;
            this.lblexit.Text = "X";
            this.lblexit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            // 
            // frmListLayanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 398);
            this.Controls.Add(this.lblexit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblBottom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAtas);
            this.Controls.Add(this.grpDataLayanan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(693, 398);
            this.MinimumSize = new System.Drawing.Size(693, 398);
            this.Name = "frmListLayanan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListLayanan";
            this.Load += new System.EventHandler(this.frmListLayanan_Load);
            this.grpDataLayanan.ResumeLayout(false);
            this.grpDataLayanan.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatalayanan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblAtas;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.GroupBox grpDataLayanan;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label lblBottom;
        private System.Windows.Forms.RadioButton rdoNonaktif;
        private System.Windows.Forms.RadioButton rdoAktif;
        private System.Windows.Forms.RadioButton rdoNamaLayanan;
        private System.Windows.Forms.RadioButton rdoKodeLayanan;
        public System.Windows.Forms.TextBox txtNamaLayanan;
        public System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Button btnCari;
        public System.Windows.Forms.DataGridView dgvDatalayanan;
        public System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblexit;
    }
}