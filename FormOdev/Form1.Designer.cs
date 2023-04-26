
namespace FormOdev
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_urunad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_urunListele = new System.Windows.Forms.Button();
            this.btn_urunSil = new System.Windows.Forms.Button();
            this.btn_urunGuncelle = new System.Windows.Forms.Button();
            this.comboBox_kategori = new System.Windows.Forms.ComboBox();
            this.btn_urunekle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_urunstok = new System.Windows.Forms.TextBox();
            this.textBox_urunfiyat = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_satisListele = new System.Windows.Forms.Button();
            this.btn_satisGuncelle = new System.Windows.Forms.Button();
            this.btn_satisSil = new System.Windows.Forms.Button();
            this.comboBox_urun = new System.Windows.Forms.ComboBox();
            this.btn_satisekle = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_discount = new System.Windows.Forms.TextBox();
            this.textBox_satisdetay = new System.Windows.Forms.TextBox();
            this.btn_tamamınılistele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(559, 131);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox_urunad
            // 
            this.textBox_urunad.Location = new System.Drawing.Point(78, 31);
            this.textBox_urunad.Name = "textBox_urunad";
            this.textBox_urunad.Size = new System.Drawing.Size(100, 20);
            this.textBox_urunad.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_urunListele);
            this.groupBox1.Controls.Add(this.btn_urunSil);
            this.groupBox1.Controls.Add(this.btn_urunGuncelle);
            this.groupBox1.Controls.Add(this.comboBox_kategori);
            this.groupBox1.Controls.Add(this.btn_urunekle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_urunstok);
            this.groupBox1.Controls.Add(this.textBox_urunfiyat);
            this.groupBox1.Controls.Add(this.textBox_urunad);
            this.groupBox1.Location = new System.Drawing.Point(28, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 191);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_urunListele
            // 
            this.btn_urunListele.Location = new System.Drawing.Point(42, 167);
            this.btn_urunListele.Margin = new System.Windows.Forms.Padding(2);
            this.btn_urunListele.Name = "btn_urunListele";
            this.btn_urunListele.Size = new System.Drawing.Size(99, 21);
            this.btn_urunListele.TabIndex = 18;
            this.btn_urunListele.Text = "ÜrünListele";
            this.btn_urunListele.UseVisualStyleBackColor = true;
            this.btn_urunListele.Click += new System.EventHandler(this.btn_urunListele_Click);
            // 
            // btn_urunSil
            // 
            this.btn_urunSil.Location = new System.Drawing.Point(6, 139);
            this.btn_urunSil.Name = "btn_urunSil";
            this.btn_urunSil.Size = new System.Drawing.Size(43, 23);
            this.btn_urunSil.TabIndex = 13;
            this.btn_urunSil.Text = "Sil";
            this.btn_urunSil.UseVisualStyleBackColor = true;
            this.btn_urunSil.Click += new System.EventHandler(this.btn_urunSil_Click);
            // 
            // btn_urunGuncelle
            // 
            this.btn_urunGuncelle.Location = new System.Drawing.Point(55, 139);
            this.btn_urunGuncelle.Name = "btn_urunGuncelle";
            this.btn_urunGuncelle.Size = new System.Drawing.Size(61, 23);
            this.btn_urunGuncelle.TabIndex = 12;
            this.btn_urunGuncelle.Text = "Güncelle";
            this.btn_urunGuncelle.UseVisualStyleBackColor = true;
            this.btn_urunGuncelle.Click += new System.EventHandler(this.btn_urunGuncelle_Click);
            // 
            // comboBox_kategori
            // 
            this.comboBox_kategori.FormattingEnabled = true;
            this.comboBox_kategori.Location = new System.Drawing.Point(78, 112);
            this.comboBox_kategori.Name = "comboBox_kategori";
            this.comboBox_kategori.Size = new System.Drawing.Size(99, 21);
            this.comboBox_kategori.TabIndex = 11;
            // 
            // btn_urunekle
            // 
            this.btn_urunekle.Location = new System.Drawing.Point(122, 139);
            this.btn_urunekle.Name = "btn_urunekle";
            this.btn_urunekle.Size = new System.Drawing.Size(55, 23);
            this.btn_urunekle.TabIndex = 10;
            this.btn_urunekle.Text = "Ekle";
            this.btn_urunekle.UseVisualStyleBackColor = true;
            this.btn_urunekle.Click += new System.EventHandler(this.btn_urunekle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kategori Adı: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Stok: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fiyat: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ürün Adı:";
            // 
            // textBox_urunstok
            // 
            this.textBox_urunstok.Location = new System.Drawing.Point(78, 83);
            this.textBox_urunstok.Name = "textBox_urunstok";
            this.textBox_urunstok.Size = new System.Drawing.Size(100, 20);
            this.textBox_urunstok.TabIndex = 4;
            // 
            // textBox_urunfiyat
            // 
            this.textBox_urunfiyat.Location = new System.Drawing.Point(78, 57);
            this.textBox_urunfiyat.Name = "textBox_urunfiyat";
            this.textBox_urunfiyat.Size = new System.Drawing.Size(100, 20);
            this.textBox_urunfiyat.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_satisListele);
            this.groupBox3.Controls.Add(this.btn_satisGuncelle);
            this.groupBox3.Controls.Add(this.btn_satisSil);
            this.groupBox3.Controls.Add(this.comboBox_urun);
            this.groupBox3.Controls.Add(this.btn_satisekle);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBox_discount);
            this.groupBox3.Controls.Add(this.textBox_satisdetay);
            this.groupBox3.Location = new System.Drawing.Point(261, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 188);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Satış";
            // 
            // btn_satisListele
            // 
            this.btn_satisListele.Location = new System.Drawing.Point(46, 160);
            this.btn_satisListele.Margin = new System.Windows.Forms.Padding(2);
            this.btn_satisListele.Name = "btn_satisListele";
            this.btn_satisListele.Size = new System.Drawing.Size(99, 21);
            this.btn_satisListele.TabIndex = 17;
            this.btn_satisListele.Text = "Satış Listele";
            this.btn_satisListele.UseVisualStyleBackColor = true;
            this.btn_satisListele.Click += new System.EventHandler(this.btn_satisListele_Click);
            // 
            // btn_satisGuncelle
            // 
            this.btn_satisGuncelle.Location = new System.Drawing.Point(56, 135);
            this.btn_satisGuncelle.Name = "btn_satisGuncelle";
            this.btn_satisGuncelle.Size = new System.Drawing.Size(61, 23);
            this.btn_satisGuncelle.TabIndex = 15;
            this.btn_satisGuncelle.Text = "Güncelle";
            this.btn_satisGuncelle.UseVisualStyleBackColor = true;
            this.btn_satisGuncelle.Click += new System.EventHandler(this.btn_satisGuncelle_Click);
            // 
            // btn_satisSil
            // 
            this.btn_satisSil.Location = new System.Drawing.Point(9, 135);
            this.btn_satisSil.Name = "btn_satisSil";
            this.btn_satisSil.Size = new System.Drawing.Size(43, 23);
            this.btn_satisSil.TabIndex = 14;
            this.btn_satisSil.Text = "Sil";
            this.btn_satisSil.UseVisualStyleBackColor = true;
            this.btn_satisSil.Click += new System.EventHandler(this.btn_satisSil_Click);
            // 
            // comboBox_urun
            // 
            this.comboBox_urun.FormattingEnabled = true;
            this.comboBox_urun.Location = new System.Drawing.Point(78, 109);
            this.comboBox_urun.Name = "comboBox_urun";
            this.comboBox_urun.Size = new System.Drawing.Size(100, 21);
            this.comboBox_urun.TabIndex = 12;
            // 
            // btn_satisekle
            // 
            this.btn_satisekle.Location = new System.Drawing.Point(123, 135);
            this.btn_satisekle.Name = "btn_satisekle";
            this.btn_satisekle.Size = new System.Drawing.Size(55, 23);
            this.btn_satisekle.TabIndex = 11;
            this.btn_satisekle.Text = "Ekle";
            this.btn_satisekle.UseVisualStyleBackColor = true;
            this.btn_satisekle.Click += new System.EventHandler(this.btn_satisekle_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(78, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ürün Adı: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "İndirim: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Satış Tarihi: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Detay: ";
            // 
            // textBox_discount
            // 
            this.textBox_discount.Location = new System.Drawing.Point(78, 83);
            this.textBox_discount.Name = "textBox_discount";
            this.textBox_discount.Size = new System.Drawing.Size(100, 20);
            this.textBox_discount.TabIndex = 4;
            // 
            // textBox_satisdetay
            // 
            this.textBox_satisdetay.Location = new System.Drawing.Point(78, 31);
            this.textBox_satisdetay.Name = "textBox_satisdetay";
            this.textBox_satisdetay.Size = new System.Drawing.Size(100, 20);
            this.textBox_satisdetay.TabIndex = 2;
            // 
            // btn_tamamınılistele
            // 
            this.btn_tamamınılistele.Location = new System.Drawing.Point(476, 330);
            this.btn_tamamınılistele.Margin = new System.Windows.Forms.Padding(2);
            this.btn_tamamınılistele.Name = "btn_tamamınılistele";
            this.btn_tamamınılistele.Size = new System.Drawing.Size(99, 26);
            this.btn_tamamınılistele.TabIndex = 10;
            this.btn_tamamınılistele.Text = "Tümünü Listele";
            this.btn_tamamınılistele.UseVisualStyleBackColor = true;
            this.btn_tamamınılistele.Click += new System.EventHandler(this.btn_tamamınılistele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_tamamınılistele);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_urunad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_urunstok;
        private System.Windows.Forms.TextBox textBox_urunfiyat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_discount;
        private System.Windows.Forms.TextBox textBox_satisdetay;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_urunekle;
        private System.Windows.Forms.Button btn_satisekle;
        private System.Windows.Forms.Button btn_tamamınılistele;
        private System.Windows.Forms.ComboBox comboBox_kategori;
        private System.Windows.Forms.ComboBox comboBox_urun;
        private System.Windows.Forms.Button btn_urunSil;
        private System.Windows.Forms.Button btn_urunGuncelle;
        private System.Windows.Forms.Button btn_satisGuncelle;
        private System.Windows.Forms.Button btn_satisSil;
        private System.Windows.Forms.Button btn_urunListele;
        private System.Windows.Forms.Button btn_satisListele;
    }
}

