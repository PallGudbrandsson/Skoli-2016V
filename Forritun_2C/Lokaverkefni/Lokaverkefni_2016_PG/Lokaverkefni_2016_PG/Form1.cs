using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace Lokaverkefni_2016_PG
{
    public partial class Form1 : Form
    {
        //Skilgreini global breytur
        Random rand = new Random();
        List<soluvara> soluvara = new List<soluvara>();
        int[] magn = new int[17];
        int inkomaDags = 0;
        List<string> nafnVoru = new List<string>();

        public Form1()
        {
            
            InitializeComponent();
            snudur snKarmellu = new snudur("Karmella", false, null, 350, 0, "Snúður - Karmella");
            soluvara.Add(snKarmellu);
            snudur snSukkuladi = new snudur("Sukkuladi", false, null, 350, 0, "Snúður - Súkkulaði");
            soluvara.Add(snSukkuladi);
            snudur snGlassur = new snudur("Glassur", false, null, 350, 0, "Snúður - Glassúr");
            soluvara.Add(snGlassur);
            kleinuhringur klKarmellu = new kleinuhringur(false, "Karmella", false, null, 400, 0, "Kleinuhringur - Karmella");
            soluvara.Add(klKarmellu);
            kleinuhringur klSukkuladi = new kleinuhringur(false, "Sukkuladi", false, null, 400, 0, "Kleinuhringur - Súkkulaði");
            soluvara.Add(klSukkuladi);
            kleinuhringur klGlassur = new kleinuhringur(false, "Glassur", false, null, 400, 0, "Kleinuhringur - Glassúr");
            soluvara.Add(klGlassur);
            vinabraud vinarbraud = new vinabraud(false, false, null, 750, 0, "Vínarbrauð - Lengja");
            soluvara.Add(vinarbraud);
            vinabraud serbakadvinabraud = new vinabraud(true, false, null, 600, 0, "Vínarbrauð - Sérbakað");
            soluvara.Add(serbakadvinabraud);
            braud heilhveiti = new braud("Heilhveiti", false, 15, true, null, 950, 0, "Brauð - Heilhveiti");
            soluvara.Add(heilhveiti);
            braud heilhveitiSneid = new braud("Heilhveiti", true, 1, true, null, 100, 0, "Brauð - Heilhveiti sneið");
            soluvara.Add(heilhveitiSneid);
            braud hvitt = new braud("Hvitt", false, 15, true, null, 1000, 0, "Brauð - Hvítt");
            soluvara.Add(hvitt);
            braud hvittSneid = new braud("Hvitt", true, 1, false, null, 110, 0, "Brauð - Hvítt sneið");
            soluvara.Add(hvittSneid);
            drykkir kokomjolk250 = new drykkir(false, false, 250, 350, 2147483647, "Kókómjólk -  250ml");
            soluvara.Add(kokomjolk250);
            drykkir kokomjolk1l = new drykkir(false, false, 1000, 500, 2147483647, "Kókómjólk - 1l");
            soluvara.Add(kokomjolk1l);
            drykkir kaffi = new drykkir(false, false, 250, 600, 2147483647, "Kaffi");
            soluvara.Add(kaffi);
            drykkir svartKaffi = new drykkir(false, true, 250, 750, 2147483647, "Kaffi Svart");
            soluvara.Add(svartKaffi);
            drykkir bjor = new drykkir(true, true, 1000, 1500, 2147483647, "Bjór");
            soluvara.Add(bjor);

            //upphafs stillingar
            slokkvaATokkum();
            
        }
        public void slokkvaATokkum()
        {
            endaDag.Enabled = false;
            klaraVidskipti.Enabled = false;
            byrjaVidskipti.Enabled = false;
            slokkvaASolu();
        }
        public void kveikjaATokkum()
        {
            endaDag.Enabled = true;
            klaraVidskipti.Enabled = true;
            byrjaVidskipti.Enabled = true;
        }
        public void veljaNumer()//velur numer til ad vera virkt
        {
            label_virktNumer.Text = (rand.Next(1, 101)).ToString();
        }
        private void kveikjaASolu()
        {
            vara.Enabled = true;
            magnMinus.Enabled = true;
            magnPlus.Enabled = true;
            kvittun.Enabled = true;
        }
        private void slokkvaASolu()
        {
            vara.Enabled = false;
            magnMinus.Enabled = false;
            magnPlus.Enabled = false;
            kvittun.Enabled = false;
        }
        public void stillaMagn()//Setur magnid a ollum vorum i formid
        {
            List<int> thing = new List<int>();//placeholder fyrir allar vorur
            for (int i = 0; i < soluvara.Count; i++)
            {
                thing.Add(soluvara[i].Magn);
            }
            label_snKarmellu.Text = thing[0].ToString();
            label_snSukkuladi.Text = thing[1].ToString();
            label_snGlassur.Text = thing[2].ToString();
            label_klKarmella.Text = thing[3].ToString();
            label_klSukkuladi.Text = thing[4].ToString();
            label_klGlassur.Text = thing[5].ToString();
            label_vinabraud.Text = thing[6].ToString();
            label_vinabraudSerbakad.Text = thing[7].ToString();
            label_braudHeilhveiti.Text = thing[8].ToString();
            label_braudHeilhveitiSneid.Text = thing[9].ToString();
            label_braudHvitt.Text = thing[10].ToString();
            label_braudHvittSneid.Text = thing[11].ToString();
            thing.Clear();
            
        }
        public void skrifa()//Skrifar kvittun vidskiptavins ut i rauntima
        {
            kvittun.Text = null;
            for (int i = 0; i < soluvara.Count; i++)
            {
                if (magn[i]!=0)
                {
                    kvittun.Text += soluvara[i].Nafn + "   " + magn[i]+ "\n";
                }
            }
        }

        private void byrjaDag_Click(object sender, EventArgs e)//stillir magn a ollum vorum
        {
            for (int i = 0; i < soluvara.Count; i++)
            {
                soluvara[i].Magn = rand.Next(10, 36);
            }
            stillaMagn();
            kveikjaATokkum();
            veljaNumer();
            endaDag.Enabled = false;
            klaraVidskipti.Enabled = false;
            byrjaDag.Enabled = false;
        }
        
        private void byrjaVidskipti_Click(object sender, EventArgs e)
        {
            int activeNum = Convert.ToInt32(label_virktNumer.Text);
            int userNum = rand.Next(activeNum + 5, activeNum + 20);


            while (activeNum != userNum)
            {
                int sleeptime = rand.Next(100, 600);
                System.Threading.Thread.Sleep(sleeptime);
                activeNum++;
                label_vidskiptavinurNumer.Text = userNum.ToString();
                label_virktNumer.Text = activeNum.ToString();
                Application.DoEvents();
            }
            kveikjaASolu();
            kveikjaATokkum();
            byrjaVidskipti.Enabled = false;
            klaraVidskipti.Enabled = true;
            byrjaDag.Enabled = false;
        }

        private void endaDag_Click(object sender, EventArgs e)//Setur magnid a ollu sem 0 og prentar kvittunn fyrir daginn hvað það seldist fyrir mikið of hvað það er mikið eftir
        {
            string s = "Eftirstandandi er \n";
            //prenta kvittun fyrir allt sem er eftir og heildar solu
            for (int i = 0; i < soluvara.Count; i++)
            {
                s += soluvara[i].Nafn + "  " + soluvara[i].Magn + "\n";
                soluvara[i].Magn = 0;
            }
            s += inkomaDags.ToString();
            MessageBox.Show(s);
            for (int i = 0; i < soluvara.Count; i++)
            {
                soluvara[i].Magn = 0;
            }
            stillaMagn();
            slokkvaATokkum();
            byrjaDag.Enabled = true;
            endaDag.Enabled = false;
            //stilla heildarmagn a ollu sem 0
        }

        private void klaraVidskipti_Click(object sender, EventArgs e)//Fer gegnum lista af ollum vorum sem vidskiptavinurinn er ad kaupa og prentar verd og kvittun
        {
            int heild = 0;
            
            for (int i = 0; i < soluvara.Count; i++)
            {
                if (magn[i]!=0)
                {
                    soluvara[i].Magn -= magn[i];
                    heild += soluvara[i].Verd * magn[i];
                }
            }
            MessageBox.Show(kvittun.Text + heild);
            inkomaDags += heild;
            stillaMagn();

            for (int i = 0; i < magn.Length; i++)//nullstillir allt magn sem vidskiptavinur er ad kaupa
            {
                magn[i] = 0;
            }
            kvittun.Text = null;
            vara.Text = null;
            label_magnVoru.Text = "0";
            veljaNumer();
            byrjaVidskipti.Enabled = true;
            klaraVidskipti.Enabled = false;
        }

        private void magnMinus_Click(object sender, EventArgs e)
        {
            string s = vara.Text;

            for (int i = 0; i < soluvara.Count; i++)
            {
                if (soluvara[i].Nafn == s && magn[i]!=0)
                {
                    magn[i] -=1;
                    label_magnVoru.Text = magn[i].ToString();
                    break;
                }
            }
            Application.DoEvents();
            skrifa();
        }

        private void magnPlus_Click(object sender, EventArgs e)
        {
            string s = vara.Text;

            for (int i = 0; i < soluvara.Count; i++)
            {
                if (soluvara[i].Nafn == s && magn[i] < soluvara[i].Magn)
                {
                    magn[i] +=1;
                    label_magnVoru.Text = magn[i].ToString();
                    break;
                }
            }
            Application.DoEvents();
            skrifa();
        }
    }
}
