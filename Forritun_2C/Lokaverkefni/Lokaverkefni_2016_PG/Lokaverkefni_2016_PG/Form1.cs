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
        public Form1()
        {
            List<soluvara> soluvara = new List<soluvara>();
            InitializeComponent();
            snudur snKarmellu = new snudur("Karmella", false, null, 350, 0, "Snúður - Karmella");
            soluvara.Add(snKarmellu);
            snudur snSukkuladi = new snudur("Sukkuladi", false, null, 350, 0, "Snúður - Súkkulaði");
            soluvara.Add(snSukkuladi);
            snudur snGlassur = new snudur("Glassur", false, null, 350, 0, "Snúður - Glassúr");
            soluvara.Add(snGlassur);
            kleinuhringur klKarmellu = new kleinuhringur(false, "Karmella", false, null, 400, 0, "Kleinuhringur - Karmella");
            soluvara.Add(klKarmellu);
            kleinuhringur klKarmelluHol = new kleinuhringur(true, "Karmella", false, null, 400, 0, "Kleinuhringur - Karmella hol midja");
            soluvara.Add(klKarmelluHol);
            kleinuhringur klSukkuladi = new kleinuhringur(false, "Sukkuladi", false, null, 400, 0, "Kleinuhringur - Súkkulaði");
            soluvara.Add(klSukkuladi);
            kleinuhringur klSukkuladiHol = new kleinuhringur(true, "Sukkuladi", false, null, 400, 0, "Kleinuhringur - Súkkulaði hol midja");
            soluvara.Add(klSukkuladiHol);
            kleinuhringur klGlassur = new kleinuhringur(false, "Glassur", false, null, 400, 0, "Kleinuhringur - Glassúr");
            soluvara.Add(klGlassur);
            kleinuhringur klGlassurHol = new kleinuhringur(true, "Glassur", false, null, 400, 0, "Kleinuhringur - Glassúr hol miðjua");
            soluvara.Add(klGlassurHol);
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
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
                Snúður - Karmella
                Snúður - Súkkulaði
                Snúður - Glassúr
                Kleinuhringur - Karmella
                Kleinuhringur - Súkkulaði
                Kleinuhringur - Glassúr
                Vínarbrauð - Lengja
                Vínarbrauð - Sérbakað
                Brauð - Heilhveiti
                Brauð - Heilhveiti sneið
                Brauð - Hvítt
                Brauð - Hvítt sneið
                Kókómjólk -  250ml
                Kókómjólk - 1l
                Kaffi
                Kaffi Svart
                Bjór
             */
        }

        private void byrjaDag_Click(object sender, EventArgs e)
        {

        }
    }
}
