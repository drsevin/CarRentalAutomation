
namespace CarRentalAutomation
{
    partial class frmAracListele
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAracListele));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nmrcStokAdedi = new System.Windows.Forms.NumericUpDown();
            this.cmbMusteriId = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGunlukFiyat = new System.Windows.Forms.TextBox();
            this.cmbVites = new System.Windows.Forms.ComboBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.cmbRenk = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAracSinifi = new System.Windows.Forms.ComboBox();
            this.cmbFiyatAralik = new System.Windows.Forms.ComboBox();
            this.cmbKmLimit = new System.Windows.Forms.ComboBox();
            this.cmbYakit = new System.Windows.Forms.ComboBox();
            this.btnAracListele = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAracSil = new System.Windows.Forms.Button();
            this.btnAracGuncelle = new System.Windows.Forms.Button();
            this.btnAracIptal = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAracId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcStokAdedi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(527, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1385, 639);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // nmrcStokAdedi
            // 
            this.nmrcStokAdedi.Location = new System.Drawing.Point(218, 851);
            this.nmrcStokAdedi.Name = "nmrcStokAdedi";
            this.nmrcStokAdedi.Size = new System.Drawing.Size(281, 26);
            this.nmrcStokAdedi.TabIndex = 43;
            // 
            // cmbMusteriId
            // 
            this.cmbMusteriId.FormattingEnabled = true;
            this.cmbMusteriId.Location = new System.Drawing.Point(218, 711);
            this.cmbMusteriId.Name = "cmbMusteriId";
            this.cmbMusteriId.Size = new System.Drawing.Size(281, 28);
            this.cmbMusteriId.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(57, 714);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 22);
            this.label10.TabIndex = 41;
            this.label10.Text = "Müşteri ID :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(29, 785);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 22);
            this.label9.TabIndex = 40;
            this.label9.Text = "Günlük Fiyatı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(50, 857);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 22);
            this.label8.TabIndex = 39;
            this.label8.Text = "Stok Adedi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(62, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 22);
            this.label4.TabIndex = 38;
            this.label4.Text = "Vites Tipi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(94, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 37;
            this.label3.Text = "Model :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(93, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 36;
            this.label2.Text = "Marka :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(101, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 35;
            this.label1.Text = "Renk :";
            // 
            // txtGunlukFiyat
            // 
            this.txtGunlukFiyat.Location = new System.Drawing.Point(218, 782);
            this.txtGunlukFiyat.Name = "txtGunlukFiyat";
            this.txtGunlukFiyat.Size = new System.Drawing.Size(281, 26);
            this.txtGunlukFiyat.TabIndex = 34;
            // 
            // cmbVites
            // 
            this.cmbVites.FormattingEnabled = true;
            this.cmbVites.Location = new System.Drawing.Point(218, 370);
            this.cmbVites.Name = "cmbVites";
            this.cmbVites.Size = new System.Drawing.Size(281, 28);
            this.cmbVites.TabIndex = 33;
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(218, 303);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(281, 28);
            this.cmbModel.TabIndex = 32;
            // 
            // cmbMarka
            // 
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(218, 236);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(281, 28);
            this.cmbMarka.TabIndex = 31;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged_1);
            // 
            // cmbRenk
            // 
            this.cmbRenk.FormattingEnabled = true;
            this.cmbRenk.Location = new System.Drawing.Point(218, 169);
            this.cmbRenk.Name = "cmbRenk";
            this.cmbRenk.Size = new System.Drawing.Size(281, 28);
            this.cmbRenk.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(10, 643);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 22);
            this.label11.TabIndex = 51;
            this.label11.Text = "Kilometre Limiti :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(40, 575);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 22);
            this.label7.TabIndex = 50;
            this.label7.Text = "Fiyat Aralığı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(55, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 22);
            this.label6.TabIndex = 49;
            this.label6.Text = "Araç Sınıfı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(54, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 22);
            this.label5.TabIndex = 48;
            this.label5.Text = "Yakıt Türü :";
            // 
            // cmbAracSinifi
            // 
            this.cmbAracSinifi.FormattingEnabled = true;
            this.cmbAracSinifi.Location = new System.Drawing.Point(218, 504);
            this.cmbAracSinifi.Name = "cmbAracSinifi";
            this.cmbAracSinifi.Size = new System.Drawing.Size(281, 28);
            this.cmbAracSinifi.TabIndex = 47;
            // 
            // cmbFiyatAralik
            // 
            this.cmbFiyatAralik.FormattingEnabled = true;
            this.cmbFiyatAralik.Location = new System.Drawing.Point(218, 571);
            this.cmbFiyatAralik.Name = "cmbFiyatAralik";
            this.cmbFiyatAralik.Size = new System.Drawing.Size(281, 28);
            this.cmbFiyatAralik.TabIndex = 46;
            // 
            // cmbKmLimit
            // 
            this.cmbKmLimit.FormattingEnabled = true;
            this.cmbKmLimit.Location = new System.Drawing.Point(218, 640);
            this.cmbKmLimit.Name = "cmbKmLimit";
            this.cmbKmLimit.Size = new System.Drawing.Size(281, 28);
            this.cmbKmLimit.TabIndex = 45;
            // 
            // cmbYakit
            // 
            this.cmbYakit.FormattingEnabled = true;
            this.cmbYakit.Location = new System.Drawing.Point(218, 437);
            this.cmbYakit.Name = "cmbYakit";
            this.cmbYakit.Size = new System.Drawing.Size(281, 28);
            this.cmbYakit.TabIndex = 44;
            // 
            // btnAracListele
            // 
            this.btnAracListele.BackColor = System.Drawing.Color.White;
            this.btnAracListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAracListele.ImageIndex = 0;
            this.btnAracListele.ImageList = this.ımageList1;
            this.btnAracListele.Location = new System.Drawing.Point(841, 829);
            this.btnAracListele.Name = "btnAracListele";
            this.btnAracListele.Size = new System.Drawing.Size(219, 84);
            this.btnAracListele.TabIndex = 54;
            this.btnAracListele.Text = "LİSTELE";
            this.btnAracListele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAracListele.UseVisualStyleBackColor = false;
            this.btnAracListele.Click += new System.EventHandler(this.btnAracListele_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "araclistele.png");
            this.ımageList1.Images.SetKeyName(1, "sil.png");
            this.ımageList1.Images.SetKeyName(2, "iptal.png");
            this.ımageList1.Images.SetKeyName(3, "arabaguncelle (2).jpg");
            // 
            // btnAracSil
            // 
            this.btnAracSil.BackColor = System.Drawing.Color.White;
            this.btnAracSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAracSil.ImageIndex = 1;
            this.btnAracSil.ImageList = this.ımageList1;
            this.btnAracSil.Location = new System.Drawing.Point(1155, 829);
            this.btnAracSil.Name = "btnAracSil";
            this.btnAracSil.Size = new System.Drawing.Size(175, 84);
            this.btnAracSil.TabIndex = 53;
            this.btnAracSil.Text = "SİL";
            this.btnAracSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAracSil.UseVisualStyleBackColor = false;
            this.btnAracSil.Click += new System.EventHandler(this.btnAracSil_Click);
            // 
            // btnAracGuncelle
            // 
            this.btnAracGuncelle.BackColor = System.Drawing.Color.White;
            this.btnAracGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAracGuncelle.ImageIndex = 3;
            this.btnAracGuncelle.ImageList = this.ımageList1;
            this.btnAracGuncelle.Location = new System.Drawing.Point(527, 829);
            this.btnAracGuncelle.Name = "btnAracGuncelle";
            this.btnAracGuncelle.Size = new System.Drawing.Size(219, 84);
            this.btnAracGuncelle.TabIndex = 52;
            this.btnAracGuncelle.Text = "GÜNCELLE";
            this.btnAracGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAracGuncelle.UseVisualStyleBackColor = false;
            this.btnAracGuncelle.Click += new System.EventHandler(this.btnAracGuncelle_Click);
            // 
            // btnAracIptal
            // 
            this.btnAracIptal.BackColor = System.Drawing.Color.White;
            this.btnAracIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAracIptal.ImageIndex = 2;
            this.btnAracIptal.ImageList = this.ımageList1;
            this.btnAracIptal.Location = new System.Drawing.Point(1639, 820);
            this.btnAracIptal.Name = "btnAracIptal";
            this.btnAracIptal.Size = new System.Drawing.Size(175, 102);
            this.btnAracIptal.TabIndex = 55;
            this.btnAracIptal.Text = "İPTAL";
            this.btnAracIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAracIptal.UseVisualStyleBackColor = false;
            this.btnAracIptal.Click += new System.EventHandler(this.btnAracIptal_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(81, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 22);
            this.label12.TabIndex = 57;
            this.label12.Text = "Araç ID :";
            // 
            // txtAracId
            // 
            this.txtAracId.Location = new System.Drawing.Point(218, 112);
            this.txtAracId.Name = "txtAracId";
            this.txtAracId.Size = new System.Drawing.Size(281, 26);
            this.txtAracId.TabIndex = 58;
            // 
            // frmAracListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(1924, 1029);
            this.Controls.Add(this.txtAracId);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnAracIptal);
            this.Controls.Add(this.btnAracListele);
            this.Controls.Add(this.btnAracSil);
            this.Controls.Add(this.btnAracGuncelle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbAracSinifi);
            this.Controls.Add(this.cmbFiyatAralik);
            this.Controls.Add(this.cmbKmLimit);
            this.Controls.Add(this.cmbYakit);
            this.Controls.Add(this.nmrcStokAdedi);
            this.Controls.Add(this.cmbMusteriId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGunlukFiyat);
            this.Controls.Add(this.cmbVites);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.cmbRenk);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmAracListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmAracListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcStokAdedi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown nmrcStokAdedi;
        private System.Windows.Forms.ComboBox cmbMusteriId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGunlukFiyat;
        private System.Windows.Forms.ComboBox cmbVites;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.ComboBox cmbRenk;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAracSinifi;
        private System.Windows.Forms.ComboBox cmbFiyatAralik;
        private System.Windows.Forms.ComboBox cmbKmLimit;
        private System.Windows.Forms.ComboBox cmbYakit;
        private System.Windows.Forms.Button btnAracListele;
        private System.Windows.Forms.Button btnAracSil;
        private System.Windows.Forms.Button btnAracGuncelle;
        private System.Windows.Forms.Button btnAracIptal;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAracId;
    }
}