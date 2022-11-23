namespace ArsivOdasıProjesi
{
    partial class KlasörEkle
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
            this.cmb_klasörodaekle = new System.Windows.Forms.ComboBox();
            this.cmb_klasörblmekle = new System.Windows.Forms.ComboBox();
            this.cmb_bölmrafekle = new System.Windows.Forms.ComboBox();
            this.txt_Klasörgirin = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_kydet = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_verigöster = new System.Windows.Forms.Button();
            this.btn_menğüdön = new System.Windows.Forms.Button();
            this.txt_klasörsil = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_klasörodaekle
            // 
            this.cmb_klasörodaekle.FormattingEnabled = true;
            this.cmb_klasörodaekle.Location = new System.Drawing.Point(141, 17);
            this.cmb_klasörodaekle.Name = "cmb_klasörodaekle";
            this.cmb_klasörodaekle.Size = new System.Drawing.Size(121, 24);
            this.cmb_klasörodaekle.TabIndex = 0;
            this.cmb_klasörodaekle.SelectedIndexChanged += new System.EventHandler(this.cmb_klasörodaekle_SelectedIndexChanged);
            // 
            // cmb_klasörblmekle
            // 
            this.cmb_klasörblmekle.FormattingEnabled = true;
            this.cmb_klasörblmekle.Location = new System.Drawing.Point(141, 69);
            this.cmb_klasörblmekle.Name = "cmb_klasörblmekle";
            this.cmb_klasörblmekle.Size = new System.Drawing.Size(121, 24);
            this.cmb_klasörblmekle.TabIndex = 1;
            this.cmb_klasörblmekle.SelectedIndexChanged += new System.EventHandler(this.cmb_klasörblmekle_SelectedIndexChanged);
            // 
            // cmb_bölmrafekle
            // 
            this.cmb_bölmrafekle.FormattingEnabled = true;
            this.cmb_bölmrafekle.Location = new System.Drawing.Point(141, 121);
            this.cmb_bölmrafekle.Name = "cmb_bölmrafekle";
            this.cmb_bölmrafekle.Size = new System.Drawing.Size(121, 24);
            this.cmb_bölmrafekle.TabIndex = 2;
            // 
            // txt_Klasörgirin
            // 
            this.txt_Klasörgirin.Location = new System.Drawing.Point(141, 177);
            this.txt_Klasörgirin.Name = "txt_Klasörgirin";
            this.txt_Klasörgirin.Size = new System.Drawing.Size(100, 22);
            this.txt_Klasörgirin.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LawnGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(778, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Oda Seçin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bölüm Seçin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Raf Seçin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Klasör Girin:";
            // 
            // btn_kydet
            // 
            this.btn_kydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kydet.Location = new System.Drawing.Point(15, 231);
            this.btn_kydet.Name = "btn_kydet";
            this.btn_kydet.Size = new System.Drawing.Size(118, 44);
            this.btn_kydet.TabIndex = 9;
            this.btn_kydet.Text = "Kaydet";
            this.btn_kydet.UseVisualStyleBackColor = true;
            this.btn_kydet.Click += new System.EventHandler(this.btn_kydet_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Location = new System.Drawing.Point(532, 55);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(108, 35);
            this.btn_sil.TabIndex = 10;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_verigöster
            // 
            this.btn_verigöster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_verigöster.Location = new System.Drawing.Point(152, 231);
            this.btn_verigöster.Name = "btn_verigöster";
            this.btn_verigöster.Size = new System.Drawing.Size(146, 47);
            this.btn_verigöster.TabIndex = 12;
            this.btn_verigöster.Text = "Veri Göster";
            this.btn_verigöster.UseVisualStyleBackColor = true;
            this.btn_verigöster.Click += new System.EventHandler(this.btn_verigöster_Click);
            // 
            // btn_menğüdön
            // 
            this.btn_menğüdön.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_menğüdön.Location = new System.Drawing.Point(321, 230);
            this.btn_menğüdön.Name = "btn_menğüdön";
            this.btn_menğüdön.Size = new System.Drawing.Size(159, 52);
            this.btn_menğüdön.TabIndex = 13;
            this.btn_menğüdön.Text = "Menüye Dön";
            this.btn_menğüdön.UseVisualStyleBackColor = true;
            this.btn_menğüdön.Click += new System.EventHandler(this.btn_menğüdön_Click);
            // 
            // txt_klasörsil
            // 
            this.txt_klasörsil.Location = new System.Drawing.Point(532, 18);
            this.txt_klasörsil.Multiline = true;
            this.txt_klasörsil.Name = "txt_klasörsil";
            this.txt_klasörsil.Size = new System.Drawing.Size(108, 31);
            this.txt_klasörsil.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(302, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Silmek istediğiniz Klasör:";
            // 
            // KlasörEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_klasörsil);
            this.Controls.Add(this.btn_menğüdön);
            this.Controls.Add(this.btn_verigöster);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_kydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_Klasörgirin);
            this.Controls.Add(this.cmb_bölmrafekle);
            this.Controls.Add(this.cmb_klasörblmekle);
            this.Controls.Add(this.cmb_klasörodaekle);
            this.Name = "KlasörEkle";
            this.Text = "KlasörEkle";
            this.Load += new System.EventHandler(this.KlasörEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_klasörodaekle;
        private System.Windows.Forms.ComboBox cmb_klasörblmekle;
        private System.Windows.Forms.ComboBox cmb_bölmrafekle;
        private System.Windows.Forms.TextBox txt_Klasörgirin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_kydet;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_verigöster;
        private System.Windows.Forms.Button btn_menğüdön;
        private System.Windows.Forms.TextBox txt_klasörsil;
        private System.Windows.Forms.Label label5;
    }
}