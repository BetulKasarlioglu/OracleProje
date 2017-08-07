namespace OracleProje
{
    partial class Anasayfa
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
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.personelButonu = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.yurtButonu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOgrenciIsleri = new System.Windows.Forms.Button();
            this.gbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.button11);
            this.gbMenu.Controls.Add(this.button10);
            this.gbMenu.Controls.Add(this.button9);
            this.gbMenu.Controls.Add(this.personelButonu);
            this.gbMenu.Controls.Add(this.button7);
            this.gbMenu.Controls.Add(this.yurtButonu);
            this.gbMenu.Controls.Add(this.button1);
            this.gbMenu.Controls.Add(this.btnOgrenciIsleri);
            this.gbMenu.Location = new System.Drawing.Point(5, 4);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(550, 203);
            this.gbMenu.TabIndex = 3;
            this.gbMenu.TabStop = false;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(405, 110);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(127, 69);
            this.button11.TabIndex = 11;
            this.button11.Text = "DİSİPLİN İŞLEMLERİ";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(272, 110);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(127, 69);
            this.button10.TabIndex = 10;
            this.button10.Text = "SİLİNMİŞ ÖĞRENCİLER";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(405, 24);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(127, 69);
            this.button9.TabIndex = 9;
            this.button9.Text = "ÖDEME GİR";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // personelButonu
            // 
            this.personelButonu.Location = new System.Drawing.Point(6, 110);
            this.personelButonu.Name = "personelButonu";
            this.personelButonu.Size = new System.Drawing.Size(127, 69);
            this.personelButonu.TabIndex = 8;
            this.personelButonu.Text = "PERSONEL";
            this.personelButonu.UseVisualStyleBackColor = true;
            this.personelButonu.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(272, 22);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(127, 69);
            this.button7.TabIndex = 7;
            this.button7.Text = "ODA İŞLEMLERİ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // yurtButonu
            // 
            this.yurtButonu.Location = new System.Drawing.Point(139, 110);
            this.yurtButonu.Name = "yurtButonu";
            this.yurtButonu.Size = new System.Drawing.Size(126, 69);
            this.yurtButonu.TabIndex = 6;
            this.yurtButonu.Text = "YURT İŞLEMLERİ";
            this.yurtButonu.UseVisualStyleBackColor = true;
            this.yurtButonu.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 74);
            this.button1.TabIndex = 5;
            this.button1.Text = "ÖĞRENCİ SİL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOgrenciIsleri
            // 
            this.btnOgrenciIsleri.Location = new System.Drawing.Point(6, 19);
            this.btnOgrenciIsleri.Name = "btnOgrenciIsleri";
            this.btnOgrenciIsleri.Size = new System.Drawing.Size(127, 74);
            this.btnOgrenciIsleri.TabIndex = 0;
            this.btnOgrenciIsleri.Text = "ÖĞRENCİ EKLE";
            this.btnOgrenciIsleri.UseVisualStyleBackColor = true;
            this.btnOgrenciIsleri.Click += new System.EventHandler(this.btnOgrenciIsleri_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 219);
            this.Controls.Add(this.gbMenu);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.gbMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.Button btnOgrenciIsleri;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button yurtButonu;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button personelButonu;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}