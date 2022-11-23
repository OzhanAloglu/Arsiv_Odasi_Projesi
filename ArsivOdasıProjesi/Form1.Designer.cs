namespace ArsivOdasıProjesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_kayıtol = new System.Windows.Forms.Button();
            this.btn_giriş = new System.Windows.Forms.Button();
            this.lbl_şifre = new System.Windows.Forms.Label();
            this.lbl_ıd = new System.Windows.Forms.Label();
            this.txt_şifre = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_girişyapyazsı = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 592);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.btn_kayıtol);
            this.panel2.Controls.Add(this.btn_giriş);
            this.panel2.Controls.Add(this.lbl_şifre);
            this.panel2.Controls.Add(this.lbl_ıd);
            this.panel2.Controls.Add(this.txt_şifre);
            this.panel2.Controls.Add(this.txt_ID);
            this.panel2.Controls.Add(this.lbl_girişyapyazsı);
            this.panel2.Location = new System.Drawing.Point(321, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 345);
            this.panel2.TabIndex = 0;
            // 
            // btn_kayıtol
            // 
            this.btn_kayıtol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayıtol.Location = new System.Drawing.Point(190, 257);
            this.btn_kayıtol.Name = "btn_kayıtol";
            this.btn_kayıtol.Size = new System.Drawing.Size(109, 42);
            this.btn_kayıtol.TabIndex = 4;
            this.btn_kayıtol.Text = "Kayıt Ol";
            this.btn_kayıtol.UseVisualStyleBackColor = true;
            this.btn_kayıtol.Click += new System.EventHandler(this.btn_kayıtol_Click);
            // 
            // btn_giriş
            // 
            this.btn_giriş.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giriş.Location = new System.Drawing.Point(42, 257);
            this.btn_giriş.Name = "btn_giriş";
            this.btn_giriş.Size = new System.Drawing.Size(118, 42);
            this.btn_giriş.TabIndex = 4;
            this.btn_giriş.Text = "GİRİŞ";
            this.btn_giriş.UseVisualStyleBackColor = true;
            this.btn_giriş.Click += new System.EventHandler(this.btn_giriş_Click);
            // 
            // lbl_şifre
            // 
            this.lbl_şifre.AutoSize = true;
            this.lbl_şifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_şifre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_şifre.Location = new System.Drawing.Point(24, 187);
            this.lbl_şifre.Name = "lbl_şifre";
            this.lbl_şifre.Size = new System.Drawing.Size(64, 25);
            this.lbl_şifre.TabIndex = 2;
            this.lbl_şifre.Text = "Şifre:";
            // 
            // lbl_ıd
            // 
            this.lbl_ıd.AutoSize = true;
            this.lbl_ıd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ıd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_ıd.Location = new System.Drawing.Point(48, 130);
            this.lbl_ıd.Name = "lbl_ıd";
            this.lbl_ıd.Size = new System.Drawing.Size(40, 25);
            this.lbl_ıd.TabIndex = 2;
            this.lbl_ıd.Text = "ID:";
            // 
            // txt_şifre
            // 
            this.txt_şifre.Location = new System.Drawing.Point(94, 187);
            this.txt_şifre.Multiline = true;
            this.txt_şifre.Name = "txt_şifre";
            this.txt_şifre.PasswordChar = '*';
            this.txt_şifre.Size = new System.Drawing.Size(168, 33);
            this.txt_şifre.TabIndex = 1;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(94, 130);
            this.txt_ID.Multiline = true;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(168, 30);
            this.txt_ID.TabIndex = 1;
            // 
            // lbl_girişyapyazsı
            // 
            this.lbl_girişyapyazsı.AutoSize = true;
            this.lbl_girişyapyazsı.BackColor = System.Drawing.Color.Transparent;
            this.lbl_girişyapyazsı.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_girişyapyazsı.ForeColor = System.Drawing.Color.Azure;
            this.lbl_girişyapyazsı.Location = new System.Drawing.Point(42, 46);
            this.lbl_girişyapyazsı.Name = "lbl_girişyapyazsı";
            this.lbl_girişyapyazsı.Size = new System.Drawing.Size(257, 52);
            this.lbl_girişyapyazsı.TabIndex = 0;
            this.lbl_girişyapyazsı.Text = "GİRİŞ YAP";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(172, 226);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Şifreyi göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(0, 320);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 24);
            this.panel3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tüm Hakları Saklıdır.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 592);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Arşiv Odası Giriş Ekranı";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_şifre;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lbl_girişyapyazsı;
        private System.Windows.Forms.Button btn_kayıtol;
        private System.Windows.Forms.Button btn_giriş;
        private System.Windows.Forms.Label lbl_şifre;
        private System.Windows.Forms.Label lbl_ıd;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}

