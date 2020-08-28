using System.Collections.Generic;
using System.Text;
using System.IO;
using System;
using Newtonsoft.Json;

namespace Day15_JSON
{
    class Program
    {
        static void Main(string[] args)
        {
           // KlasesUZD();
            List<Auto> SalonaAuto = new List<Auto>();
            SalonaAuto.Add(new Auto("Audi", "A6", "green", 2020, 236, 40000, false));
            SalonaAuto.Add(new Auto("Audi", "A3", "red", 2016, 136, 25000, false));
            SalonaAuto.Add(new Auto("Audi", "A8", "black", 2010, 420, 42000, false));
            SalonaAuto.Add(new Auto("Audi", "A4", "blue", 2020, 236, 40000, false));
            SalonaAuto.Add(new Auto("Audi", "AllRoad", "grey", 2016, 160, 16000, true));
            SalonaAuto.Add(new Auto("Audi", "Coupe", "black", 2015, 146, 8000, false));
            SalonaAuto.Add(new Auto("Audi", "Q5", "violet", 2010, 276, 19000, false));
            SalonaAuto.Add(new Auto("Audi", "A6", "blue", 2011, 136, 12000, false));

            string choise = "";

            Console.WriteLine("Jusu Auto Salons");

            while (choise != "0")
            {
                
                Console.WriteLine("Sveiki");
                Console.WriteLine("1 - Apskatit salona auto sarakstu");
                Console.WriteLine("2 - Pardot Auto");
                Console.WriteLine("3 - Apskatit pardoto auto sarakstu");
                Console.WriteLine("0 - EXIT");

                choise = Console.ReadLine();
                switch (choise)
                {
                    case "0":
                        {
                            return;
                        }
                    case "1":
                        {
                            Console.WriteLine("Salona uz vietas atrodas - ");
                            foreach (var Car in SalonaAuto)
                            {
                                if (Car.IsSold == false)
                                {
                                    Car.PrintInfo();
                                }
                            }

                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Kuru auto jus pardosiet?");
                            for (int i = 0; i < SalonaAuto.Count; i++)
                            {
                                if (SalonaAuto[i].IsSold == false)
                                {
                                    SalonaAuto[i].PrintInfo();
                                }
                            }
                            int Izvele = Convert.ToInt32(Console.ReadLine() + 1);
                            SalonaAuto[Izvele].IsSold = true;
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Jus esat pardevusi sos auto - ");
                            foreach (var Car in SalonaAuto)
                            {
                                if (Car.IsSold == true)
                                {
                                    Car.PrintInfo();
                                }
                            }
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Nesapratu jus -_-");
                            break;
                        }
                }
            }
            // nakosa sadala
            List<Auto> Nepardotie = new List<Auto>();
            List<Auto> Pardotie = new List<Auto>();

            for (int i = 0; i < SalonaAuto.Count; i++)
            {
                if (SalonaAuto[i].IsSold == false)
                {
                    Nepardotie.Add(SalonaAuto[i]);
                }
                else
                {
                    Pardotie.Add(SalonaAuto[i]);
                }
            }
            String JsonString = JsonConvert.SerializeObject(Nepardotie);
            String JsonString2 = JsonConvert.SerializeObject(Pardotie);

        }
        static void KlasesUZD()
        {
            List<Student> Saraksts = new List<Student>();
            Saraksts.Add(new Student("Arturs", "Berzins", 1));
            Saraksts.Add(new Student("Karlis", "Mazais", 4));
            Saraksts.Add(new Student("Haralds", "Lielais", 3));
            Saraksts.Add(new Student("Aija", "Pukite", 2));

            // faila ierakstisana
            String JsonString = JsonConvert.SerializeObject(Saraksts);
            Console.WriteLine(JsonString);

            // faila atkodeesana, 
            List<Auto> SarakstaIeraksts = JsonConvert.DeserializeObject<List<Auto>>(JsonString);

            foreach (Auto skolens in SarakstaIeraksts)
            {
                skolens.PrintInfo();
            }
        }
    }
}
