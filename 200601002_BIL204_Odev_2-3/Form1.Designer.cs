namespace _200601002_BIL204_Odev_2_3
{
    partial class formMetin
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMetin));
            this.btnMetinYukle = new System.Windows.Forms.Button();
            this.txtDosyaPath = new System.Windows.Forms.TextBox();
            this.gbDosyaYukle = new System.Windows.Forms.GroupBox();
            this.btnStackOku = new System.Windows.Forms.Button();
            this.gbStackOku = new System.Windows.Forms.GroupBox();
            this.gbAgacaAktar = new System.Windows.Forms.GroupBox();
            this.btnCokKelimeler = new System.Windows.Forms.Button();
            this.btnAgacaAktar = new System.Windows.Forms.Button();
            this.gbHashTablo = new System.Windows.Forms.GroupBox();
            this.btnHashTabloOlustur = new System.Windows.Forms.Button();
            this.lvStackYaz = new System.Windows.Forms.ListView();
            this.lvAgacaAktar = new System.Windows.Forms.ListView();
            this.lvHashTabloOlustur = new System.Windows.Forms.ListView();
            this.gbDosyaYukle.SuspendLayout();
            this.gbStackOku.SuspendLayout();
            this.gbAgacaAktar.SuspendLayout();
            this.gbHashTablo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMetinYukle
            // 
            this.btnMetinYukle.Location = new System.Drawing.Point(28, 37);
            this.btnMetinYukle.Name = "btnMetinYukle";
            this.btnMetinYukle.Size = new System.Drawing.Size(75, 23);
            this.btnMetinYukle.TabIndex = 0;
            this.btnMetinYukle.Text = "Metin Yükle";
            this.btnMetinYukle.UseVisualStyleBackColor = true;
            this.btnMetinYukle.Click += new System.EventHandler(this.btnMetinYukle_Click);
            // 
            // txtDosyaPath
            // 
            this.txtDosyaPath.Enabled = false;
            this.txtDosyaPath.Location = new System.Drawing.Point(139, 40);
            this.txtDosyaPath.Name = "txtDosyaPath";
            this.txtDosyaPath.Size = new System.Drawing.Size(430, 20);
            this.txtDosyaPath.TabIndex = 1;
            // 
            // gbDosyaYukle
            // 
            this.gbDosyaYukle.Controls.Add(this.btnMetinYukle);
            this.gbDosyaYukle.Controls.Add(this.txtDosyaPath);
            this.gbDosyaYukle.Location = new System.Drawing.Point(28, 12);
            this.gbDosyaYukle.Name = "gbDosyaYukle";
            this.gbDosyaYukle.Size = new System.Drawing.Size(575, 96);
            this.gbDosyaYukle.TabIndex = 3;
            this.gbDosyaYukle.TabStop = false;
            this.gbDosyaYukle.Text = "txt dosyası yükleyiniz";
            // 
            // btnStackOku
            // 
            this.btnStackOku.Location = new System.Drawing.Point(28, 119);
            this.btnStackOku.Name = "btnStackOku";
            this.btnStackOku.Size = new System.Drawing.Size(75, 23);
            this.btnStackOku.TabIndex = 2;
            this.btnStackOku.Text = "Stack\'e Oku";
            this.btnStackOku.UseVisualStyleBackColor = true;
            this.btnStackOku.Click += new System.EventHandler(this.btnStackOku_Click);
            // 
            // gbStackOku
            // 
            this.gbStackOku.Controls.Add(this.lvStackYaz);
            this.gbStackOku.Controls.Add(this.btnStackOku);
            this.gbStackOku.Location = new System.Drawing.Point(28, 114);
            this.gbStackOku.Name = "gbStackOku";
            this.gbStackOku.Size = new System.Drawing.Size(1057, 248);
            this.gbStackOku.TabIndex = 4;
            this.gbStackOku.TabStop = false;
            this.gbStackOku.Text = "Stack\'e Oku";
            // 
            // gbAgacaAktar
            // 
            this.gbAgacaAktar.Controls.Add(this.lvAgacaAktar);
            this.gbAgacaAktar.Controls.Add(this.btnCokKelimeler);
            this.gbAgacaAktar.Controls.Add(this.btnAgacaAktar);
            this.gbAgacaAktar.Location = new System.Drawing.Point(28, 368);
            this.gbAgacaAktar.Name = "gbAgacaAktar";
            this.gbAgacaAktar.Size = new System.Drawing.Size(1057, 259);
            this.gbAgacaAktar.TabIndex = 5;
            this.gbAgacaAktar.TabStop = false;
            this.gbAgacaAktar.Text = "Ağaca Aktar";
            // 
            // btnCokKelimeler
            // 
            this.btnCokKelimeler.Location = new System.Drawing.Point(28, 121);
            this.btnCokKelimeler.Name = "btnCokKelimeler";
            this.btnCokKelimeler.Size = new System.Drawing.Size(105, 43);
            this.btnCokKelimeler.TabIndex = 3;
            this.btnCokKelimeler.Text = "En Sık Kullanılan Kelimeleri Getir";
            this.btnCokKelimeler.UseVisualStyleBackColor = true;
            // 
            // btnAgacaAktar
            // 
            this.btnAgacaAktar.Location = new System.Drawing.Point(28, 85);
            this.btnAgacaAktar.Name = "btnAgacaAktar";
            this.btnAgacaAktar.Size = new System.Drawing.Size(105, 23);
            this.btnAgacaAktar.TabIndex = 2;
            this.btnAgacaAktar.Text = "Ağaca Aktar";
            this.btnAgacaAktar.UseVisualStyleBackColor = true;
            // 
            // gbHashTablo
            // 
            this.gbHashTablo.Controls.Add(this.lvHashTabloOlustur);
            this.gbHashTablo.Controls.Add(this.btnHashTabloOlustur);
            this.gbHashTablo.Location = new System.Drawing.Point(28, 633);
            this.gbHashTablo.Name = "gbHashTablo";
            this.gbHashTablo.Size = new System.Drawing.Size(1057, 388);
            this.gbHashTablo.TabIndex = 6;
            this.gbHashTablo.TabStop = false;
            this.gbHashTablo.Text = "Hash Tablo Oluştur";
            // 
            // btnHashTabloOlustur
            // 
            this.btnHashTabloOlustur.Location = new System.Drawing.Point(28, 172);
            this.btnHashTabloOlustur.Name = "btnHashTabloOlustur";
            this.btnHashTabloOlustur.Size = new System.Drawing.Size(105, 43);
            this.btnHashTabloOlustur.TabIndex = 3;
            this.btnHashTabloOlustur.Text = "Hash Tablo Olustur";
            this.btnHashTabloOlustur.UseVisualStyleBackColor = true;
            // 
            // lvStackYaz
            // 
            this.lvStackYaz.HideSelection = false;
            this.lvStackYaz.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lvStackYaz.Location = new System.Drawing.Point(139, 19);
            this.lvStackYaz.Name = "lvStackYaz";
            this.lvStackYaz.Size = new System.Drawing.Size(912, 223);
            this.lvStackYaz.TabIndex = 6;
            this.lvStackYaz.UseCompatibleStateImageBehavior = false;
            this.lvStackYaz.View = System.Windows.Forms.View.Details;
            // 
            // lvAgacaAktar
            // 
            this.lvAgacaAktar.HideSelection = false;
            this.lvAgacaAktar.Location = new System.Drawing.Point(139, 19);
            this.lvAgacaAktar.Name = "lvAgacaAktar";
            this.lvAgacaAktar.Size = new System.Drawing.Size(912, 223);
            this.lvAgacaAktar.TabIndex = 7;
            this.lvAgacaAktar.UseCompatibleStateImageBehavior = false;
            this.lvAgacaAktar.View = System.Windows.Forms.View.Details;
            // 
            // lvHashTabloOlustur
            // 
            this.lvHashTabloOlustur.GridLines = true;
            this.lvHashTabloOlustur.HideSelection = false;
            this.lvHashTabloOlustur.Location = new System.Drawing.Point(139, 19);
            this.lvHashTabloOlustur.Name = "lvHashTabloOlustur";
            this.lvHashTabloOlustur.Size = new System.Drawing.Size(912, 357);
            this.lvHashTabloOlustur.TabIndex = 8;
            this.lvHashTabloOlustur.UseCompatibleStateImageBehavior = false;
            this.lvHashTabloOlustur.View = System.Windows.Forms.View.Details;
            // 
            // formMetin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1114, 632);
            this.Controls.Add(this.gbHashTablo);
            this.Controls.Add(this.gbAgacaAktar);
            this.Controls.Add(this.gbStackOku);
            this.Controls.Add(this.gbDosyaYukle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formMetin";
            this.Text = "Metin Yazarı Belirleme";
            this.Load += new System.EventHandler(this.formMetin_Load);
            this.gbDosyaYukle.ResumeLayout(false);
            this.gbDosyaYukle.PerformLayout();
            this.gbStackOku.ResumeLayout(false);
            this.gbAgacaAktar.ResumeLayout(false);
            this.gbHashTablo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMetinYukle;
        private System.Windows.Forms.TextBox txtDosyaPath;
        private System.Windows.Forms.GroupBox gbDosyaYukle;
        private System.Windows.Forms.Button btnStackOku;
        private System.Windows.Forms.GroupBox gbStackOku;
        private System.Windows.Forms.GroupBox gbAgacaAktar;
        private System.Windows.Forms.Button btnAgacaAktar;
        private System.Windows.Forms.Button btnCokKelimeler;
        private System.Windows.Forms.GroupBox gbHashTablo;
        private System.Windows.Forms.Button btnHashTabloOlustur;
        private System.Windows.Forms.ListView lvStackYaz;
        private System.Windows.Forms.ListView lvAgacaAktar;
        private System.Windows.Forms.ListView lvHashTabloOlustur;
    }
}

