namespace otobus_firmasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox_otobusturu = new System.Windows.Forms.ComboBox();
            this.PanelSetra = new System.Windows.Forms.Panel();
            this.PanelTravego = new System.Windows.Forms.Panel();
            this.bilglerGrpBx = new System.Windows.Forms.GroupBox();
            this.LblOtobusturu = new System.Windows.Forms.Label();
            this.LblKoltukNo = new System.Windows.Forms.Label();
            this.RdnBtnKadın = new System.Windows.Forms.RadioButton();
            this.RdnBtnErkek = new System.Windows.Forms.RadioButton();
            this.TxtAdSoyad = new System.Windows.Forms.TextBox();
            this.LabelAdSoyad = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bilglerGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(596, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox_otobusturu
            // 
            this.comboBox_otobusturu.FormattingEnabled = true;
            this.comboBox_otobusturu.Items.AddRange(new object[] {
            "Travego",
            "Setra"});
            this.comboBox_otobusturu.Location = new System.Drawing.Point(12, 102);
            this.comboBox_otobusturu.Name = "comboBox_otobusturu";
            this.comboBox_otobusturu.Size = new System.Drawing.Size(121, 21);
            this.comboBox_otobusturu.TabIndex = 1;
            this.comboBox_otobusturu.SelectedIndexChanged += new System.EventHandler(this.comboBox_otobusturu_SelectedIndexChanged);
            // 
            // PanelSetra
            // 
            this.PanelSetra.Location = new System.Drawing.Point(188, 92);
            this.PanelSetra.Name = "PanelSetra";
            this.PanelSetra.Size = new System.Drawing.Size(200, 338);
            this.PanelSetra.TabIndex = 3;
            // 
            // PanelTravego
            // 
            this.PanelTravego.Location = new System.Drawing.Point(188, 92);
            this.PanelTravego.Name = "PanelTravego";
            this.PanelTravego.Size = new System.Drawing.Size(200, 338);
            this.PanelTravego.TabIndex = 4;
            // 
            // bilglerGrpBx
            // 
            this.bilglerGrpBx.Controls.Add(this.BtnKaydet);
            this.bilglerGrpBx.Controls.Add(this.LblOtobusturu);
            this.bilglerGrpBx.Controls.Add(this.LblKoltukNo);
            this.bilglerGrpBx.Controls.Add(this.RdnBtnKadın);
            this.bilglerGrpBx.Controls.Add(this.RdnBtnErkek);
            this.bilglerGrpBx.Controls.Add(this.TxtAdSoyad);
            this.bilglerGrpBx.Controls.Add(this.LabelAdSoyad);
            this.bilglerGrpBx.Location = new System.Drawing.Point(408, 92);
            this.bilglerGrpBx.Name = "bilglerGrpBx";
            this.bilglerGrpBx.Size = new System.Drawing.Size(200, 198);
            this.bilglerGrpBx.TabIndex = 11;
            this.bilglerGrpBx.TabStop = false;
            this.bilglerGrpBx.Text = "Bilgiler";
            // 
            // LblOtobusturu
            // 
            this.LblOtobusturu.AutoSize = true;
            this.LblOtobusturu.Location = new System.Drawing.Point(15, 114);
            this.LblOtobusturu.Name = "LblOtobusturu";
            this.LblOtobusturu.Size = new System.Drawing.Size(72, 13);
            this.LblOtobusturu.TabIndex = 16;
            this.LblOtobusturu.Text = "Otobüs Türü :";
            // 
            // LblKoltukNo
            // 
            this.LblKoltukNo.AutoSize = true;
            this.LblKoltukNo.Location = new System.Drawing.Point(15, 88);
            this.LblKoltukNo.Name = "LblKoltukNo";
            this.LblKoltukNo.Size = new System.Drawing.Size(57, 13);
            this.LblKoltukNo.TabIndex = 15;
            this.LblKoltukNo.Text = "Koltuk No:";
            // 
            // RdnBtnKadın
            // 
            this.RdnBtnKadın.AutoSize = true;
            this.RdnBtnKadın.Location = new System.Drawing.Point(91, 58);
            this.RdnBtnKadın.Name = "RdnBtnKadın";
            this.RdnBtnKadın.Size = new System.Drawing.Size(52, 17);
            this.RdnBtnKadın.TabIndex = 14;
            this.RdnBtnKadın.TabStop = true;
            this.RdnBtnKadın.Text = "Kadın";
            this.RdnBtnKadın.UseVisualStyleBackColor = true;
            // 
            // RdnBtnErkek
            // 
            this.RdnBtnErkek.AutoSize = true;
            this.RdnBtnErkek.Location = new System.Drawing.Point(32, 58);
            this.RdnBtnErkek.Name = "RdnBtnErkek";
            this.RdnBtnErkek.Size = new System.Drawing.Size(53, 17);
            this.RdnBtnErkek.TabIndex = 13;
            this.RdnBtnErkek.TabStop = true;
            this.RdnBtnErkek.Text = "Erkek";
            this.RdnBtnErkek.UseVisualStyleBackColor = true;
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.Location = new System.Drawing.Point(18, 19);
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.Size = new System.Drawing.Size(176, 20);
            this.TxtAdSoyad.TabIndex = 12;
            // 
            // LabelAdSoyad
            // 
            this.LabelAdSoyad.AutoSize = true;
            this.LabelAdSoyad.Location = new System.Drawing.Point(65, 3);
            this.LabelAdSoyad.Name = "LabelAdSoyad";
            this.LabelAdSoyad.Size = new System.Drawing.Size(53, 13);
            this.LabelAdSoyad.TabIndex = 11;
            this.LabelAdSoyad.Text = "Ad-Soyad";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(32, 149);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(146, 23);
            this.BtnKaydet.TabIndex = 17;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 442);
            this.Controls.Add(this.bilglerGrpBx);
            this.Controls.Add(this.PanelTravego);
            this.Controls.Add(this.PanelSetra);
            this.Controls.Add(this.comboBox_otobusturu);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bilglerGrpBx.ResumeLayout(false);
            this.bilglerGrpBx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox_otobusturu;
        private System.Windows.Forms.Panel PanelSetra;
        private System.Windows.Forms.Panel PanelTravego;
        private System.Windows.Forms.GroupBox bilglerGrpBx;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label LblOtobusturu;
        private System.Windows.Forms.Label LblKoltukNo;
        private System.Windows.Forms.RadioButton RdnBtnKadın;
        private System.Windows.Forms.RadioButton RdnBtnErkek;
        private System.Windows.Forms.TextBox TxtAdSoyad;
        private System.Windows.Forms.Label LabelAdSoyad;
    }
}

