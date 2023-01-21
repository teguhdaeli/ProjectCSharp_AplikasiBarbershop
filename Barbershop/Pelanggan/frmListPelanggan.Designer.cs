
namespace Barbershop.Pelanggan
{
    partial class frmListPelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListPelanggan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAtas = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCari = new System.Windows.Forms.Button();
            this.rdoUmur = new System.Windows.Forms.RadioButton();
            this.rdoNama = new System.Windows.Forms.RadioButton();
            this.rdoID = new System.Windows.Forms.RadioButton();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.dgvDataPelanggan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblBottom = new System.Windows.Forms.Label();
            this.lblexit = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPelanggan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAtas
            // 
            this.lblAtas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAtas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAtas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAtas.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtas.ForeColor = System.Drawing.Color.White;
            this.lblAtas.Location = new System.Drawing.Point(0, 0);
            this.lblAtas.Name = "lblAtas";
            this.lblAtas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblAtas.Size = new System.Drawing.Size(711, 36);
            this.lblAtas.TabIndex = 15;
            this.lblAtas.Text = "Menu Pelanggan";
            this.lblAtas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAtas.Click += new System.EventHandler(this.lblAtas_Click);
            this.lblAtas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblAtas_MouseDown);
            this.lblAtas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblAtas_MouseMove);
            this.lblAtas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblAtas_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblJumlah);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnCari);
            this.groupBox1.Controls.Add(this.rdoUmur);
            this.groupBox1.Controls.Add(this.rdoNama);
            this.groupBox1.Controls.Add(this.rdoID);
            this.groupBox1.Controls.Add(this.txtCari);
            this.groupBox1.Controls.Add(this.dgvDataPelanggan);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 283);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // lblJumlah
            // 
            this.lblJumlah.BackColor = System.Drawing.Color.Gainsboro;
            this.lblJumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJumlah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblJumlah.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlah.Location = new System.Drawing.Point(21, 255);
            this.lblJumlah.MaximumSize = new System.Drawing.Size(54, 23);
            this.lblJumlah.MinimumSize = new System.Drawing.Size(54, 23);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(54, 23);
            this.lblJumlah.TabIndex = 59;
            this.lblJumlah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.PeachPuff;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRefresh.ImageKey = "twocirclingarrows1_120592.png";
            this.btnRefresh.ImageList = this.imageList1;
            this.btnRefresh.Location = new System.Drawing.Point(413, 41);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(35, 31);
            this.btnRefresh.TabIndex = 58;
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
            this.btnCari.Location = new System.Drawing.Point(372, 41);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(35, 31);
            this.btnCari.TabIndex = 57;
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // rdoUmur
            // 
            this.rdoUmur.AutoSize = true;
            this.rdoUmur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoUmur.Location = new System.Drawing.Point(298, 17);
            this.rdoUmur.Name = "rdoUmur";
            this.rdoUmur.Size = new System.Drawing.Size(68, 25);
            this.rdoUmur.TabIndex = 34;
            this.rdoUmur.TabStop = true;
            this.rdoUmur.Text = "Umur";
            this.rdoUmur.UseVisualStyleBackColor = true;
            // 
            // rdoNama
            // 
            this.rdoNama.AutoSize = true;
            this.rdoNama.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNama.Location = new System.Drawing.Point(146, 17);
            this.rdoNama.Name = "rdoNama";
            this.rdoNama.Size = new System.Drawing.Size(146, 25);
            this.rdoNama.TabIndex = 33;
            this.rdoNama.TabStop = true;
            this.rdoNama.Text = "Nama Pelanggan";
            this.rdoNama.UseVisualStyleBackColor = true;
            this.rdoNama.CheckedChanged += new System.EventHandler(this.rdoNama_CheckedChanged);
            // 
            // rdoID
            // 
            this.rdoID.AutoSize = true;
            this.rdoID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoID.Location = new System.Drawing.Point(21, 17);
            this.rdoID.Name = "rdoID";
            this.rdoID.Size = new System.Drawing.Size(119, 25);
            this.rdoID.TabIndex = 32;
            this.rdoID.TabStop = true;
            this.rdoID.Text = "ID Pelanggan";
            this.rdoID.UseVisualStyleBackColor = true;
            // 
            // txtCari
            // 
            this.txtCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCari.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCari.Location = new System.Drawing.Point(21, 45);
            this.txtCari.Multiline = true;
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(345, 24);
            this.txtCari.TabIndex = 31;
            // 
            // dgvDataPelanggan
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDataPelanggan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataPelanggan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataPelanggan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDataPelanggan.Location = new System.Drawing.Point(21, 76);
            this.dgvDataPelanggan.Name = "dgvDataPelanggan";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDataPelanggan.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDataPelanggan.Size = new System.Drawing.Size(650, 174);
            this.dgvDataPelanggan.TabIndex = 0;
            this.dgvDataPelanggan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataPelanggan_CellContentClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(687, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Data Pelanggan\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DimGray;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Lavender;
            this.label10.Location = new System.Drawing.Point(600, 354);
            this.label10.MaximumSize = new System.Drawing.Size(106, 20);
            this.label10.MinimumSize = new System.Drawing.Size(106, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 20);
            this.label10.TabIndex = 55;
            this.label10.Text = "List Customer";
            // 
            // lblBottom
            // 
            this.lblBottom.BackColor = System.Drawing.Color.DimGray;
            this.lblBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblBottom.Location = new System.Drawing.Point(0, 348);
            this.lblBottom.Name = "lblBottom";
            this.lblBottom.Size = new System.Drawing.Size(711, 31);
            this.lblBottom.TabIndex = 54;
            // 
            // lblexit
            // 
            this.lblexit.BackColor = System.Drawing.Color.OrangeRed;
            this.lblexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblexit.Location = new System.Drawing.Point(673, 3);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(37, 31);
            this.lblexit.TabIndex = 56;
            this.lblexit.Text = "X";
            this.lblexit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            // 
            // frmListPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 379);
            this.Controls.Add(this.lblexit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblBottom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAtas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(711, 379);
            this.MinimumSize = new System.Drawing.Size(711, 379);
            this.Name = "frmListPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListPelanggan";
            this.Load += new System.EventHandler(this.frmListPelanggan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPelanggan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCari;
        public System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.Button btnCari;
        public System.Windows.Forms.Label lblJumlah;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label lblBottom;
        public System.Windows.Forms.Label lblAtas;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvDataPelanggan;
        public System.Windows.Forms.RadioButton rdoUmur;
        public System.Windows.Forms.RadioButton rdoNama;
        public System.Windows.Forms.RadioButton rdoID;
        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblexit;
    }
}