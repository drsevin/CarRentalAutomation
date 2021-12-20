
namespace CarRentalAutomation
{
    partial class frmMusteriListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriListele));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMusteriIptal = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnMusteriGuncelle = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.btnMusteriListele = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMusteriAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(446, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1271, 446);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // cmbSehir
            // 
            this.cmbSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Location = new System.Drawing.Point(201, 460);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(223, 28);
            this.cmbSehir.TabIndex = 34;
            this.cmbSehir.SelectedIndexChanged += new System.EventHandler(this.cmbSehir_SelectedIndexChanged);
            this.cmbSehir.SelectionChangeCommitted += new System.EventHandler(this.cmbSehir_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Şehir :";
            // 
            // btnMusteriIptal
            // 
            this.btnMusteriIptal.BackColor = System.Drawing.Color.White;
            this.btnMusteriIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriIptal.ImageIndex = 2;
            this.btnMusteriIptal.ImageList = this.ımageList1;
            this.btnMusteriIptal.Location = new System.Drawing.Point(1590, 544);
            this.btnMusteriIptal.Name = "btnMusteriIptal";
            this.btnMusteriIptal.Size = new System.Drawing.Size(127, 74);
            this.btnMusteriIptal.TabIndex = 32;
            this.btnMusteriIptal.Text = "İPTAL";
            this.btnMusteriIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMusteriIptal.UseVisualStyleBackColor = false;
            this.btnMusteriIptal.Click += new System.EventHandler(this.btnMusteriIptal_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "sil.png");
            this.ımageList1.Images.SetKeyName(1, "musteriGuncelle.png");
            this.ımageList1.Images.SetKeyName(2, "iptal.png");
            this.ımageList1.Images.SetKeyName(3, "musteriListele2.png");
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.BackColor = System.Drawing.Color.White;
            this.btnMusteriGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriGuncelle.ImageIndex = 1;
            this.btnMusteriGuncelle.ImageList = this.ımageList1;
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(78, 544);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(158, 74);
            this.btnMusteriGuncelle.TabIndex = 31;
            this.btnMusteriGuncelle.Text = "GÜNCELLE";
            this.btnMusteriGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMusteriGuncelle.UseVisualStyleBackColor = false;
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.btnMusteriGuncelle_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(201, 398);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(223, 26);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Doğum Günü :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Telefon Numarası :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "TC :";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(201, 336);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(223, 26);
            this.txtTel.TabIndex = 23;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(201, 274);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 26);
            this.txtEmail.TabIndex = 22;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(201, 212);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(223, 26);
            this.txtSoyad.TabIndex = 21;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(201, 150);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(223, 26);
            this.txtAd.TabIndex = 20;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(201, 88);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(223, 26);
            this.txtTC.TabIndex = 19;
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.BackColor = System.Drawing.Color.White;
            this.btnMusteriSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriSil.ImageIndex = 0;
            this.btnMusteriSil.ImageList = this.ımageList1;
            this.btnMusteriSil.Location = new System.Drawing.Point(446, 544);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(114, 74);
            this.btnMusteriSil.TabIndex = 35;
            this.btnMusteriSil.Text = "SİL";
            this.btnMusteriSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMusteriSil.UseVisualStyleBackColor = false;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // btnMusteriListele
            // 
            this.btnMusteriListele.BackColor = System.Drawing.Color.White;
            this.btnMusteriListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriListele.ImageIndex = 3;
            this.btnMusteriListele.ImageList = this.ımageList1;
            this.btnMusteriListele.Location = new System.Drawing.Point(266, 544);
            this.btnMusteriListele.Name = "btnMusteriListele";
            this.btnMusteriListele.Size = new System.Drawing.Size(158, 74);
            this.btnMusteriListele.TabIndex = 36;
            this.btnMusteriListele.Text = "LİSTELE";
            this.btnMusteriListele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMusteriListele.UseVisualStyleBackColor = false;
            this.btnMusteriListele.Click += new System.EventHandler(this.btnMusteriListele_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(681, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "TC İLE ARA  :";
            // 
            // txtMusteriAra
            // 
            this.txtMusteriAra.Location = new System.Drawing.Point(837, 41);
            this.txtMusteriAra.Name = "txtMusteriAra";
            this.txtMusteriAra.Size = new System.Drawing.Size(223, 26);
            this.txtMusteriAra.TabIndex = 37;
            this.txtMusteriAra.TextChanged += new System.EventHandler(this.txtMusteriAra_TextChanged);
            // 
            // frmMusteriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(1728, 679);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMusteriAra);
            this.Controls.Add(this.btnMusteriListele);
            this.Controls.Add(this.btnMusteriSil);
            this.Controls.Add(this.cmbSehir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnMusteriIptal);
            this.Controls.Add(this.btnMusteriGuncelle);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMusteriListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMusteriListele";
            this.Load += new System.EventHandler(this.frmMusteriListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbSehir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMusteriIptal;
        private System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Button btnMusteriSil;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnMusteriListele;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMusteriAra;
    }
}