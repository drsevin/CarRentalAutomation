
namespace CarRentalAutomation
{
    partial class frmAnaSayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSatislar = new System.Windows.Forms.Button();
            this.btnKiralama = new System.Windows.Forms.Button();
            this.btnAracListele = new System.Windows.Forms.Button();
            this.btnAracKayit = new System.Windows.Forms.Button();
            this.btnMusteriListele = new System.Windows.Forms.Button();
            this.btnMusteriEkleme = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.btnSatislar);
            this.panel1.Controls.Add(this.btnKiralama);
            this.panel1.Controls.Add(this.btnAracListele);
            this.panel1.Controls.Add(this.btnAracKayit);
            this.panel1.Controls.Add(this.btnMusteriListele);
            this.panel1.Controls.Add(this.btnMusteriEkleme);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 239);
            this.panel1.TabIndex = 0;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.White;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCikis.ImageIndex = 5;
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(943, 41);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(146, 150);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "Cikis";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "musteriekle.png");
            this.ımageList1.Images.SetKeyName(1, "aracekle.png");
            this.ımageList1.Images.SetKeyName(2, "araclistele2.png");
            this.ımageList1.Images.SetKeyName(3, "arackirala.png");
            this.ımageList1.Images.SetKeyName(4, "araclistele.png");
            this.ımageList1.Images.SetKeyName(5, "cikis.png");
            this.ımageList1.Images.SetKeyName(6, "musterilistele2 (2).png");
            this.ımageList1.Images.SetKeyName(7, "araclistele.png");
            // 
            // btnSatislar
            // 
            this.btnSatislar.BackColor = System.Drawing.Color.White;
            this.btnSatislar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatislar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSatislar.ImageIndex = 7;
            this.btnSatislar.ImageList = this.ımageList1;
            this.btnSatislar.Location = new System.Drawing.Point(791, 41);
            this.btnSatislar.Name = "btnSatislar";
            this.btnSatislar.Size = new System.Drawing.Size(146, 150);
            this.btnSatislar.TabIndex = 5;
            this.btnSatislar.Text = "Satislar";
            this.btnSatislar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSatislar.UseVisualStyleBackColor = false;
            this.btnSatislar.Click += new System.EventHandler(this.btnSatislar_Click);
            // 
            // btnKiralama
            // 
            this.btnKiralama.BackColor = System.Drawing.Color.White;
            this.btnKiralama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKiralama.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKiralama.ImageIndex = 3;
            this.btnKiralama.ImageList = this.ımageList1;
            this.btnKiralama.Location = new System.Drawing.Point(639, 41);
            this.btnKiralama.Name = "btnKiralama";
            this.btnKiralama.Size = new System.Drawing.Size(146, 150);
            this.btnKiralama.TabIndex = 4;
            this.btnKiralama.Text = "Kiralama Islemi";
            this.btnKiralama.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKiralama.UseVisualStyleBackColor = false;
            this.btnKiralama.Click += new System.EventHandler(this.btnKiralama_Click);
            // 
            // btnAracListele
            // 
            this.btnAracListele.BackColor = System.Drawing.Color.White;
            this.btnAracListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracListele.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAracListele.ImageIndex = 2;
            this.btnAracListele.ImageList = this.ımageList1;
            this.btnAracListele.Location = new System.Drawing.Point(487, 41);
            this.btnAracListele.Name = "btnAracListele";
            this.btnAracListele.Size = new System.Drawing.Size(146, 150);
            this.btnAracListele.TabIndex = 3;
            this.btnAracListele.Text = "Arac Listeleme";
            this.btnAracListele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAracListele.UseVisualStyleBackColor = false;
            this.btnAracListele.Click += new System.EventHandler(this.btnAracListele_Click);
            // 
            // btnAracKayit
            // 
            this.btnAracKayit.BackColor = System.Drawing.Color.White;
            this.btnAracKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracKayit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAracKayit.ImageIndex = 1;
            this.btnAracKayit.ImageList = this.ımageList1;
            this.btnAracKayit.Location = new System.Drawing.Point(335, 41);
            this.btnAracKayit.Name = "btnAracKayit";
            this.btnAracKayit.Size = new System.Drawing.Size(146, 150);
            this.btnAracKayit.TabIndex = 2;
            this.btnAracKayit.Text = "Arac Kayit";
            this.btnAracKayit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAracKayit.UseVisualStyleBackColor = false;
            this.btnAracKayit.Click += new System.EventHandler(this.btnAracKayit_Click);
            // 
            // btnMusteriListele
            // 
            this.btnMusteriListele.BackColor = System.Drawing.Color.White;
            this.btnMusteriListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriListele.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMusteriListele.ImageIndex = 6;
            this.btnMusteriListele.ImageList = this.ımageList1;
            this.btnMusteriListele.Location = new System.Drawing.Point(164, 41);
            this.btnMusteriListele.Name = "btnMusteriListele";
            this.btnMusteriListele.Size = new System.Drawing.Size(165, 150);
            this.btnMusteriListele.TabIndex = 1;
            this.btnMusteriListele.Text = "Musteri Listeleme";
            this.btnMusteriListele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusteriListele.UseVisualStyleBackColor = false;
            this.btnMusteriListele.Click += new System.EventHandler(this.btnMusteriListele_Click);
            // 
            // btnMusteriEkleme
            // 
            this.btnMusteriEkleme.BackColor = System.Drawing.Color.White;
            this.btnMusteriEkleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriEkleme.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMusteriEkleme.ImageIndex = 0;
            this.btnMusteriEkleme.ImageList = this.ımageList1;
            this.btnMusteriEkleme.Location = new System.Drawing.Point(12, 41);
            this.btnMusteriEkleme.Name = "btnMusteriEkleme";
            this.btnMusteriEkleme.Size = new System.Drawing.Size(146, 150);
            this.btnMusteriEkleme.TabIndex = 0;
            this.btnMusteriEkleme.Text = "Musteri Ekleme";
            this.btnMusteriEkleme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusteriEkleme.UseVisualStyleBackColor = false;
            this.btnMusteriEkleme.Click += new System.EventHandler(this.btnMusteriEkleme_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = global::CarRentalAutomation.Properties.Resources.cars5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1101, 650);
            this.Controls.Add(this.panel1);
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnSatislar;
        private System.Windows.Forms.Button btnKiralama;
        private System.Windows.Forms.Button btnAracListele;
        private System.Windows.Forms.Button btnAracKayit;
        private System.Windows.Forms.Button btnMusteriListele;
        private System.Windows.Forms.Button btnMusteriEkleme;
    }
}

