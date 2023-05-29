namespace ArabaOOP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            grbAraclar = new GroupBox();
            cmbKasaTipi = new ComboBox();
            cmbYakitTuru = new ComboBox();
            cmbSanzimanTuru = new ComboBox();
            cmbAracModeli = new ComboBox();
            cmbAracMarkasi = new ComboBox();
            cmbAracTuru = new ComboBox();
            btnResimGoster = new Button();
            ckbGarantisiVar = new CheckBox();
            label10 = new Label();
            button3 = new Button();
            btnAracinResmi = new Button();
            nudMotorGucu = new NumericUpDown();
            nudModelYili = new NumericUpDown();
            label9 = new Label();
            label8 = new Label();
            lblAracinRengi = new Label();
            btnAracinRengi = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            colorDialog1 = new ColorDialog();
            grbAracIncele = new GroupBox();
            lstbAracListesi = new ListBox();
            pcbAracinResmi = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            grbAraclar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMotorGucu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudModelYili).BeginInit();
            grbAracIncele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbAracinResmi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(6, 38);
            label1.Name = "label1";
            label1.Size = new Size(146, 27);
            label1.TabIndex = 0;
            label1.Text = "Araç Türü";
            // 
            // grbAraclar
            // 
            grbAraclar.Controls.Add(cmbKasaTipi);
            grbAraclar.Controls.Add(cmbYakitTuru);
            grbAraclar.Controls.Add(cmbSanzimanTuru);
            grbAraclar.Controls.Add(cmbAracModeli);
            grbAraclar.Controls.Add(cmbAracMarkasi);
            grbAraclar.Controls.Add(cmbAracTuru);
            grbAraclar.Controls.Add(btnResimGoster);
            grbAraclar.Controls.Add(ckbGarantisiVar);
            grbAraclar.Controls.Add(label10);
            grbAraclar.Controls.Add(button3);
            grbAraclar.Controls.Add(btnAracinResmi);
            grbAraclar.Controls.Add(nudMotorGucu);
            grbAraclar.Controls.Add(nudModelYili);
            grbAraclar.Controls.Add(label9);
            grbAraclar.Controls.Add(label8);
            grbAraclar.Controls.Add(lblAracinRengi);
            grbAraclar.Controls.Add(btnAracinRengi);
            grbAraclar.Controls.Add(label6);
            grbAraclar.Controls.Add(label5);
            grbAraclar.Controls.Add(label4);
            grbAraclar.Controls.Add(label3);
            grbAraclar.Controls.Add(label2);
            grbAraclar.Controls.Add(label1);
            grbAraclar.Location = new Point(12, 12);
            grbAraclar.Name = "grbAraclar";
            grbAraclar.Size = new Size(346, 588);
            grbAraclar.TabIndex = 1;
            grbAraclar.TabStop = false;
            grbAraclar.Text = "Araçlar";
            // 
            // cmbKasaTipi
            // 
            cmbKasaTipi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKasaTipi.FormattingEnabled = true;
            cmbKasaTipi.Location = new Point(157, 203);
            cmbKasaTipi.Name = "cmbKasaTipi";
            cmbKasaTipi.Size = new Size(169, 28);
            cmbKasaTipi.TabIndex = 28;
            // 
            // cmbYakitTuru
            // 
            cmbYakitTuru.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYakitTuru.FormattingEnabled = true;
            cmbYakitTuru.Location = new Point(157, 171);
            cmbYakitTuru.Name = "cmbYakitTuru";
            cmbYakitTuru.Size = new Size(169, 28);
            cmbYakitTuru.TabIndex = 27;
            // 
            // cmbSanzimanTuru
            // 
            cmbSanzimanTuru.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSanzimanTuru.FormattingEnabled = true;
            cmbSanzimanTuru.Location = new Point(157, 137);
            cmbSanzimanTuru.Name = "cmbSanzimanTuru";
            cmbSanzimanTuru.Size = new Size(169, 28);
            cmbSanzimanTuru.TabIndex = 26;
            // 
            // cmbAracModeli
            // 
            cmbAracModeli.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAracModeli.FormattingEnabled = true;
            cmbAracModeli.Location = new Point(157, 103);
            cmbAracModeli.Name = "cmbAracModeli";
            cmbAracModeli.Size = new Size(169, 28);
            cmbAracModeli.TabIndex = 25;
            // 
            // cmbAracMarkasi
            // 
            cmbAracMarkasi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAracMarkasi.FormattingEnabled = true;
            cmbAracMarkasi.Location = new Point(157, 71);
            cmbAracMarkasi.Name = "cmbAracMarkasi";
            cmbAracMarkasi.Size = new Size(169, 28);
            cmbAracMarkasi.TabIndex = 24;
            // 
            // cmbAracTuru
            // 
            cmbAracTuru.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAracTuru.FormattingEnabled = true;
            cmbAracTuru.Location = new Point(157, 37);
            cmbAracTuru.Name = "cmbAracTuru";
            cmbAracTuru.Size = new Size(169, 28);
            cmbAracTuru.TabIndex = 23;
            // 
            // btnResimGoster
            // 
            btnResimGoster.BackgroundImageLayout = ImageLayout.Stretch;
            btnResimGoster.Location = new Point(6, 425);
            btnResimGoster.Name = "btnResimGoster";
            btnResimGoster.Size = new Size(320, 157);
            btnResimGoster.TabIndex = 22;
            btnResimGoster.UseVisualStyleBackColor = true;
            // 
            // ckbGarantisiVar
            // 
            ckbGarantisiVar.Location = new Point(158, 343);
            ckbGarantisiVar.Name = "ckbGarantisiVar";
            ckbGarantisiVar.Size = new Size(150, 30);
            ckbGarantisiVar.TabIndex = 21;
            ckbGarantisiVar.Text = "Garantisi Var";
            ckbGarantisiVar.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.Location = new Point(6, 343);
            label10.Name = "label10";
            label10.Size = new Size(131, 27);
            label10.TabIndex = 20;
            label10.Text = "Garanti Durumu";
            // 
            // button3
            // 
            button3.Location = new Point(232, 379);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 19;
            button3.Text = "Oluştur";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnAracinResmi
            // 
            btnAracinResmi.Location = new Point(6, 379);
            btnAracinResmi.Name = "btnAracinResmi";
            btnAracinResmi.Size = new Size(131, 29);
            btnAracinResmi.TabIndex = 18;
            btnAracinResmi.Text = "Aracın Resmi";
            btnAracinResmi.UseVisualStyleBackColor = true;
            btnAracinResmi.Click += btnAracinResmi_Click;
            // 
            // nudMotorGucu
            // 
            nudMotorGucu.Location = new Point(269, 305);
            nudMotorGucu.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            nudMotorGucu.Minimum = new decimal(new int[] { 500, 0, 0, 0 });
            nudMotorGucu.Name = "nudMotorGucu";
            nudMotorGucu.Size = new Size(71, 27);
            nudMotorGucu.TabIndex = 17;
            nudMotorGucu.Value = new decimal(new int[] { 500, 0, 0, 0 });
            nudMotorGucu.ValueChanged += nudMotorGucu_ValueChanged;
            // 
            // nudModelYili
            // 
            nudModelYili.Location = new Point(93, 303);
            nudModelYili.Maximum = new decimal(new int[] { 2050, 0, 0, 0 });
            nudModelYili.Minimum = new decimal(new int[] { 1930, 0, 0, 0 });
            nudModelYili.Name = "nudModelYili";
            nudModelYili.Size = new Size(78, 27);
            nudModelYili.TabIndex = 16;
            nudModelYili.Value = new decimal(new int[] { 1930, 0, 0, 0 });
            nudModelYili.ValueChanged += nudModelYili_ValueChanged;
            // 
            // label9
            // 
            label9.Location = new Point(177, 305);
            label9.Name = "label9";
            label9.Size = new Size(99, 27);
            label9.TabIndex = 15;
            label9.Text = "Motor Gücü:";
            // 
            // label8
            // 
            label8.Location = new Point(6, 305);
            label8.Name = "label8";
            label8.Size = new Size(81, 27);
            label8.TabIndex = 14;
            label8.Text = "Model Yılı";
            // 
            // lblAracinRengi
            // 
            lblAracinRengi.BackColor = Color.Black;
            lblAracinRengi.ForeColor = SystemColors.ControlLight;
            lblAracinRengi.Location = new Point(136, 245);
            lblAracinRengi.Name = "lblAracinRengi";
            lblAracinRengi.Size = new Size(204, 27);
            lblAracinRengi.TabIndex = 13;
            // 
            // btnAracinRengi
            // 
            btnAracinRengi.Location = new Point(6, 245);
            btnAracinRengi.Name = "btnAracinRengi";
            btnAracinRengi.Size = new Size(110, 29);
            btnAracinRengi.TabIndex = 12;
            btnAracinRengi.Text = "Aracın Rengi";
            btnAracinRengi.UseVisualStyleBackColor = true;
            btnAracinRengi.Click += btnAracinRengi_Click;
            // 
            // label6
            // 
            label6.Location = new Point(6, 203);
            label6.Name = "label6";
            label6.Size = new Size(146, 27);
            label6.TabIndex = 10;
            label6.Text = "Kasa Tipi";
            // 
            // label5
            // 
            label5.Location = new Point(6, 170);
            label5.Name = "label5";
            label5.Size = new Size(146, 27);
            label5.TabIndex = 8;
            label5.Text = "Yakıt Türü";
            // 
            // label4
            // 
            label4.Location = new Point(6, 137);
            label4.Name = "label4";
            label4.Size = new Size(146, 27);
            label4.TabIndex = 6;
            label4.Text = "Şanzıman Türü";
            // 
            // label3
            // 
            label3.Location = new Point(6, 104);
            label3.Name = "label3";
            label3.Size = new Size(146, 27);
            label3.TabIndex = 4;
            label3.Text = "Aracın Modeli";
            // 
            // label2
            // 
            label2.Location = new Point(6, 71);
            label2.Name = "label2";
            label2.Size = new Size(146, 27);
            label2.TabIndex = 2;
            label2.Text = "Aracın Markası";
            // 
            // grbAracIncele
            // 
            grbAracIncele.Controls.Add(lstbAracListesi);
            grbAracIncele.Location = new Point(364, 12);
            grbAracIncele.Name = "grbAracIncele";
            grbAracIncele.Size = new Size(353, 588);
            grbAracIncele.TabIndex = 2;
            grbAracIncele.TabStop = false;
            grbAracIncele.Text = "Araç İncele";
            // 
            // lstbAracListesi
            // 
            lstbAracListesi.FormattingEnabled = true;
            lstbAracListesi.HorizontalScrollbar = true;
            lstbAracListesi.ItemHeight = 20;
            lstbAracListesi.Location = new Point(6, 18);
            lstbAracListesi.Name = "lstbAracListesi";
            lstbAracListesi.Size = new Size(338, 564);
            lstbAracListesi.TabIndex = 0;
            lstbAracListesi.MouseDoubleClick += lstbAracListesi_MouseDoubleClick;
            // 
            // pcbAracinResmi
            // 
            pcbAracinResmi.Location = new Point(714, 18);
            pcbAracinResmi.Name = "pcbAracinResmi";
            pcbAracinResmi.Size = new Size(576, 576);
            pcbAracinResmi.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbAracinResmi.TabIndex = 3;
            pcbAracinResmi.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 612);
            Controls.Add(pcbAracinResmi);
            Controls.Add(grbAracIncele);
            Controls.Add(grbAraclar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grbAraclar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudMotorGucu).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudModelYili).EndInit();
            grbAracIncele.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbAracinResmi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox grbAraclar;
        private Button btnResimGoster;
        private CheckBox ckbGarantisiVar;
        private Label label10;
        private Button button3;
        private Button btnAracinResmi;
        private NumericUpDown nudMotorGucu;
        private NumericUpDown nudModelYili;
        private Label label9;
        private Label label8;
        private Label lblAracinRengi;
        private Button btnAracinRengi;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ColorDialog colorDialog1;
        private GroupBox grbAracIncele;
        private ListBox lstbAracListesi;
        private PictureBox pcbAracinResmi;
        private ComboBox cmbKasaTipi;
        private ComboBox cmbYakitTuru;
        private ComboBox cmbSanzimanTuru;
        private ComboBox cmbAracModeli;
        private ComboBox cmbAracMarkasi;
        private ComboBox cmbAracTuru;
        private OpenFileDialog openFileDialog1;
    }
}