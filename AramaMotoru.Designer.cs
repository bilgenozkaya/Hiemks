namespace bitirme_bilgen
{
    partial class AramaMotoru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AramaMotoru));
            this.btnEtkenMaddeAra = new System.Windows.Forms.Button();
            this.txtEtkenMaddeArama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUyari = new System.Windows.Forms.Label();
            this.lstbIlacListele = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enÇokArananEtkenMaddeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enAzArananEtkenMaddeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.pgbIlacListele = new System.Windows.Forms.ProgressBar();
            this.lblSurec = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEtkenMaddeAra
            // 
            this.btnEtkenMaddeAra.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEtkenMaddeAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEtkenMaddeAra.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnEtkenMaddeAra.Location = new System.Drawing.Point(832, 118);
            this.btnEtkenMaddeAra.Name = "btnEtkenMaddeAra";
            this.btnEtkenMaddeAra.Size = new System.Drawing.Size(96, 33);
            this.btnEtkenMaddeAra.TabIndex = 2;
            this.btnEtkenMaddeAra.Text = "ARA";
            this.btnEtkenMaddeAra.UseVisualStyleBackColor = false;
            this.btnEtkenMaddeAra.Click += new System.EventHandler(this.btnEtkenMaddeAra_Click);
            // 
            // txtEtkenMaddeArama
            // 
            this.txtEtkenMaddeArama.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEtkenMaddeArama.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEtkenMaddeArama.Location = new System.Drawing.Point(69, 118);
            this.txtEtkenMaddeArama.Name = "txtEtkenMaddeArama";
            this.txtEtkenMaddeArama.Size = new System.Drawing.Size(757, 32);
            this.txtEtkenMaddeArama.TabIndex = 1;
            this.txtEtkenMaddeArama.Text = "Arama Yapabilmek Icin Bir Tusa Basiniz ve Etken Maddeyi Giriniz!!!";
            this.txtEtkenMaddeArama.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtEtkenMaddeArama_MouseClick);
            this.txtEtkenMaddeArama.ModifiedChanged += new System.EventHandler(this.txtEtkenMaddeArama_ModifiedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(80, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(786, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hamileler İçin Etken Madde Arama Motoru";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(263, 176);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(55, 17);
            this.listBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(65, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "UYARI :";
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.BackColor = System.Drawing.Color.Transparent;
            this.lblUyari.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUyari.Location = new System.Drawing.Point(64, 250);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(59, 24);
            this.lblUyari.TabIndex = 5;
            this.lblUyari.Text = "!!!!!!!";
            // 
            // lstbIlacListele
            // 
            this.lstbIlacListele.ColumnWidth = 1;
            this.lstbIlacListele.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lstbIlacListele.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstbIlacListele.FormattingEnabled = true;
            this.lstbIlacListele.ItemHeight = 17;
            this.lstbIlacListele.Location = new System.Drawing.Point(527, 210);
            this.lstbIlacListele.Name = "lstbIlacListele";
            this.lstbIlacListele.Size = new System.Drawing.Size(401, 242);
            this.lstbIlacListele.Sorted = true;
            this.lstbIlacListele.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(523, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "İlgili İlaçlar :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.araçlarToolStripMenuItem,
            this.yardımToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(972, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // araçlarToolStripMenuItem
            // 
            this.araçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enÇokArananEtkenMaddeToolStripMenuItem,
            this.enAzArananEtkenMaddeToolStripMenuItem});
            this.araçlarToolStripMenuItem.Name = "araçlarToolStripMenuItem";
            this.araçlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.araçlarToolStripMenuItem.Text = "Araçlar";
            // 
            // enÇokArananEtkenMaddeToolStripMenuItem
            // 
            this.enÇokArananEtkenMaddeToolStripMenuItem.Name = "enÇokArananEtkenMaddeToolStripMenuItem";
            this.enÇokArananEtkenMaddeToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.enÇokArananEtkenMaddeToolStripMenuItem.Text = "En Çok Aranan Etken Maddeler";
            this.enÇokArananEtkenMaddeToolStripMenuItem.Click += new System.EventHandler(this.enÇokArananEtkenMaddeToolStripMenuItem_Click);
            // 
            // enAzArananEtkenMaddeToolStripMenuItem
            // 
            this.enAzArananEtkenMaddeToolStripMenuItem.Name = "enAzArananEtkenMaddeToolStripMenuItem";
            this.enAzArananEtkenMaddeToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.enAzArananEtkenMaddeToolStripMenuItem.Text = "En Az Aranan Etken Maddeler";
            this.enAzArananEtkenMaddeToolStripMenuItem.Click += new System.EventHandler(this.enAzArananEtkenMaddeToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tamToolStripMenuItem,
            this.çıkışToolStripMenuItem1});
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // tamToolStripMenuItem
            // 
            this.tamToolStripMenuItem.Name = "tamToolStripMenuItem";
            this.tamToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.tamToolStripMenuItem.Text = "Tam Çıkış";
            this.tamToolStripMenuItem.Click += new System.EventHandler(this.tamçıkışToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem1
            // 
            this.çıkışToolStripMenuItem1.Name = "çıkışToolStripMenuItem1";
            this.çıkışToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.çıkışToolStripMenuItem1.Text = "Çıkış";
            this.çıkışToolStripMenuItem1.Click += new System.EventHandler(this.çıkışToolStripMenuItem1_Click);
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(777, 3);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(89, 19);
            this.lblKullaniciAdi.TabIndex = 10;
            this.lblKullaniciAdi.Text = "kullanici adi";
            // 
            // pgbIlacListele
            // 
            this.pgbIlacListele.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pgbIlacListele.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pgbIlacListele.Location = new System.Drawing.Point(527, 198);
            this.pgbIlacListele.Name = "pgbIlacListele";
            this.pgbIlacListele.Size = new System.Drawing.Size(401, 12);
            this.pgbIlacListele.Step = 1;
            this.pgbIlacListele.TabIndex = 11;
            // 
            // lblSurec
            // 
            this.lblSurec.AutoSize = true;
            this.lblSurec.Location = new System.Drawing.Point(935, 198);
            this.lblSurec.Name = "lblSurec";
            this.lblSurec.Size = new System.Drawing.Size(0, 13);
            this.lblSurec.TabIndex = 12;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(65, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "GEBELİK KATEGORİSİ :";
            // 
            // AramaMotoru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(972, 542);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSurec);
            this.Controls.Add(this.pgbIlacListele);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstbIlacListele);
            this.Controls.Add(this.lblUyari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEtkenMaddeArama);
            this.Controls.Add(this.btnEtkenMaddeAra);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AramaMotoru";
            this.Text = "Hamileler İçin Etken Madde Arama Motoru";
            this.Load += new System.EventHandler(this.AramaMotoru_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEtkenMaddeAra;
        private System.Windows.Forms.TextBox txtEtkenMaddeArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUyari;
        private System.Windows.Forms.ListBox lstbIlacListele;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enÇokArananEtkenMaddeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enAzArananEtkenMaddeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        public System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.ProgressBar pgbIlacListele;
        private System.Windows.Forms.Label lblSurec;
        private System.Windows.Forms.ToolStripMenuItem tamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
    }
}