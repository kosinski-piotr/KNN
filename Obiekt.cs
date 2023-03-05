using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Zad1
{




    enum MetodaWczytywaniaRepozytorium
    {
        KlasaDecyzyjnaNaKoncuSpacjaSeparator = 0,
        KlasaDecyzyjnaNaKoncuPrzecinekSeparator = 1,
    }

    internal class Obiekt
    {
        public static Config cnf;


        public string decyzja;
        public Dictionary<int, double> numeryczne;
        public Dictionary<int, double> numeryczneZamienione = new Dictionary<int, double>();

        public Dictionary<int, double> znormalizowane;

        public Dictionary<string, double> odleglosc = new Dictionary<string, double>();

        public Dictionary<int, string> symboliczne = null;

        public Dictionary<int, string> Symboliczne
        {
            get
            {
                if (this.symboliczne == null)
                {
                    this.symboliczne = this.PobierzWartosciSymboliczne();
                }

                return this.symboliczne;
            }
        }

        public string[] wartosci;

        /// <summary>
        /// 1 22.08 11.46 2 4 4 1.585 0 0 0 1 2 100 1213 0
        /// </summary>
        /// <param name="linia"></param>
        public Obiekt(string linia, MetodaWczytywaniaRepozytorium metoda = MetodaWczytywaniaRepozytorium.KlasaDecyzyjnaNaKoncuSpacjaSeparator)
        {
            switch (metoda)
            {
                case MetodaWczytywaniaRepozytorium.KlasaDecyzyjnaNaKoncuSpacjaSeparator:
                    Metoda0(linia);
                    break;

                case MetodaWczytywaniaRepozytorium.KlasaDecyzyjnaNaKoncuPrzecinekSeparator:
                    Metoda0(linia, ',');
                    break;

                default:
                    throw new Exception("Nieobsługiwana metoda w Konstruktorze klasy Obiekt");
            }

        }

        Dictionary<int, string> PobierzWartosciSymboliczne()
        {
            Dictionary<int, string> wynik = new Dictionary<int, string>();

            for (int i = 0; i < this.wartosci.Length; i++)
            {
                if (!this.numeryczne.ContainsKey(i))
                {
                    wynik.Add(i, wartosci[i]);
                }
            }
            return wynik;
        }

        
        internal void przypisz(string linia, List<int> zajete, int ilosc)
        {
            char separator = ' ';
            var wartosci = linia.Split(new char[] { separator });
            this.decyzja = wartosci.Last();

            this.wartosci = new string[wartosci.Length];
            this.numeryczne = new Dictionary<int, double>();
            int k = 0;
            for(int i=0;i<ilosc;i++)
            {
                this.wartosci[k] = wartosci[k];
                for(int j=0;j<zajete.Count;j++)
                {
                    if(i == zajete[j])
                    {
                        try
                        {
                            double? tmp = Parsuj("0");

                            if (tmp.HasValue)
                                this.numeryczne.Add(i, tmp.Value);
                            break;
                        }
                        catch (Exception e) { }
                    }
                }
                if(!numeryczne.ContainsKey(i))
                try
                {
                    double? tmp = Parsuj(wartosci[k]);

                    if (tmp.HasValue)
                        this.numeryczne.Add(i, tmp.Value);
                    k++;
                }
                catch (Exception e) { }

            }
        }




        internal static void Normalizacja(Obiekt[] obiekty, double mi, double ma)
        {
            for (int i = 0; i < obiekty.Length; i++)
            {
                obiekty[i].Normalizuj(mi, ma);
            }

            Obiekt.cnf.Mi = mi; 
            Obiekt.cnf.Ma = ma;
        }
      
        void Normalizuj(double mi, double ma)
        {
            this.znormalizowane = new Dictionary<int, double>();
            foreach (var item in this.numeryczne)
            {
                var numerAtrybutu = item.Key; // numer atrybutu
                if (Obiekt.cnf.AtrybutyPominiete.Contains(numerAtrybutu))
                    continue;


                var wynik = ZnormalizujWartosc(cnf.Min[numerAtrybutu], cnf.Max[numerAtrybutu], mi, ma, item.Value);
                this.znormalizowane.Add(item.Key, wynik);
            }

            foreach (var item in this.numeryczneZamienione)
            {
                var numerAtrybutu = item.Key; // numer atrybutu
                if (Obiekt.cnf.AtrybutyPominiete.Contains(numerAtrybutu))
                    continue;

                var wynik = ZnormalizujWartosc(cnf.Min[numerAtrybutu], cnf.Max[numerAtrybutu], mi, ma, item.Value);
                this.znormalizowane.Add(item.Key, wynik);
            }
        }

        static double ZnormalizujWartosc(double min, double max, double mi, double ma, double wartosc)
        {
            return (wartosc - min) / (max - min) * (ma - mi) + mi;
        }

        void Metoda0(string linia, char separator = ' ')
        {
            var wartosci = linia.Split(new char[] { separator });
            this.decyzja = wartosci.Last();

            this.wartosci = new string[wartosci.Length - 1];
            this.numeryczne = new Dictionary<int, double>();

            for (int i = 0; i < wartosci.Length - 1; i++)
            {
                this.wartosci[i] = wartosci[i];
                try
                {
                    double? tmp = Parsuj(wartosci[i]);
                    if (tmp.HasValue)
                        this.numeryczne.Add(i, tmp.Value);
                }
                catch (Exception e) { }
            }
        }

        double? Parsuj(string wartosc)
        {
            wartosc = wartosc.Trim();
            double wynik = 0;

            if (!double.TryParse(wartosc.Replace(".", ","), out wynik))
            {
                if (!double.TryParse(wartosc.Replace(",", "."), out wynik))
                    return null;
            }

            return wynik;
        }

        public override string ToString()
        {
            return $"Atrybuty[{this.wartosci.Length}] ({this.decyzja})";
        }

        public static Dictionary<string, int> CzestosciWartosci(Obiekt[] obiekty, int index)
        {
            Dictionary<string, int> czestosci = new Dictionary<string, int>();
            foreach (var ob in obiekty)
            {
                var symbol = ob.wartosci[index];

                if (czestosci.ContainsKey(symbol))
                {
                    czestosci[symbol]++;
                }
                else
                {
                    czestosci.Add(symbol, 1);
                }
            }

            return czestosci;
        }

        public static Dictionary<string, int> PrzypisywanieSymbolomNumerow(Dictionary<string, int> czestosci)
        {
            var wynik = czestosci.OrderBy(item => item.Value);

            Dictionary<string, int> przypisane = new Dictionary<string, int>();

            int i = 0;
            foreach (var item in wynik)
            {
                przypisane.Add(item.Key, i++);
            }

            return przypisane;
        }

        public void ZamienSymbolNaNumer(Dictionary<string, int> przypisane, int index)
        {
            if (!this.numeryczneZamienione.ContainsKey(index))
                this.numeryczneZamienione.Add(index, 0);

            var symbol = this.wartosci[index];

            var numer = przypisane[symbol];

            this.numeryczneZamienione[index] = numer;
        }

        public static void ZamienSymboliczneNaNumeryczne(Obiekt[] obiekty)
        {
            var symboliczne = obiekty.First().Symboliczne;

            foreach (var item in symboliczne)
            {
                var index = item.Key;

                var czestosci = Obiekt.CzestosciWartosci(obiekty, index);

                var przypisane = Obiekt.PrzypisywanieSymbolomNumerow(czestosci);

                Obiekt.cnf.Min.Add(index, przypisane.First().Value);
                Obiekt.cnf.Max.Add(index, przypisane.Last().Value);

                for (int i = 0; i < obiekty.Length; i++)
                //Parallel.For(0, obiekty.Length, i =>
                {
                    obiekty[i].ZamienSymbolNaNumer(przypisane, index);
                }
                //);
            }
        }


        public static void ZnajdzMinMaxWNumerycznych(Obiekt[] obiekty)
        {
            var numeryczne = obiekty.First().numeryczne;

            foreach (var item in numeryczne)
            {
                var index = item.Key;

                double min = obiekty[0].numeryczne[index];
                double max = obiekty[0].numeryczne[index];

                List<Obiekt> brakująceWartosci = new List<Obiekt>();
                for (int i = 1; i < obiekty.Length-1; i++)
                {
                    if (obiekty[i].numeryczne.ContainsKey(index))
                    {
                        if (obiekty[i].numeryczne[index] < min)
                            min = obiekty[i].numeryczne[index];

                        if (obiekty[i].numeryczne[index] > max)
                            max = obiekty[i].numeryczne[index];
                    }
                    else
                    {
                        brakująceWartosci.Add(obiekty[i]);
                    }
                }

                foreach (var ob in brakująceWartosci)
                {
                    ob.numeryczne.Add(index, min);
                    ob.Symboliczne.Remove(index);
                }

                Obiekt.cnf.Min.Add(index, min);
                Obiekt.cnf.Max.Add(index, max);
            }
        }


        public double MetricManhattan(Dictionary<int,double> dic1, Dictionary<int,double> dic2)
        {
            double sum = 0;
            for (int i = 0; i < dic1.Count; i++)
            {
                var item = dic1.ElementAt(i);
                var item2 = dic2.ElementAt(i);
                sum += Math.Abs((double)item2.Value - (double)item.Value);
            }
            return sum;
        }
        public double MetricEuklides(Dictionary<int, double> dic1, Dictionary<int, double> dic2)
        {
            double sum = 0;

            for (int i = 0; i < dic1.Count; i++)
            {
                var item = dic1.ElementAt(i);
                var item2 = dic2.ElementAt(i);
                sum += Math.Pow((double)item.Value - (double)item2.Value, 2);
            }
            return Math.Sqrt(sum);
        }
        public double MetricCzebyszew(Dictionary<int, double> dic1, Dictionary<int, double> dic2)
        {
            double max = 0;

            for (int i = 0; i < dic1.Count; i++)
            {
                var item = dic1.ElementAt(i);
                var item2 = dic2.ElementAt(i);
                double war = Math.Abs((double)item.Value - (double)item2.Value);
                if (war > max)
                    max = war;
            }
            return max;
        }
        public double MetricMinkowski(Dictionary<int, double> dic1, Dictionary<int, double> dic2, int p)
        {
            double sum = 0;
            for (int i = 0; i < dic1.Count; i++)
            {
                {
                    var item = dic1.ElementAt(i);
                    var item2 = dic2.ElementAt(i);
                    sum += Math.Pow(Math.Abs((double)item.Value - (double)item2.Value), p);
                }
            }
            return Math.Pow(sum, 1 / p);
        }
        public double MetricLogarytm(Dictionary<int, double> dic1, Dictionary<int, double> dic2)
        {
            double sum = 0;

            for (int i = 0; i < dic1.Count; i++)
            {
                var item = dic1.ElementAt(i);
                var item2 = dic2.ElementAt(i);
                sum += Math.Abs(Math.Log10((double)item.Value) - Math.Log10((double)item2.Value));
            }
            return sum;
        }
        public static string decyzjaW;
        public static void sposob1(Obiekt[] obiekty, Obiekt[] podaneWartosci, int metryka, int warK, int P) //=====================================
        {

            Dictionary<Obiekt, double> posortowane = new Dictionary<Obiekt, double>();
            if (metryka == 1)
            {
                foreach (Obiekt obj in obiekty)
                {
                    double policzone = obj.MetricManhattan(obj.znormalizowane, podaneWartosci[0].znormalizowane);
                    obj.odleglosc.Clear();
                    obj.odleglosc.Add(obj.decyzja, policzone);
                    posortowane.Add(obj, policzone);
                }
            }
            if (metryka == 2)
            {
                foreach (Obiekt obj in obiekty)
                {
                    double policzone = obj.MetricEuklides(obj.znormalizowane, podaneWartosci[0].znormalizowane);
                    obj.odleglosc.Clear();
                    obj.odleglosc.Add(obj.decyzja, policzone);
                    posortowane.Add(obj, policzone);
                }
            }
            if (metryka == 3)
            {
                foreach (Obiekt obj in obiekty)
                {
                    double policzone = obj.MetricMinkowski(obj.znormalizowane, podaneWartosci[0].znormalizowane, P);
                    obj.odleglosc.Clear();
                    obj.odleglosc.Add(obj.decyzja, policzone);
                    posortowane.Add(obj, policzone);
                }
            }
            if (metryka == 4)
            {
                foreach (Obiekt obj in obiekty)
                {
                    double policzone = obj.MetricCzebyszew(obj.znormalizowane, podaneWartosci[0].znormalizowane);
                    obj.odleglosc.Clear();
                    obj.odleglosc.Add(obj.decyzja, policzone);
                    posortowane.Add(obj, policzone);

                }
            }
            if (metryka == 5)
            {
                foreach (Obiekt obj in obiekty)
                {
                    double policzone = obj.MetricLogarytm(obj.znormalizowane, podaneWartosci[0].znormalizowane);
                    obj.odleglosc.Clear();
                    obj.odleglosc.Add(obj.decyzja, policzone);
                    posortowane.Add(obj, policzone);

                }
            }
            int koniec = 0;

            List<string> decyzje = new List<string>();

            var posort = from entry in posortowane orderby entry.Value ascending select entry;


            foreach (KeyValuePair<Obiekt, double> pos in posort.OrderBy(key => key.Value))
            {
                koniec++;
                decyzje.Add(pos.Key.decyzja);

                if (koniec == warK)
                    break;
            }
            var klasydist = decyzje.Distinct().ToArray();

            int pierwsza = 0;
            for (int i = 0; i < decyzje.Count; i++)
            {
                if (klasydist[0] == decyzje[i])
                    pierwsza++;
            }

            if (pierwsza > warK - pierwsza)
            {
                if (podaneWartosci[0].decyzja == klasydist[0]) //p2
                {
                    Form1.poprawne++;
                }
                else
                    Form1.niepoprawne++;

 //               podaneWartosci[0].decyzja = klasydist[0]; //p1
                decyzjaW = klasydist[0];
            }
            else if (pierwsza < warK - pierwsza)
            {
                if (podaneWartosci[0].decyzja == klasydist[1])
                {
                    Form1.poprawne++;

                }
                else
                    Form1.niepoprawne++;
               
 //               podaneWartosci[0].decyzja = klasydist[1];
                decyzjaW = klasydist[1];
            }
            else
            {
                Form1.nieudane++;
                
 //               podaneWartosci[0].decyzja = "Nie udało się wyliczyć klasy decyzyjnej";
                decyzjaW = "Nie udane";
            }

        }

        public static void sposob2(Obiekt[] obiekty, Obiekt[] podaneWartosci, int metryka, int warK, int P)//======================================
        {

            Dictionary<Obiekt, double> typ1 = new Dictionary<Obiekt, double>();
            Dictionary<Obiekt, double> typ2 = new Dictionary<Obiekt, double>();

            List<string> decyzje = new List<string>();
            foreach (Obiekt obj in obiekty)
            {
                decyzje.Add(obj.decyzja);

            }
            var klasydist = decyzje.Distinct().ToArray();


            if (metryka == 1)
            {
                foreach (Obiekt obj in obiekty)
                {
                    double policzone = obj.MetricManhattan(obj.znormalizowane, podaneWartosci[0].znormalizowane);
                    obj.odleglosc.Clear();
                    obj.odleglosc.Add(obj.decyzja, policzone);
                    if (obj.decyzja == klasydist[0])
                        typ1.Add(obj, policzone);
                    else
                        typ2.Add(obj, policzone);
                }
            }
            if (metryka == 2)
            {
                foreach (Obiekt obj in obiekty)
                {
                    double policzone = obj.MetricEuklides(obj.znormalizowane, podaneWartosci[0].znormalizowane);
                    obj.odleglosc.Clear();
                    obj.odleglosc.Add(obj.decyzja, policzone);
                    if (obj.decyzja == klasydist[0])
                        typ1.Add(obj, policzone);
                    else
                        typ2.Add(obj, policzone);
                }
            }
            if (metryka == 3)
            {
                foreach (Obiekt obj in obiekty)
                {
                    double policzone = obj.MetricMinkowski(obj.znormalizowane, podaneWartosci[0].znormalizowane, P);
                    obj.odleglosc.Clear();
                    obj.odleglosc.Add(obj.decyzja, policzone);
                    if (obj.decyzja == klasydist[0])
                        typ1.Add(obj, policzone);
                    else
                        typ2.Add(obj, policzone);
                }
            }
            if (metryka == 4)
            {
                foreach (Obiekt obj in obiekty)
                {
                    double policzone = obj.MetricCzebyszew(obj.znormalizowane, podaneWartosci[0].znormalizowane);
                    obj.odleglosc.Clear();
                    obj.odleglosc.Add(obj.decyzja, policzone);
                    if (obj.decyzja == klasydist[0])
                        typ1.Add(obj, policzone);
                    else
                        typ2.Add(obj, policzone);
                }
            }
            if (metryka == 5)
            {
                foreach (Obiekt obj in obiekty)
                {
                    double policzone = obj.MetricLogarytm(obj.znormalizowane, podaneWartosci[0].znormalizowane);
                    obj.odleglosc.Clear();
                    obj.odleglosc.Add(obj.decyzja, policzone);
                    if (obj.decyzja == klasydist[0])
                        typ1.Add(obj, policzone);
                    else
                        typ2.Add(obj, policzone);
                }
            }
            var posort1 = from entry in typ1 orderby entry.Value ascending select entry;
            var posort2 = from entry in typ2 orderby entry.Value ascending select entry;

            List<double> odleglosci1 = new List<double>();
            List<double> odleglosci2 = new List<double>();


            int koniec = 0;
            foreach (KeyValuePair<Obiekt, double> pos in posort1.OrderBy(key => key.Value))
            {
                koniec++;
                odleglosci1.Add(pos.Value);

                if (koniec == warK)
                    break;
            }
            int koniec2 = 0;
            foreach (KeyValuePair<Obiekt, double> pos in posort2.OrderBy(key => key.Value))
            {
                koniec2++;
                odleglosci2.Add(pos.Value);

                if (koniec == warK)
                    break;
            }

            double odl1 = odleglosci1.Sum();
            double odl2 = odleglosci2.Sum();

            if (odl1 < odl2)
            {

                if (podaneWartosci[0].decyzja == decyzje[0])
                    Form1.poprawne++;
                else
                    Form1.niepoprawne++;
               
 //               podaneWartosci[0].decyzja = decyzje[0];
                decyzjaW = decyzje[0];
            }
            else if (odl1 > odl2)
            {
                if (podaneWartosci[0].decyzja == decyzje[1])
                    Form1.poprawne++;
                else
                    Form1.niepoprawne++;

 //               podaneWartosci[0].decyzja = decyzje[1];
                decyzjaW = decyzje[1];
            }
            else
            {
                Form1.nieudane++;

//                podaneWartosci[0].decyzja = "Nie udało się wyliczyć klasy decyzyjnej";
                decyzjaW = "Nie udane";
            }
        }


    }

}
