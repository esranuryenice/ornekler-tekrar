namespace denemee
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
            this.btn_domates = new System.Windows.Forms.Button();
            this.btn_biber = new System.Windows.Forms.Button();
            this.btn_patlican = new System.Windows.Forms.Button();
            this.btn_patates = new System.Windows.Forms.Button();
            this.btn_maydonoz = new System.Windows.Forms.Button();
            this.btn_dereotu = new System.Windows.Forms.Button();
            this.btn_karnabahar = new System.Windows.Forms.Button();
            this.btn_brokoli = new System.Windows.Forms.Button();
            this.btn_sogan = new System.Windows.Forms.Button();
            this.lbl_fiyat = new System.Windows.Forms.Label();
            this.lbl_kilo = new System.Windows.Forms.Label();
            this.lbl_adet = new System.Windows.Forms.Label();
            this.lbl_gram = new System.Windows.Forms.Label();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.txt_kilo = new System.Windows.Forms.TextBox();
            this.txt_adet = new System.Windows.Forms.TextBox();
            this.txt_gram = new System.Windows.Forms.TextBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.lbl_hesapla = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_domates
            // 
            this.btn_domates.Location = new System.Drawing.Point(30, 31);
            this.btn_domates.Name = "btn_domates";
            this.btn_domates.Size = new System.Drawing.Size(104, 86);
            this.btn_domates.TabIndex = 0;
            this.btn_domates.Text = "Domates";
            this.btn_domates.UseVisualStyleBackColor = true;
            this.btn_domates.Click += new System.EventHandler(this.btn_domates_Click);
            // 
            // btn_biber
            // 
            this.btn_biber.Location = new System.Drawing.Point(140, 31);
            this.btn_biber.Name = "btn_biber";
            this.btn_biber.Size = new System.Drawing.Size(104, 86);
            this.btn_biber.TabIndex = 1;
            this.btn_biber.Text = "Biber";
            this.btn_biber.UseVisualStyleBackColor = true;
            // 
            // btn_patlican
            // 
            this.btn_patlican.Location = new System.Drawing.Point(250, 31);
            this.btn_patlican.Name = "btn_patlican";
            this.btn_patlican.Size = new System.Drawing.Size(104, 86);
            this.btn_patlican.TabIndex = 2;
            this.btn_patlican.Text = "Patlıcan";
            this.btn_patlican.UseVisualStyleBackColor = true;
            // 
            // btn_patates
            // 
            this.btn_patates.Location = new System.Drawing.Point(250, 123);
            this.btn_patates.Name = "btn_patates";
            this.btn_patates.Size = new System.Drawing.Size(104, 86);
            this.btn_patates.TabIndex = 5;
            this.btn_patates.Text = "Patates";
            this.btn_patates.UseVisualStyleBackColor = true;
            // 
            // btn_maydonoz
            // 
            this.btn_maydonoz.Location = new System.Drawing.Point(140, 123);
            this.btn_maydonoz.Name = "btn_maydonoz";
            this.btn_maydonoz.Size = new System.Drawing.Size(104, 86);
            this.btn_maydonoz.TabIndex = 4;
            this.btn_maydonoz.Text = "Maydonoz";
            this.btn_maydonoz.UseVisualStyleBackColor = true;
            // 
            // btn_dereotu
            // 
            this.btn_dereotu.Location = new System.Drawing.Point(30, 123);
            this.btn_dereotu.Name = "btn_dereotu";
            this.btn_dereotu.Size = new System.Drawing.Size(104, 86);
            this.btn_dereotu.TabIndex = 3;
            this.btn_dereotu.Text = "Dereotu";
            this.btn_dereotu.UseVisualStyleBackColor = true;
            // 
            // btn_karnabahar
            // 
            this.btn_karnabahar.Location = new System.Drawing.Point(250, 215);
            this.btn_karnabahar.Name = "btn_karnabahar";
            this.btn_karnabahar.Size = new System.Drawing.Size(104, 86);
            this.btn_karnabahar.TabIndex = 8;
            this.btn_karnabahar.Text = "Karnabahar";
            this.btn_karnabahar.UseVisualStyleBackColor = true;
            // 
            // btn_brokoli
            // 
            this.btn_brokoli.Location = new System.Drawing.Point(140, 215);
            this.btn_brokoli.Name = "btn_brokoli";
            this.btn_brokoli.Size = new System.Drawing.Size(104, 86);
            this.btn_brokoli.TabIndex = 7;
            this.btn_brokoli.Text = "Brokoli";
            this.btn_brokoli.UseVisualStyleBackColor = true;
            // 
            // btn_sogan
            // 
            this.btn_sogan.Location = new System.Drawing.Point(30, 215);
            this.btn_sogan.Name = "btn_sogan";
            this.btn_sogan.Size = new System.Drawing.Size(104, 86);
            this.btn_sogan.TabIndex = 6;
            this.btn_sogan.Text = "Soğan";
            this.btn_sogan.UseVisualStyleBackColor = true;
            // 
            // lbl_fiyat
            // 
            this.lbl_fiyat.AutoSize = true;
            this.lbl_fiyat.Location = new System.Drawing.Point(399, 31);
            this.lbl_fiyat.Name = "lbl_fiyat";
            this.lbl_fiyat.Size = new System.Drawing.Size(35, 13);
            this.lbl_fiyat.TabIndex = 9;
            this.lbl_fiyat.Text = "Fiyat :";
            // 
            // lbl_kilo
            // 
            this.lbl_kilo.AutoSize = true;
            this.lbl_kilo.Location = new System.Drawing.Point(402, 68);
            this.lbl_kilo.Name = "lbl_kilo";
            this.lbl_kilo.Size = new System.Drawing.Size(30, 13);
            this.lbl_kilo.TabIndex = 10;
            this.lbl_kilo.Text = "Kilo :";
            // 
            // lbl_adet
            // 
            this.lbl_adet.AutoSize = true;
            this.lbl_adet.Location = new System.Drawing.Point(402, 103);
            this.lbl_adet.Name = "lbl_adet";
            this.lbl_adet.Size = new System.Drawing.Size(35, 13);
            this.lbl_adet.TabIndex = 11;
            this.lbl_adet.Text = "Adet :";
            // 
            // lbl_gram
            // 
            this.lbl_gram.AutoSize = true;
            this.lbl_gram.Location = new System.Drawing.Point(402, 132);
            this.lbl_gram.Name = "lbl_gram";
            this.lbl_gram.Size = new System.Drawing.Size(38, 13);
            this.lbl_gram.TabIndex = 12;
            this.lbl_gram.Text = "Gram :";
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Location = new System.Drawing.Point(438, 28);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(100, 20);
            this.txt_fiyat.TabIndex = 13;
            // 
            // txt_kilo
            // 
            this.txt_kilo.Location = new System.Drawing.Point(438, 61);
            this.txt_kilo.Name = "txt_kilo";
            this.txt_kilo.Size = new System.Drawing.Size(100, 20);
            this.txt_kilo.TabIndex = 14;
            // 
            // txt_adet
            // 
            this.txt_adet.Location = new System.Drawing.Point(438, 97);
            this.txt_adet.Name = "txt_adet";
            this.txt_adet.Size = new System.Drawing.Size(100, 20);
            this.txt_adet.TabIndex = 15;
            // 
            // txt_gram
            // 
            this.txt_gram.Location = new System.Drawing.Point(438, 129);
            this.txt_gram.Name = "txt_gram";
            this.txt_gram.Size = new System.Drawing.Size(100, 20);
            this.txt_gram.TabIndex = 16;
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(405, 168);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(163, 23);
            this.btn_hesapla.TabIndex = 17;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            // 
            // lbl_hesapla
            // 
            this.lbl_hesapla.AutoSize = true;
            this.lbl_hesapla.Location = new System.Drawing.Point(405, 196);
            this.lbl_hesapla.Name = "lbl_hesapla";
            this.lbl_hesapla.Size = new System.Drawing.Size(35, 13);
            this.lbl_hesapla.TabIndex = 18;
            this.lbl_hesapla.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 457);
            this.Controls.Add(this.lbl_hesapla);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.txt_gram);
            this.Controls.Add(this.txt_adet);
            this.Controls.Add(this.txt_kilo);
            this.Controls.Add(this.txt_fiyat);
            this.Controls.Add(this.lbl_gram);
            this.Controls.Add(this.lbl_adet);
            this.Controls.Add(this.lbl_kilo);
            this.Controls.Add(this.lbl_fiyat);
            this.Controls.Add(this.btn_karnabahar);
            this.Controls.Add(this.btn_brokoli);
            this.Controls.Add(this.btn_sogan);
            this.Controls.Add(this.btn_patates);
            this.Controls.Add(this.btn_maydonoz);
            this.Controls.Add(this.btn_dereotu);
            this.Controls.Add(this.btn_patlican);
            this.Controls.Add(this.btn_biber);
            this.Controls.Add(this.btn_domates);
            this.Name = "Form1";
            this.Text = "Sebzeler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_domates;
        private System.Windows.Forms.Button btn_biber;
        private System.Windows.Forms.Button btn_patlican;
        private System.Windows.Forms.Button btn_patates;
        private System.Windows.Forms.Button btn_maydonoz;
        private System.Windows.Forms.Button btn_dereotu;
        private System.Windows.Forms.Button btn_karnabahar;
        private System.Windows.Forms.Button btn_brokoli;
        private System.Windows.Forms.Button btn_sogan;
        private System.Windows.Forms.Label lbl_fiyat;
        private System.Windows.Forms.Label lbl_kilo;
        private System.Windows.Forms.Label lbl_adet;
        private System.Windows.Forms.Label lbl_gram;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.TextBox txt_kilo;
        private System.Windows.Forms.TextBox txt_adet;
        private System.Windows.Forms.TextBox txt_gram;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Label lbl_hesapla;
    }
}

