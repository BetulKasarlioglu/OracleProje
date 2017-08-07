namespace OracleProje
{
    partial class Odeme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.KALAN_LABEL = new System.Windows.Forms.Label();
            this.tarihPicker = new System.Windows.Forms.DateTimePicker();
            this.labelToplam = new System.Windows.Forms.Label();
            this.toplamFiyat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.per = new System.Windows.Forms.ComboBox();
            this.ogr = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.odemeTutar = new System.Windows.Forms.TextBox();
            this.taksitSayisi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.KALAN_LABEL);
            this.groupBox1.Controls.Add(this.tarihPicker);
            this.groupBox1.Controls.Add(this.labelToplam);
            this.groupBox1.Controls.Add(this.toplamFiyat);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.per);
            this.groupBox1.Controls.Add(this.ogr);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.odemeTutar);
            this.groupBox1.Controls.Add(this.taksitSayisi);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 462);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödeme";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(833, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Ödeme Raporu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // KALAN_LABEL
            // 
            this.KALAN_LABEL.AutoSize = true;
            this.KALAN_LABEL.Location = new System.Drawing.Point(581, 90);
            this.KALAN_LABEL.Name = "KALAN_LABEL";
            this.KALAN_LABEL.Size = new System.Drawing.Size(42, 13);
            this.KALAN_LABEL.TabIndex = 22;
            this.KALAN_LABEL.Text = "KALAN";
            // 
            // tarihPicker
            // 
            this.tarihPicker.Location = new System.Drawing.Point(420, 142);
            this.tarihPicker.Name = "tarihPicker";
            this.tarihPicker.Size = new System.Drawing.Size(145, 20);
            this.tarihPicker.TabIndex = 21;
            // 
            // labelToplam
            // 
            this.labelToplam.AutoSize = true;
            this.labelToplam.Location = new System.Drawing.Point(322, 62);
            this.labelToplam.Name = "labelToplam";
            this.labelToplam.Size = new System.Drawing.Size(67, 13);
            this.labelToplam.TabIndex = 20;
            this.labelToplam.Text = "Toplam Fiyat";
            // 
            // toplamFiyat
            // 
            this.toplamFiyat.Location = new System.Drawing.Point(420, 55);
            this.toplamFiyat.Name = "toplamFiyat";
            this.toplamFiyat.Size = new System.Drawing.Size(145, 20);
            this.toplamFiyat.TabIndex = 19;
            this.toplamFiyat.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 40);
            this.button1.TabIndex = 18;
            this.button1.Text = "ÖDE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // per
            // 
            this.per.FormattingEnabled = true;
            this.per.Location = new System.Drawing.Point(420, 168);
            this.per.Name = "per";
            this.per.Size = new System.Drawing.Size(145, 21);
            this.per.TabIndex = 17;
            // 
            // ogr
            // 
            this.ogr.FormattingEnabled = true;
            this.ogr.Location = new System.Drawing.Point(420, 19);
            this.ogr.Name = "ogr";
            this.ogr.Size = new System.Drawing.Size(145, 21);
            this.ogr.TabIndex = 16;
            this.ogr.SelectedIndexChanged += new System.EventHandler(this.ogr_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Personel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Öğrenci";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ödeme Tutarı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Taksit Sayısı";
            // 
            // odemeTutar
            // 
            this.odemeTutar.Location = new System.Drawing.Point(420, 113);
            this.odemeTutar.Name = "odemeTutar";
            this.odemeTutar.Size = new System.Drawing.Size(145, 20);
            this.odemeTutar.TabIndex = 2;
            this.odemeTutar.Text = "0";
            // 
            // taksitSayisi
            // 
            this.taksitSayisi.Location = new System.Drawing.Point(420, 87);
            this.taksitSayisi.Name = "taksitSayisi";
            this.taksitSayisi.Size = new System.Drawing.Size(145, 20);
            this.taksitSayisi.TabIndex = 1;
            this.taksitSayisi.Text = "1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(943, 205);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Odeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 501);
            this.Controls.Add(this.groupBox1);
            this.Name = "Odeme";
            this.Text = "Odeme";
            this.Load += new System.EventHandler(this.Odeme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox per;
        private System.Windows.Forms.ComboBox ogr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox odemeTutar;
        private System.Windows.Forms.TextBox taksitSayisi;
        private System.Windows.Forms.Label labelToplam;
        private System.Windows.Forms.TextBox toplamFiyat;
        private System.Windows.Forms.DateTimePicker tarihPicker;
        private System.Windows.Forms.Label KALAN_LABEL;
        private System.Windows.Forms.Button button2;
    }
}