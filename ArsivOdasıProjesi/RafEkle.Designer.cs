namespace ArsivOdasıProjesi
{
    partial class RafEkle
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
            this.cmb_odaseçinz = new System.Windows.Forms.ComboBox();
            this.cmb_bölmseçnz = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_rafsil = new System.Windows.Forms.Button();
            this.btn_rafekle = new System.Windows.Forms.Button();
            this.txt_rafgirin = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_verigöstr = new System.Windows.Forms.Button();
            this.btn_menüdönn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_odaseçinz
            // 
            this.cmb_odaseçinz.FormattingEnabled = true;
            this.cmb_odaseçinz.Location = new System.Drawing.Point(145, 21);
            this.cmb_odaseçinz.Name = "cmb_odaseçinz";
            this.cmb_odaseçinz.Size = new System.Drawing.Size(121, 24);
            this.cmb_odaseçinz.TabIndex = 0;
            this.cmb_odaseçinz.SelectedIndexChanged += new System.EventHandler(this.cmb_odaseçinz_SelectedIndexChanged);
            // 
            // cmb_bölmseçnz
            // 
            this.cmb_bölmseçnz.FormattingEnabled = true;
            this.cmb_bölmseçnz.Location = new System.Drawing.Point(145, 74);
            this.cmb_bölmseçnz.Name = "cmb_bölmseçnz";
            this.cmb_bölmseçnz.Size = new System.Drawing.Size(121, 24);
            this.cmb_bölmseçnz.TabIndex = 1;
            this.cmb_bölmseçnz.SelectedIndexChanged += new System.EventHandler(this.btn_bölmseçnz_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Oda Seçin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bölüm Seçin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Raf Girin:";
            // 
            // btn_rafsil
            // 
            this.btn_rafsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_rafsil.Location = new System.Drawing.Point(189, 178);
            this.btn_rafsil.Name = "btn_rafsil";
            this.btn_rafsil.Size = new System.Drawing.Size(160, 53);
            this.btn_rafsil.TabIndex = 6;
            this.btn_rafsil.Text = "Raf Sil";
            this.btn_rafsil.UseVisualStyleBackColor = true;
            this.btn_rafsil.Click += new System.EventHandler(this.btn_rafsil_Click);
            // 
            // btn_rafekle
            // 
            this.btn_rafekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_rafekle.Location = new System.Drawing.Point(18, 177);
            this.btn_rafekle.Name = "btn_rafekle";
            this.btn_rafekle.Size = new System.Drawing.Size(149, 54);
            this.btn_rafekle.TabIndex = 7;
            this.btn_rafekle.Text = "Raf Ekle";
            this.btn_rafekle.UseVisualStyleBackColor = true;
            this.btn_rafekle.Click += new System.EventHandler(this.btn_rafekle_Click);
            // 
            // txt_rafgirin
            // 
            this.txt_rafgirin.Location = new System.Drawing.Point(145, 129);
            this.txt_rafgirin.Name = "txt_rafgirin";
            this.txt_rafgirin.Size = new System.Drawing.Size(121, 22);
            this.txt_rafgirin.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Chartreuse;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(856, 178);
            this.dataGridView1.TabIndex = 10;
            // 
            // btn_verigöstr
            // 
            this.btn_verigöstr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_verigöstr.Location = new System.Drawing.Point(18, 237);
            this.btn_verigöstr.Name = "btn_verigöstr";
            this.btn_verigöstr.Size = new System.Drawing.Size(149, 59);
            this.btn_verigöstr.TabIndex = 11;
            this.btn_verigöstr.Text = "Veri Göster";
            this.btn_verigöstr.UseVisualStyleBackColor = true;
            this.btn_verigöstr.Click += new System.EventHandler(this.btn_verigöstr_Click);
            // 
            // btn_menüdönn
            // 
            this.btn_menüdönn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_menüdönn.Location = new System.Drawing.Point(189, 237);
            this.btn_menüdönn.Name = "btn_menüdönn";
            this.btn_menüdönn.Size = new System.Drawing.Size(160, 59);
            this.btn_menüdönn.TabIndex = 12;
            this.btn_menüdönn.Text = "Menüye Dön";
            this.btn_menüdönn.UseVisualStyleBackColor = true;
            this.btn_menüdönn.Click += new System.EventHandler(this.btn_menüdönn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(285, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "Sıfırla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RafEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(880, 503);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_menüdönn);
            this.Controls.Add(this.btn_verigöstr);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_rafgirin);
            this.Controls.Add(this.btn_rafekle);
            this.Controls.Add(this.btn_rafsil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_bölmseçnz);
            this.Controls.Add(this.cmb_odaseçinz);
            this.Name = "RafEkle";
            this.Text = "RafEkle";
            this.Load += new System.EventHandler(this.RafEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_odaseçinz;
        private System.Windows.Forms.ComboBox cmb_bölmseçnz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_rafsil;
        private System.Windows.Forms.Button btn_rafekle;
        private System.Windows.Forms.TextBox txt_rafgirin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_verigöstr;
        private System.Windows.Forms.Button btn_menüdönn;
        private System.Windows.Forms.Button button1;
    }
}