namespace OracleProje
{
    partial class SilinmisOgrenciler
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
            this.SilinmisdataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.SilinmisdataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SilinmisdataGridView
            // 
            this.SilinmisdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SilinmisdataGridView.Location = new System.Drawing.Point(15, 19);
            this.SilinmisdataGridView.Name = "SilinmisdataGridView";
            this.SilinmisdataGridView.Size = new System.Drawing.Size(732, 314);
            this.SilinmisdataGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SilinmisdataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 339);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KAYDI SİLİNEN ÖĞRENCİLER";
            // 
            // SilinmisOgrenciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 363);
            this.Controls.Add(this.groupBox1);
            this.Name = "SilinmisOgrenciler";
            this.Text = "SilinmisOgrenciler";
            this.Load += new System.EventHandler(this.SilinmisOgrenciler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SilinmisdataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SilinmisdataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}