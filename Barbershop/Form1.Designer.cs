namespace Barbershop
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.garisuser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.garispass = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.chkPassword = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblexit = new System.Windows.Forms.Label();
            this.lblwaktu = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblstatuskoneksi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Loading = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.tmLoading = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkpass = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "md_2cecac40734be406d628d87e61211fba.jpg");
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(391, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 305);
            this.label2.TabIndex = 2;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.Snow;
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(448, 193);
            this.txtuser.Multiline = true;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(207, 24);
            this.txtuser.TabIndex = 3;
            this.txtuser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtuser_MouseClick);
            this.txtuser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtuser.MouseLeave += new System.EventHandler(this.txtuser_MouseLeave);
            this.txtuser.MouseHover += new System.EventHandler(this.txtuser_MouseHover);
            // 
            // garisuser
            // 
            this.garisuser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.garisuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.garisuser.Location = new System.Drawing.Point(445, 214);
            this.garisuser.Name = "garisuser";
            this.garisuser.Size = new System.Drawing.Size(214, 2);
            this.garisuser.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 5;
            // 
            // garispass
            // 
            this.garispass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.garispass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.garispass.Location = new System.Drawing.Point(444, 252);
            this.garispass.Name = "garispass";
            this.garispass.Size = new System.Drawing.Size(220, 2);
            this.garispass.TabIndex = 8;
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.Snow;
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(446, 232);
            this.txtpass.Multiline = true;
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(212, 23);
            this.txtpass.TabIndex = 7;
            this.txtpass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtpass.MouseLeave += new System.EventHandler(this.txtpass_MouseLeave);
            this.txtpass.MouseHover += new System.EventHandler(this.txtpass_MouseHover);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Goldenrod;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnlogin.Location = new System.Drawing.Point(582, 266);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(77, 31);
            this.btnlogin.TabIndex = 9;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            this.btnlogin.MouseHover += new System.EventHandler(this.btnlogin_MouseHover);
            this.btnlogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnlogin_MouseMove);
            // 
            // chkPassword
            // 
            this.chkPassword.BackColor = System.Drawing.Color.Snow;
            this.chkPassword.Location = new System.Drawing.Point(669, 233);
            this.chkPassword.Name = "chkPassword";
            this.chkPassword.Size = new System.Drawing.Size(15, 13);
            this.chkPassword.TabIndex = 11;
            this.chkPassword.UseVisualStyleBackColor = false;
            this.chkPassword.CheckedChanged += new System.EventHandler(this.chkPassword_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(704, 38);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(704, 38);
            this.label7.TabIndex = 12;
            this.label7.Text = "Login System Administrator";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label7_MouseDown);
            this.label7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label7_MouseMove);
            this.label7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label7_MouseUp);
            // 
            // lblexit
            // 
            this.lblexit.BackColor = System.Drawing.Color.OrangeRed;
            this.lblexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblexit.Location = new System.Drawing.Point(660, 3);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(40, 31);
            this.lblexit.TabIndex = 13;
            this.lblexit.Text = "X";
            this.lblexit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            // 
            // lblwaktu
            // 
            this.lblwaktu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblwaktu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwaktu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblwaktu.Location = new System.Drawing.Point(495, 364);
            this.lblwaktu.Name = "lblwaktu";
            this.lblwaktu.Size = new System.Drawing.Size(207, 33);
            this.lblwaktu.TabIndex = 14;
            this.lblwaktu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblwaktu.Click += new System.EventHandler(this.lblwaktu_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(8, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Status : ";
            // 
            // lblstatuskoneksi
            // 
            this.lblstatuskoneksi.AutoSize = true;
            this.lblstatuskoneksi.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblstatuskoneksi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatuskoneksi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblstatuskoneksi.Location = new System.Drawing.Point(68, 373);
            this.lblstatuskoneksi.Name = "lblstatuskoneksi";
            this.lblstatuskoneksi.Size = new System.Drawing.Size(13, 17);
            this.lblstatuskoneksi.TabIndex = 16;
            this.lblstatuskoneksi.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Snow;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(510, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 25);
            this.label9.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Snow;
            this.label10.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(481, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 23);
            this.label10.TabIndex = 20;
            this.label10.Text = "Login Admin";
            // 
            // Loading
            // 
            this.Loading.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Loading.Location = new System.Drawing.Point(283, 374);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(132, 18);
            this.Loading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Loading.TabIndex = 23;
            this.Loading.Visible = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label5.Location = new System.Drawing.Point(485, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 3);
            this.label5.TabIndex = 24;
            // 
            // tmLoading
            // 
            this.tmLoading.Tick += new System.EventHandler(this.tmLoading_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Barbershop.Properties.Resources.baru;
            this.pictureBox6.Location = new System.Drawing.Point(430, 54);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(225, 44);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Barbershop.Properties.Resources.noun_password_385803;
            this.pictureBox5.Location = new System.Drawing.Point(409, 229);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 29);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Barbershop.Properties.Resources.noun_username_1121885;
            this.pictureBox4.Location = new System.Drawing.Point(409, 190);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Snow;
            this.pictureBox3.Image = global::Barbershop.Properties.Resources._7c9c7473f072f885ec7774acc6560a47;
            this.pictureBox3.Location = new System.Drawing.Point(581, 81);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(105, 103);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Snow;
            this.pictureBox2.Image = global::Barbershop.Properties.Resources._7c9c7473f072f885ec7774acc6560a47;
            this.pictureBox2.Location = new System.Drawing.Point(397, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Barbershop.Properties.Resources.md_2cecac40734be406d628d87e61211fba;
            this.pictureBox1.Location = new System.Drawing.Point(4, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Peru;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Snow;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.IndianRed;
            this.linkLabel2.Location = new System.Drawing.Point(464, 325);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(168, 18);
            this.linkLabel2.TabIndex = 26;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Hubungi Bantuan Teknis";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkpass
            // 
            this.linkpass.AutoSize = true;
            this.linkpass.BackColor = System.Drawing.Color.Snow;
            this.linkpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkpass.LinkColor = System.Drawing.Color.Black;
            this.linkpass.Location = new System.Drawing.Point(440, 272);
            this.linkpass.Name = "linkpass";
            this.linkpass.Size = new System.Drawing.Size(127, 18);
            this.linkpass.TabIndex = 10;
            this.linkpass.TabStop = true;
            this.linkpass.Text = "Lupa Password ? ";
            this.linkpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.linkpass.MouseLeave += new System.EventHandler(this.linkLabel1_MouseLeave);
            this.linkpass.MouseHover += new System.EventHandler(this.linkLabel1_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(704, 401);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Loading);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblstatuskoneksi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblwaktu);
            this.Controls.Add(this.lblexit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkPassword);
            this.Controls.Add(this.linkpass);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.garispass);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.garisuser);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtuser;
        public System.Windows.Forms.Label garisuser;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label garispass;
        public System.Windows.Forms.TextBox txtpass;
        public System.Windows.Forms.Button btnlogin;
        public System.Windows.Forms.CheckBox chkPassword;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblexit;
        public System.Windows.Forms.Label lblwaktu;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lblstatuskoneksi;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.ProgressBar Loading;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Timer tmLoading;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.PictureBox pictureBox6;
        public System.Windows.Forms.LinkLabel linkLabel2;
        public System.Windows.Forms.LinkLabel linkpass;
    }
}

