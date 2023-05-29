using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaOOP
{
    public class Arac
    {
        public static List<string> AracBilgileri = new List<string>();
        public static List<Arac> Araclar = new List<Arac>();
        public AracTuru aracTuru { get; set; }
        public Marka marka { get; set; }
        public Model model { get; set; }
        public SanzimanTuru sanzimanTuru { get; set; }
        public YakitTuru yakitTuru { get; set;}
        public KasaTipi kasaTipi { get; set;}
        public ColorDialog AracinRengi { get; set; }

        private int ModelYili;
        public bool GarantiDurumu { get; set; }

        public int modelYili
        {
            get { return ModelYili; }
            set
            {
                if (value < 2005)
                {
                    MessageBox.Show("2005 yılından küçük araç işlem görmemektedir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (value > DateTime.Now.Year)
                {
                    MessageBox.Show("Araç modeli günümüz tarihinden ileri olamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else ModelYili = value;
            }
        }

        private int MotorGucu;

        public int motorGucu
        {
            get { return MotorGucu; }
            set { 
                if (value < 1000)
                {
                    MessageBox.Show("Motor Gücü en az  1000 olabilir","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else MotorGucu = value;
            }
        }
    }
}
