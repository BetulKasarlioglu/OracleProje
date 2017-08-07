namespace OracleProje
{
    partial class Personel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.yurtComboBox = new System.Windows.Forms.ComboBox();
            this.yetkiComboBox = new System.Windows.Forms.ComboBox();
            this.sifreText = new System.Windows.Forms.TextBox();
            this.maasText = new System.Windows.Forms.TextBox();
            this.AdresRichTextBox = new System.Windows.Forms.RichTextBox();
            this.telText = new System.Windows.Forms.TextBox();
            this.kidemText = new System.Windows.Forms.TextBox();
            this.soyadText = new System.Windows.Forms.TextBox();
            this.adText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(733, 170);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.yurtComboBox);
            this.groupBox2.Controls.Add(this.yetkiComboBox);
            this.groupBox2.Controls.Add(this.sifreText);
            this.groupBox2.Controls.Add(this.maasText);
            this.groupBox2.Controls.Add(this.AdresRichTextBox);
            this.groupBox2.Controls.Add(this.telText);
            this.groupBox2.Controls.Add(this.kidemText);
            this.groupBox2.Controls.Add(this.soyadText);
            this.groupBox2.Controls.Add(this.adText);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(18, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(733, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel Ekle";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yurtComboBox
            // 
            this.yurtComboBox.FormattingEnabled = true;
            this.yurtComboBox.Location = new System.Drawing.Point(544, 55);
            this.yurtComboBox.Name = "yurtComboBox";
            this.yurtComboBox.Size = new System.Drawing.Size(121, 21);
            this.yurtComboBox.TabIndex = 17;
            // 
            // yetkiComboBox
            // 
            this.yetkiComboBox.FormattingEnabled = true;
            this.yetkiComboBox.Items.AddRange(new object[] {
            "1",
            "0"});
            this.yetkiComboBox.Location = new System.Drawing.Point(544, 20);
            this.yetkiComboBox.Name = "yetkiComboBox";
            this.yetkiComboBox.Size = new System.Drawing.Size(121, 21);
            this.yetkiComboBox.TabIndex = 16;
            // 
            // sifreText
            // 
            this.sifreText.Location = new System.Drawing.Point(544, 88);
            this.sifreText.Name = "sifreText";
            this.sifreText.Size = new System.Drawing.Size(121, 20);
            this.sifreText.TabIndex = 15;
            // 
            // maasText
            // 
            this.maasText.Location = new System.Drawing.Point(316, 134);
            this.maasText.Name = "maasText";
            this.maasText.Size = new System.Drawing.Size(100, 20);
            this.maasText.TabIndex = 14;
            // 
            // AdresRichTextBox
            // 
            this.AdresRichTextBox.Location = new System.Drawing.Point(316, 27);
            this.AdresRichTextBox.Name = "AdresRichTextBox";
            this.AdresRichTextBox.Size = new System.Drawing.Size(100, 96);
            this.AdresRichTextBox.TabIndex = 13;
            this.AdresRichTextBox.Text = "";
            // 
            // telText
            // 
            this.telText.Location = new System.Drawing.Point(86, 123);
            this.telText.Name = "telText";
            this.telText.Size = new System.Drawing.Size(100, 20);
            this.telText.TabIndex = 12;
            // 
            // kidemText
            // 
            this.kidemText.Location = new System.Drawing.Point(86, 88);
            this.kidemText.Name = "kidemText";
            this.kidemText.Size = new System.Drawing.Size(100, 20);
            this.kidemText.TabIndex = 11;
            // 
            // soyadText
            // 
            this.soyadText.Location = new System.Drawing.Point(86, 55);
            this.soyadText.Name = "soyadText";
            this.soyadText.Size = new System.Drawing.Size(100, 20);
            this.soyadText.TabIndex = 10;
            // 
            // adText
            // 
            this.adText.Location = new System.Drawing.Point(86, 24);
            this.adText.Name = "adText";
            this.adText.Size = new System.Drawing.Size(100, 20);
            this.adText.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(474, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Yurt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Şifre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(474, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Yetki";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Maaş";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kıdem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 399);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Personel";
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.Personel_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox yurtComboBox;
        private System.Windows.Forms.ComboBox yetkiComboBox;
        private System.Windows.Forms.TextBox sifreText;
        private System.Windows.Forms.TextBox maasText;
        private System.Windows.Forms.RichTextBox AdresRichTextBox;
        private System.Windows.Forms.TextBox telText;
        private System.Windows.Forms.TextBox kidemText;
        private System.Windows.Forms.TextBox soyadText;
        private System.Windows.Forms.TextBox adText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}