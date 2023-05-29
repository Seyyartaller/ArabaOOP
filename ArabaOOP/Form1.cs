using System.Collections;
using System.Reflection;

namespace ArabaOOP
{
    public partial class Form1 : Form
    {
        Arac arac = new Arac();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OzellikAta();
            nudModelYili.Value = 2005;
            nudMotorGucu.Value = 1000;
        }


        public void OzellikAta()
        {
            cmbAracTuru.DataSource = Enum.GetValues(typeof(AracTuru));
            cmbAracTuru.SelectedIndex = -1;

            cmbAracMarkasi.DataSource = Enum.GetValues(typeof(Marka));
            cmbAracMarkasi.SelectedIndex = -1;

            cmbAracModeli.DataSource = Enum.GetValues(typeof(Model));
            cmbAracModeli.SelectedIndex = -1;

            cmbSanzimanTuru.DataSource = Enum.GetValues(typeof(SanzimanTuru));
            cmbSanzimanTuru.SelectedIndex = -1;

            cmbYakitTuru.DataSource = Enum.GetValues(typeof(YakitTuru));
            cmbYakitTuru.SelectedIndex = -1;

            cmbKasaTipi.DataSource = Enum.GetValues(typeof(KasaTipi));
            cmbKasaTipi.SelectedIndex = -1;
        }

        private void btnAracinRengi_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                lblAracinRengi.BackColor = colorDialog1.Color;
            }
        }

        private void AracOlustur()
        {
            Arac.Araclar.Add(new Arac
            {
                aracTuru = (AracTuru)cmbAracTuru.SelectedItem,
                marka = (Marka)cmbAracMarkasi.SelectedItem,
                model = (Model)cmbAracModeli.SelectedItem,
                sanzimanTuru = (SanzimanTuru)cmbSanzimanTuru.SelectedItem,
                yakitTuru = (YakitTuru)cmbYakitTuru.SelectedItem,
                kasaTipi = (KasaTipi)cmbKasaTipi.SelectedItem,
                modelYili = (int)nudModelYili.Value,
                motorGucu = (int)nudMotorGucu.Value,
                GarantiDurumu = ckbGarantisiVar.Checked,
                AracinRengi = colorDialog1
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (nudModelYili.Value >= 2005 && nudModelYili.Value <= (decimal)DateTime.Now.Year && nudMotorGucu.Value >= 1000)
                AracOlustur();
            else
                MessageBox.Show("Araç oluþturulamadý, lütfen hatalý kýsýmlarý düzeltip tekrar deneyiniz", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            lstbAracListesi.Items.Clear();
            foreach (var arac in Arac.Araclar)
            {
                string aracInfo = $"Arac Türü: {arac.aracTuru}, Marka: {arac.marka}, Model: {arac.model}, " +
                                  $"Þanzýman Türü: {arac.sanzimanTuru}, Yakýt Türü: {arac.yakitTuru}, " +
                                  $"Kasa Tipi: {arac.kasaTipi}, Model Yýlý: {arac.modelYili}, " +
                                  $"Motor Gücü: {arac.motorGucu}, Garanti Durumu: {(arac.GarantiDurumu ? "Var" : "Yok")} ";

                lstbAracListesi.Items.Add(aracInfo);
            }

        }

        private void nudModelYili_ValueChanged(object sender, EventArgs e)
        {
            arac.modelYili = (int)nudModelYili.Value;
        }

        private void nudMotorGucu_ValueChanged(object sender, EventArgs e)
        {
            arac.motorGucu = (int)nudMotorGucu.Value;
        }

        private void btnAracinResmi_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                btnResimGoster.BackgroundImage = Image.FromFile(file.FileName);
                pcbAracinResmi.Image = Image.FromFile(file.FileName);
            }
        }

        private void lstbAracListesi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lstbAracListesi.SelectedIndex;
            Arac arac = new Arac();
            arac = Arac.Araclar[index];
            cmbAracTuru.Text = arac.aracTuru.ToString();
            cmbAracMarkasi.Text = arac.marka.ToString();
            cmbAracModeli.Text = arac.model.ToString();
            cmbSanzimanTuru.Text = arac.sanzimanTuru.ToString();
            cmbYakitTuru.Text = arac.yakitTuru.ToString();
            cmbKasaTipi.Text = arac.kasaTipi.ToString();
            nudModelYili.Value = arac.modelYili;
            nudMotorGucu.Value = arac.motorGucu;
            ckbGarantisiVar.Checked = arac.GarantiDurumu;
            lblAracinRengi.BackColor = arac.AracinRengi.Color;
        }
    }
}