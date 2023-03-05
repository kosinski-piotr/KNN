using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Zad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cbMetodaWczytania.DataSource = Enum.GetValues(typeof(MetodaWczytywaniaRepozytorium));            
            
        }


        string sciezkaDoPliku;
        public string SciezkaDoPliku
        {
            get
            {
                return this.sciezkaDoPliku;
            }

            set
            {
                if (!System.IO.File.Exists(value))
                {
                    this.sciezkaDoPliku = "";
                    this.btnAnaliza.Enabled = false;
                    this.tbSciezkaPlikuRepozytorium.Text = "";

                    return;
                }

                this.sciezkaDoPliku = value;
                btnAnaliza.Enabled = true;
                tbSciezkaPlikuRepozytorium.Text = value;
            }
        }

        private void btnWybierzPlik_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            this.SciezkaDoPliku = ofd.FileName;

            Obiekt.cnf = new Config();

            var tmp = System.IO.File.ReadAllLines(ofd.FileName);
            var ob = new Obiekt(tmp.First(), (MetodaWczytywaniaRepozytorium)Enum.Parse(typeof(MetodaWczytywaniaRepozytorium), cbMetodaWczytania.SelectedValue.ToString()));

            for (int i = 0; i < ob.wartosci.Length; i++)
            {
                clbAtrybutyDoPominiecia.Items.Add(
                    new KeyValuePair<string, int>($"Atrybut [{i}] = {ob.wartosci[i]}" , i)
                );
                clbAtrybutyDoPominiecia.DisplayMember = "Key";
            }

        }

        static Obiekt[] obiekty;
         Obiekt[] podaneWartosci;
        static public int ilosc;
        private void btnAnaliza_Click(object sender, EventArgs e)
        {
            int pominiete = 0;
            for (int i = 0; i < clbAtrybutyDoPominiecia.CheckedItems.Count; i++)
            {
                var tmp = (KeyValuePair<string, int>)clbAtrybutyDoPominiecia.CheckedItems[i];
                Obiekt.cnf.AtrybutyPominiete.Add(tmp.Value);
                pominiete++;
            }

            var linie = System.IO.File.ReadAllLines(this.SciezkaDoPliku);

            obiekty = new Obiekt[linie.Length];

            ilosc = clbAtrybutyDoPominiecia.Items.Count - pominiete;

            MetodaWczytywaniaRepozytorium metoda = (MetodaWczytywaniaRepozytorium)Enum.Parse(typeof(MetodaWczytywaniaRepozytorium), cbMetodaWczytania.SelectedValue.ToString());


            for (int i = 0; i < linie.Length; i++)
            {
                obiekty[i] = new Obiekt(linie[i], metoda);
            }


            Obiekt.ZamienSymboliczneNaNumeryczne(obiekty);
            Obiekt.ZnajdzMinMaxWNumerycznych(obiekty);




            Obiekt.Normalizacja(obiekty, (double)nudMi.Value, (double)nudMa.Value);




            var str = Newtonsoft.Json.JsonConvert.SerializeObject(Obiekt.cnf);

            System.IO.File.WriteAllText(this.SciezkaDoPliku + ".json", str);

            btnKnn.Enabled = true;
            btn1vsr.Enabled = true;
        }

        public int metryka;

        private void btnKnn_Click(object sender, EventArgs e)
        {
            int P = int.Parse(warP.Text);
            int K = int.Parse(warK.Text);

            this.podaneWartosci = new Obiekt[1];

            var noweDane = dane.Text;
            noweDane = noweDane + " ?";

            this.podaneWartosci[0] = new Obiekt(noweDane);

            podaneWartosci[0].przypisz(noweDane, Obiekt.cnf.AtrybutyPominiete, clbAtrybutyDoPominiecia.Items.Count);

            Obiekt.ZamienSymboliczneNaNumeryczne(podaneWartosci);

            Obiekt.Normalizacja(this.podaneWartosci, (double)nudMi.Value, (double)nudMa.Value);



            if (Check_met1.Checked == true)
            {

                if (MetricManhattan.Checked == true)
                    metryka = 1;
                if(MetricEuklides.Checked == true)
                    metryka = 2;
                if (MetricMinkowski.Checked == true)
                    metryka = 3;
                if (MetricCzebyszew.Checked == true)
                    metryka = 4;
                if (MetricLogarytm.Checked == true)
                    metryka = 5;

                Obiekt.sposob1(obiekty,podaneWartosci, metryka,K,P);

                textDec.Text = Obiekt.decyzjaW;
            }

            if (Check_met2.Checked == true)
            {

                if (MetricManhattan.Checked == true)
                    metryka = 1;
                if (MetricEuklides.Checked == true)
                    metryka = 2;
                if (MetricMinkowski.Checked == true)
                    metryka = 3;
                if (MetricCzebyszew.Checked == true)
                    metryka = 4;
                if (MetricLogarytm.Checked == true)
                    metryka = 5;

                Obiekt.sposob2(obiekty, podaneWartosci, metryka, K, P);

                textDec.Text = Obiekt.decyzjaW;

            }

        }

        public static int poprawne = 0;
        public static int nieudane = 0;
        public static int niepoprawne = 0;
        public static int ilosc2 = 0;
        private void btn1vsr_Click(object sender, EventArgs e)
        {
            int P = int.Parse(warP.Text);
            int K = int.Parse(warK.Text);

            poprawne = 0;
            nieudane = 0;
            niepoprawne = 0;
            ilosc2 = 0;
            
            Obiekt[] obiekty2 = new Obiekt[obiekty.Length - 1];
            Obiekt[] testowy = new Obiekt[1];


            for (int j = 0;j<obiekty.Length-1;j++)
            {
                int liczony = 0;
                for (int i = 0; i < obiekty.Length; i++)
                {
                    testowy[0] = obiekty[ilosc2];
                    if (ilosc2 == i)
                        i++;
                    obiekty2[liczony] = obiekty[i];
                    liczony++;
                }



                if (Check_met1.Checked == true)
                {

                    if (MetricManhattan.Checked == true)
                        metryka = 1;
                    if (MetricEuklides.Checked == true)
                        metryka = 2;
                    if (MetricMinkowski.Checked == true)
                        metryka = 3;
                    if (MetricCzebyszew.Checked == true)
                        metryka = 4;
                    if (MetricLogarytm.Checked == true)
                        metryka = 5;

                    Obiekt.sposob1(obiekty2, testowy, metryka, K, P);



                }
                if (Check_met2.Checked == true)
                {
                    if (MetricManhattan.Checked == true)
                        metryka = 1;
                    if (MetricEuklides.Checked == true)
                        metryka = 2;
                    if (MetricMinkowski.Checked == true)
                        metryka = 3;
                    if (MetricCzebyszew.Checked == true)
                        metryka = 4;
                    if (MetricLogarytm.Checked == true)
                        metryka = 5;

                    Obiekt.sposob2(obiekty2, testowy, metryka, K, P);


                }

                ilosc2++;
            }

            double udanaK = (ilosc2 - nieudane);
            double pokrycie = (udanaK / ilosc2) * 100;
            double skutecznosc = ((double)poprawne / udanaK) * 100;
            textPraw.Text = skutecznosc.ToString();
            txtNowe.Text = pokrycie.ToString();
        }


        private void Check_met1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nudMi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void clbAtrybutyDoPominiecia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void MetricCzebyszew_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


    }
}
