namespace ArsivOdasıProjesi
{
    partial class DosyaEkle
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
            this.cmb_dosyaodaseç = new System.Windows.Forms.ComboBox();
            this.cmb_dosyabölmseç = new System.Windows.Forms.ComboBox();
            this.cmb_dosyarafseç = new System.Windows.Forms.ComboBox();
            this.cmb_dosyaklasörseç = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_dosyagir = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_menüdön = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_mverigöster = new System.Windows.Forms.Button();
            this.btn_sıfırla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_dosyaodaseç
            // 
            this.cmb_dosyaodaseç.FormattingEnabled = true;
            this.cmb_dosyaodaseç.Location = new System.Drawing.Point(149, 31);
            this.cmb_dosyaodaseç.Name = "cmb_dosyaodaseç";
            this.cmb_dosyaodaseç.Size = new System.Drawing.Size(121, 24);
            this.cmb_dosyaodaseç.TabIndex = 0;
            this.cmb_dosyaodaseç.SelectedIndexChanged += new System.EventHandler(this.cmb_dosyaodaseç_SelectedIndexChanged);
            // 
            // cmb_dosyabölmseç
            // 
            this.cmb_dosyabölmseç.FormattingEnabled = true;
            this.cmb_dosyabölmseç.Location = new System.Drawing.Point(149, 79);
            this.cmb_dosyabölmseç.Name = "cmb_dosyabölmseç";
            this.cmb_dosyabölmseç.Size = new System.Drawing.Size(121, 24);
            this.cmb_dosyabölmseç.TabIndex = 1;
            this.cmb_dosyabölmseç.SelectedIndexChanged += new System.EventHandler(this.cmb_dosyabölmseç_SelectedIndexChanged);
            // 
            // cmb_dosyarafseç
            // 
            this.cmb_dosyarafseç.FormattingEnabled = true;
            this.cmb_dosyarafseç.Location = new System.Drawing.Point(149, 127);
            this.cmb_dosyarafseç.Name = "cmb_dosyarafseç";
            this.cmb_dosyarafseç.Size = new System.Drawing.Size(121, 24);
            this.cmb_dosyarafseç.TabIndex = 2;
            this.cmb_dosyarafseç.SelectedIndexChanged += new System.EventHandler(this.cmb_dosyarafseç_SelectedIndexChanged);
            // 
            // cmb_dosyaklasörseç
            // 
            this.cmb_dosyaklasörseç.FormattingEnabled = true;
            this.cmb_dosyaklasörseç.Location = new System.Drawing.Point(149, 179);
            this.cmb_dosyaklasörseç.Name = "cmb_dosyaklasörseç";
            this.cmb_dosyaklasörseç.Size = new System.Drawing.Size(121, 24);
            this.cmb_dosyaklasörseç.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Chartreuse;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(743, 152);
            this.dataGridView1.TabIndex = 4;
            // 
            // txt_dosyagir
            // 
            this.txt_dosyagir.Location = new System.Drawing.Point(149, 233);
            this.txt_dosyagir.Name = "txt_dosyagir";
            this.txt_dosyagir.Size = new System.Drawing.Size(100, 22);
            this.txt_dosyagir.TabIndex = 5;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Location = new System.Drawing.Point(307, 15);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(121, 49);
            this.btn_kaydet.TabIndex = 11;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Location = new System.Drawing.Point(307, 85);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(121, 42);
            this.btn_sil.TabIndex = 12;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_menüdön
            // 
            this.btn_menüdön.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_menüdön.Location = new System.Drawing.Point(307, 150);
            this.btn_menüdön.Name = "btn_menüdön";
            this.btn_menüdön.Size = new System.Drawing.Size(121, 41);
            this.btn_menüdön.TabIndex = 14;
            this.btn_menüdön.Text = "Menüye Dön";
            this.btn_menüdön.UseVisualStyleBackColor = true;
            this.btn_menüdön.Click += new System.EventHandler(this.btn_menüdön_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Raf Seçin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Bölüm Seçin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Oda Seçin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(15, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Klasör Seçin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Dosya Giriniz:";
            // 
            // btn_mverigöster
            // 
            this.btn_mverigöster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_mverigöster.Location = new System.Drawing.Point(483, 13);
            this.btn_mverigöster.Name = "btn_mverigöster";
            this.btn_mverigöster.Size = new System.Drawing.Size(108, 52);
            this.btn_mverigöster.TabIndex = 20;
            this.btn_mverigöster.Text = "Veri Göster";
            this.btn_mverigöster.UseVisualStyleBackColor = true;
            this.btn_mverigöster.Click += new System.EventHandler(this.btn_mverigöster_Click);
            // 
            // btn_sıfırla
            // 
            this.btn_sıfırla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sıfırla.Location = new System.Drawing.Point(483, 85);
            this.btn_sıfırla.Name = "btn_sıfırla";
            this.btn_sıfırla.Size = new System.Drawing.Size(108, 33);
            this.btn_sıfırla.TabIndex = 21;
            this.btn_sıfırla.Text = "Sıfırla";
            this.btn_sıfırla.UseVisualStyleBackColor = true;
            this.btn_sıfırla.Click += new System.EventHandler(this.btn_sıfırla_Click);
            // 
            // DosyaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(756, 452);
            this.Controls.Add(this.btn_sıfırla);
            this.Controls.Add(this.btn_mverigöster);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_menüdön);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txt_dosyagir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmb_dosyaklasörseç);
            this.Controls.Add(this.cmb_dosyarafseç);
            this.Controls.Add(this.cmb_dosyabölmseç);
            this.Controls.Add(this.cmb_dosyaodaseç);
            this.Name = "DosyaEkle";
            this.Text = "DosyaEkle";
            this.Load += new System.EventHandler(this.DosyaEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_dosyaodaseç;
        private System.Windows.Forms.ComboBox cmb_dosyabölmseç;
        private System.Windows.Forms.ComboBox cmb_dosyarafseç;
        private System.Windows.Forms.ComboBox cmb_dosyaklasörseç;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_dosyagir;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_menüdön;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_mverigöster;
        private System.Windows.Forms.Button btn_sıfırla;
    }
}