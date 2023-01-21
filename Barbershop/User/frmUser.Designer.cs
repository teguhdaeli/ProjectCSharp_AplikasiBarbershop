
namespace Barbershop.User
{
    partial class frmUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.btnHapus = new System.Windows.Forms.Button();
            this.lblKodeUser = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBottom = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.dgvDataUser = new System.Windows.Forms.DataGridView();
            this.grpTransaksiBaru = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblexit = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataUser)).BeginInit();
            this.grpTransaksiBaru.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHapus
            // 
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnHapus.Location = new System.Drawing.Point(166, 122);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(60, 31);
            this.btnHapus.TabIndex = 74;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // lblKodeUser
            // 
            this.lblKodeUser.BackColor = System.Drawing.Color.Gainsboro;
            this.lblKodeUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKodeUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblKodeUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKodeUser.Location = new System.Drawing.Point(139, 17);
            this.lblKodeUser.Name = "lblKodeUser";
            this.lblKodeUser.Size = new System.Drawing.Size(153, 24);
            this.lblKodeUser.TabIndex = 73;
            this.lblKodeUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBatal
            // 
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.ForeColor = System.Drawing.Color.DimGray;
            this.btnBatal.Location = new System.Drawing.Point(232, 122);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(60, 31);
            this.btnBatal.TabIndex = 72;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbah.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnUbah.Location = new System.Drawing.Point(100, 122);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(60, 31);
            this.btnUbah.TabIndex = 65;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.Crimson;
            this.btnSimpan.Location = new System.Drawing.Point(26, 122);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(67, 31);
            this.btnSimpan.TabIndex = 66;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Red;
            this.txtPassword.Location = new System.Drawing.Point(139, 76);
            this.txtPassword.MaxLength = 0;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(153, 25);
            this.txtPassword.TabIndex = 71;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtnama
            // 
            this.txtnama.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnama.ForeColor = System.Drawing.Color.Red;
            this.txtnama.Location = new System.Drawing.Point(139, 47);
            this.txtnama.MaxLength = 0;
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(153, 25);
            this.txtnama.TabIndex = 70;
            this.txtnama.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "ID User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password";
            // 
            // lblJumlah
            // 
            this.lblJumlah.BackColor = System.Drawing.Color.Gainsboro;
            this.lblJumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJumlah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblJumlah.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlah.Location = new System.Drawing.Point(36, 256);
            this.lblJumlah.MaximumSize = new System.Drawing.Size(54, 23);
            this.lblJumlah.MinimumSize = new System.Drawing.Size(54, 23);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(54, 23);
            this.lblJumlah.TabIndex = 66;
            this.lblJumlah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nama";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(476, 70);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(303, 25);
            this.label2.TabIndex = 72;
            this.label2.Text = "User Login";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBottom
            // 
            this.lblBottom.BackColor = System.Drawing.Color.DimGray;
            this.lblBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblBottom.Location = new System.Drawing.Point(0, 301);
            this.lblBottom.Name = "lblBottom";
            this.lblBottom.Size = new System.Drawing.Size(800, 31);
            this.lblBottom.TabIndex = 70;
            // 
            // txtCari
            // 
            this.txtCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCari.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCari.Location = new System.Drawing.Point(21, 17);
            this.txtCari.Multiline = true;
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(345, 24);
            this.txtCari.TabIndex = 31;
            // 
            // dgvDataUser
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDataUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataUser.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataUser.Location = new System.Drawing.Point(21, 47);
            this.dgvDataUser.Name = "dgvDataUser";
            this.dgvDataUser.Size = new System.Drawing.Size(427, 143);
            this.dgvDataUser.TabIndex = 0;
            this.dgvDataUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataUser_CellContentClick);
            // 
            // grpTransaksiBaru
            // 
            this.grpTransaksiBaru.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpTransaksiBaru.Controls.Add(this.btnHapus);
            this.grpTransaksiBaru.Controls.Add(this.lblKodeUser);
            this.grpTransaksiBaru.Controls.Add(this.btnBatal);
            this.grpTransaksiBaru.Controls.Add(this.btnUbah);
            this.grpTransaksiBaru.Controls.Add(this.btnSimpan);
            this.grpTransaksiBaru.Controls.Add(this.txtPassword);
            this.grpTransaksiBaru.Controls.Add(this.label5);
            this.grpTransaksiBaru.Controls.Add(this.txtnama);
            this.grpTransaksiBaru.Controls.Add(this.label3);
            this.grpTransaksiBaru.Controls.Add(this.label4);
            this.grpTransaksiBaru.Controls.Add(this.label6);
            this.grpTransaksiBaru.Location = new System.Drawing.Point(477, 87);
            this.grpTransaksiBaru.Name = "grpTransaksiBaru";
            this.grpTransaksiBaru.Size = new System.Drawing.Size(302, 166);
            this.grpTransaksiBaru.TabIndex = 71;
            this.grpTransaksiBaru.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(11, 108);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(283, 2);
            this.label5.TabIndex = 65;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "searchmagnifierinterfacesymbol1_79893.png");
            this.imageList1.Images.SetKeyName(1, "twocirclingarrows1_120592.png");
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(14, 42);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(765, 25);
            this.label1.TabIndex = 69;
            this.label1.Text = "Data User Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnCari);
            this.groupBox1.Controls.Add(this.txtCari);
            this.groupBox1.Controls.Add(this.dgvDataUser);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 196);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.PeachPuff;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRefresh.ImageKey = "twocirclingarrows1_120592.png";
            this.btnRefresh.ImageList = this.imageList1;
            this.btnRefresh.Location = new System.Drawing.Point(413, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(35, 31);
            this.btnRefresh.TabIndex = 58;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.MintCream;
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCari.ImageKey = "searchmagnifierinterfacesymbol1_79893.png";
            this.btnCari.ImageList = this.imageList1;
            this.btnCari.Location = new System.Drawing.Point(372, 13);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(35, 31);
            this.btnCari.TabIndex = 57;
            this.btnCari.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(800, 36);
            this.label7.TabIndex = 65;
            this.label7.Text = "Menu User";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblexit
            // 
            this.lblexit.BackColor = System.Drawing.Color.OrangeRed;
            this.lblexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblexit.Location = new System.Drawing.Point(750, 2);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(37, 31);
            this.lblexit.TabIndex = 67;
            this.lblexit.Text = "X";
            this.lblexit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.OrangeRed;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(760, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 31);
            this.label8.TabIndex = 73;
            this.label8.Text = "X";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 332);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblJumlah);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBottom);
            this.Controls.Add(this.grpTransaksiBaru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblexit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(800, 332);
            this.MinimumSize = new System.Drawing.Size(800, 332);
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUser";
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataUser)).EndInit();
            this.grpTransaksiBaru.ResumeLayout(false);
            this.grpTransaksiBaru.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnHapus;
        public System.Windows.Forms.Label lblKodeUser;
        public System.Windows.Forms.Button btnBatal;
        public System.Windows.Forms.Button btnUbah;
        public System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtnama;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblJumlah;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblBottom;
        public System.Windows.Forms.TextBox txtCari;
        public System.Windows.Forms.DataGridView dgvDataUser;
        public System.Windows.Forms.GroupBox grpTransaksiBaru;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnCari;
        public System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblexit;
        public System.Windows.Forms.Label label8;
    }
}