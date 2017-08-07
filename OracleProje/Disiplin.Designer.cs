namespace OracleProje
{
    partial class Disiplin
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
            this.DisiplindataGridView = new System.Windows.Forms.DataGridView();
            this.ogrComboBox = new System.Windows.Forms.ComboBox();
            this.disiplinText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisiplindataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.disiplinText);
            this.groupBox1.Controls.Add(this.ogrComboBox);
            this.groupBox1.Controls.Add(this.DisiplindataGridView);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 359);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Disiplinli Öğrenciler";
            // 
            // DisiplindataGridView
            // 
            this.DisiplindataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisiplindataGridView.Location = new System.Drawing.Point(22, 90);
            this.DisiplindataGridView.Name = "DisiplindataGridView";
            this.DisiplindataGridView.Size = new System.Drawing.Size(757, 254);
            this.DisiplindataGridView.TabIndex = 0;
            // 
            // ogrComboBox
            // 
            this.ogrComboBox.FormattingEnabled = true;
            this.ogrComboBox.Location = new System.Drawing.Point(294, 19);
            this.ogrComboBox.Name = "ogrComboBox";
            this.ogrComboBox.Size = new System.Drawing.Size(121, 21);
            this.ogrComboBox.TabIndex = 1;
            // 
            // disiplinText
            // 
            this.disiplinText.Location = new System.Drawing.Point(294, 48);
            this.disiplinText.Name = "disiplinText";
            this.disiplinText.Size = new System.Drawing.Size(121, 20);
            this.disiplinText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Öğrenci Seç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Disiplin Açıklaması";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Disiplin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 383);
            this.Controls.Add(this.groupBox1);
            this.Name = "Disiplin";
            this.Text = "Disiplin";
            this.Load += new System.EventHandler(this.Disiplin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisiplindataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DisiplindataGridView;
        private System.Windows.Forms.ComboBox ogrComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox disiplinText;
    }
}