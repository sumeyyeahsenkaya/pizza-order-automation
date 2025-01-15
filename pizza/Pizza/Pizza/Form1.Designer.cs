namespace Pizza
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.isimText = new System.Windows.Forms.TextBox();
            this.soyisimText = new System.Windows.Forms.TextBox();
            this.pizzaKombo = new System.Windows.Forms.ComboBox();
            this.hamurKombo = new System.Windows.Forms.ComboBox();
            this.adetKombo = new System.Windows.Forms.ComboBox();
            this.icecekKombo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pizzasecim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hamurtip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boyut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iceceksecim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.boyutKombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-11, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 702);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(643, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sipariş Kayıtları";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(650, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(649, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(650, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pizza Seçimi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(649, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "Hamur Tipi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(648, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 26);
            this.label7.TabIndex = 8;
            this.label7.Text = "Adet:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(648, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 26);
            this.label8.TabIndex = 9;
            this.label8.Text = "İçecek Seçimi:";
            // 
            // isimText
            // 
            this.isimText.Location = new System.Drawing.Point(848, 89);
            this.isimText.Name = "isimText";
            this.isimText.Size = new System.Drawing.Size(137, 22);
            this.isimText.TabIndex = 15;
            // 
            // soyisimText
            // 
            this.soyisimText.Location = new System.Drawing.Point(848, 126);
            this.soyisimText.Name = "soyisimText";
            this.soyisimText.Size = new System.Drawing.Size(137, 22);
            this.soyisimText.TabIndex = 16;
            // 
            // pizzaKombo
            // 
            this.pizzaKombo.FormattingEnabled = true;
            this.pizzaKombo.Items.AddRange(new object[] {
            "Sucuklu",
            "Karışık",
            "Tavuklu",
            "Kaşarlı",
            "Vegan"});
            this.pizzaKombo.Location = new System.Drawing.Point(848, 166);
            this.pizzaKombo.Name = "pizzaKombo";
            this.pizzaKombo.Size = new System.Drawing.Size(137, 24);
            this.pizzaKombo.TabIndex = 19;
            // 
            // hamurKombo
            // 
            this.hamurKombo.FormattingEnabled = true;
            this.hamurKombo.Items.AddRange(new object[] {
            "Klasik ",
            "İnce"});
            this.hamurKombo.Location = new System.Drawing.Point(848, 204);
            this.hamurKombo.Name = "hamurKombo";
            this.hamurKombo.Size = new System.Drawing.Size(137, 24);
            this.hamurKombo.TabIndex = 20;
            // 
            // adetKombo
            // 
            this.adetKombo.FormattingEnabled = true;
            this.adetKombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.adetKombo.Location = new System.Drawing.Point(848, 280);
            this.adetKombo.Name = "adetKombo";
            this.adetKombo.Size = new System.Drawing.Size(137, 24);
            this.adetKombo.TabIndex = 21;
            // 
            // icecekKombo
            // 
            this.icecekKombo.FormattingEnabled = true;
            this.icecekKombo.Items.AddRange(new object[] {
            "Coca Cola",
            "Coca Cola Light",
            "Fanta",
            "Sprite",
            "Maden Suyu",
            "Su"});
            this.icecekKombo.Location = new System.Drawing.Point(848, 322);
            this.icecekKombo.Name = "icecekKombo";
            this.icecekKombo.Size = new System.Drawing.Size(137, 24);
            this.icecekKombo.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ad,
            this.soyad,
            this.pizzasecim,
            this.hamurtip,
            this.boyut,
            this.adet,
            this.iceceksecim});
            this.dataGridView1.Location = new System.Drawing.Point(417, 377);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(950, 160);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ad
            // 
            this.ad.HeaderText = "AD";
            this.ad.MinimumWidth = 6;
            this.ad.Name = "ad";
            this.ad.Width = 125;
            // 
            // soyad
            // 
            this.soyad.HeaderText = "SOYAD";
            this.soyad.MinimumWidth = 6;
            this.soyad.Name = "soyad";
            this.soyad.Width = 125;
            // 
            // pizzasecim
            // 
            this.pizzasecim.HeaderText = "PİZZA SEÇİMİ";
            this.pizzasecim.MinimumWidth = 6;
            this.pizzasecim.Name = "pizzasecim";
            this.pizzasecim.Width = 125;
            // 
            // hamurtip
            // 
            this.hamurtip.HeaderText = "HAMUR TİPİ";
            this.hamurtip.MinimumWidth = 6;
            this.hamurtip.Name = "hamurtip";
            this.hamurtip.Width = 90;
            // 
            // boyut
            // 
            this.boyut.HeaderText = "BOYUT";
            this.boyut.MinimumWidth = 6;
            this.boyut.Name = "boyut";
            this.boyut.Width = 70;
            // 
            // adet
            // 
            this.adet.HeaderText = "ADET";
            this.adet.MinimumWidth = 6;
            this.adet.Name = "adet";
            this.adet.Width = 50;
            // 
            // iceceksecim
            // 
            this.iceceksecim.HeaderText = "İÇECEK";
            this.iceceksecim.MinimumWidth = 6;
            this.iceceksecim.Name = "iceceksecim";
            this.iceceksecim.Width = 95;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Location = new System.Drawing.Point(653, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 57);
            this.button1.TabIndex = 24;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button2.Location = new System.Drawing.Point(829, 553);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 57);
            this.button2.TabIndex = 25;
            this.button2.Text = "ÇIKIŞ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(650, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 26);
            this.label5.TabIndex = 26;
            this.label5.Text = "Boyut:";
            // 
            // boyutKombo
            // 
            this.boyutKombo.FormattingEnabled = true;
            this.boyutKombo.Items.AddRange(new object[] {
            "Küçük",
            "Orta ",
            "Büyük"});
            this.boyutKombo.Location = new System.Drawing.Point(848, 243);
            this.boyutKombo.Name = "boyutKombo";
            this.boyutKombo.Size = new System.Drawing.Size(137, 24);
            this.boyutKombo.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1382, 700);
            this.Controls.Add(this.boyutKombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.icecekKombo);
            this.Controls.Add(this.adetKombo);
            this.Controls.Add(this.hamurKombo);
            this.Controls.Add(this.pizzaKombo);
            this.Controls.Add(this.soyisimText);
            this.Controls.Add(this.isimText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox isimText;
        private System.Windows.Forms.TextBox soyisimText;
        private System.Windows.Forms.ComboBox pizzaKombo;
        private System.Windows.Forms.ComboBox hamurKombo;
        private System.Windows.Forms.ComboBox adetKombo;
        private System.Windows.Forms.ComboBox icecekKombo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox boyutKombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn pizzasecim;
        private System.Windows.Forms.DataGridViewTextBoxColumn hamurtip;
        private System.Windows.Forms.DataGridViewTextBoxColumn boyut;
        private System.Windows.Forms.DataGridViewTextBoxColumn adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn iceceksecim;
    }
}

