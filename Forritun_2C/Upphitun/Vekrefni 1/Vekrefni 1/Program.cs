﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vekrefni_1
{
    class Program
    {
        /*
            Páll Guðbradsson
         */

        static void Main(string[] args)
        {

            int val = 0;
            while (val != 8)
            {
                Console.WriteLine("1. Skipting i fotboltalid");
                Console.WriteLine("2. Summa");
                Console.WriteLine("3. Dalkar og radir");
                Console.WriteLine("4. strengjavinsla");
                Console.WriteLine("5. BMI");
                Console.WriteLine("6. 7 tolur");
                Console.WriteLine("7. Craps");
                Console.WriteLine("8. Haetta");
                Console.WriteLine("Meira:");
                Console.WriteLine("9. Heiltolu fylki");
                Console.WriteLine("10.Einkunnir");
                val = Convert.ToInt32(Console.ReadLine());

                switch (val)
                {
                    case 1:
                        {//case 1 opnar
                            int heild_leikmenn = 0; int fjoldi_i_lidi = 0; int fjoldi_lida = 0; int varamenn = 0;

                            Console.WriteLine("Fjoldi leikmanna");
                            heild_leikmenn = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("joldi i lidi");
                            fjoldi_i_lidi = Convert.ToInt32(Console.ReadLine());

                            if (fjoldi_i_lidi > heild_leikmenn)
                            {
                                Console.WriteLine("Ekki næst í lið með þennan fjölda þátttakenda");
                            }
                            else
                            {
                                varamenn = heild_leikmenn % fjoldi_i_lidi;

                                heild_leikmenn -= varamenn;

                                fjoldi_lida = heild_leikmenn / fjoldi_i_lidi;

                                Console.Clear();

                                Console.WriteLine("Fjoldi lida: " + fjoldi_lida);
                                Console.WriteLine("varamenn " + varamenn);
                            }
                        }//case 1 lokar
                        break;
                    case 2:
                        {//case 2 opnar
                            double tala = 0;
                            tala = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(Math.Truncate(tala));
                        }// case 2 lokar
                        break;
                    case 3:
                        {//3 opnar
                            int sidasta = 1;//talan sem var sidast i midjunni
                            int summa = 0;
                            Console.Clear();
                            for (int i = 1; i < 26; i++)
                            {
                                Console.Write(i + " ");
                                summa += i;
                                Console.Write(sidasta + " ");
                                summa += sidasta;
                                Console.Write(i * sidasta + " ");
                                summa += (i * sidasta);
                                Console.Write(summa);
                                sidasta += 2;
                                Console.WriteLine();
                            }
                        }//3 lokar
                        break;
                    case 4:
                        {
                            string input = null;
                            string output = null;

                            Console.WriteLine("Insert text");
                            input = Console.ReadLine();

                            for (int i = 0; i < input.Length; i++)
                            {
                                if (input[i] == 'S' || input[i] == 's' || input[i] == 'A' || input[i] == 'a' || input[i] == 'N' || input[i] == 'n')
                                {
                                    output += input[i];
                                }
                                else if (input[i] == ' ')
                                {
                                    output += ' ';
                                }
                                else
                                {
                                    output += '*';
                                }
                            }
                            Console.WriteLine(output);
                        }
                        break;
                    case 5:
                        {
                            /*
                                double number = 0.9999999999999;
                                DecimalFormat numberFormat = new DecimalFormat("#.00");
                                System.out.println(numberFormat.format(number));
                             */
                            string kyn = null;
                            double thyngd = 0, haed = 0, bmi = 0;

                            Console.WriteLine("Sladu inn kyn(KK / KVK");
                            Console.WriteLine("Ef thu skilgreinir thig sem einhvad annad mattu eta skit");
                            kyn = Console.ReadLine();

                            if (kyn == "KK")
                            {
                                Console.WriteLine("Hvad ertu thungur?");
                            }
                            else if (kyn == "KVK")
                            {
                                Console.WriteLine("Hvad ertu thung?");
                            }
                            else
                            {
                                Console.WriteLine("ekki gefa mer thennan skit. fardu");
                                Console.WriteLine("eda sladu inn thyngd");
                            }
                            thyngd = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("sladu inn haed i metrum");
                            haed = Convert.ToDouble(Console.ReadLine());

                            bmi = thyngd / Math.Pow(haed, 2);

                            Console.WriteLine(bmi.ToString("F2"));

                            if (bmi <= 18.5)
                            {
                                Console.WriteLine("Fardu ad borda");
                            }
                            else if (bmi >= 18.6 && bmi <= 24.9)
                            {
                                Console.WriteLine("Thu ert godur");
                            }
                            else if (bmi >= 25 && bmi <= 29.9)
                            {
                                Console.WriteLine("Thetta er allt i lagi konni");
                            }
                            else
                            {
                                Console.WriteLine("Veit ekki hvort thad er einhver villa eda thu ert mjog feitur");
                            }
                        }
                        break;
                    case 6:
                        {
                            int[] tolur = new int[7];

                            for (int i = 0; i < 6; i++)
                            {
                                Console.WriteLine("Sladu inn tolu " + i);
                                tolur[i] = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.WriteLine("Mesta: " + tolur.Max());
                            Console.WriteLine("Minsta: " + tolur.Min());
                            Console.WriteLine("Summa: " + tolur.Sum());
                            Console.WriteLine("Medaltar " + tolur.Average());
                        }
                        break;
                    case 7:
                        {
                            int afram = 0, kast1 = 0, kast2 = 0, summa = 0, nr_kasts = 0, fyrsta_kast = 0, stig = 0;
                            Random rand = new Random();
                            do
                            {
                                //Console.Clear();

                                Console.WriteLine("Veldu 1 til ad spila og 0 til ad haetta");
                                afram = Convert.ToInt32(Console.ReadLine());
                                nr_kasts = 0;
                                do
                                {
                                    kast1 = rand.Next(1, 7);
                                    kast2 = rand.Next(1, 7);

                                    summa = kast1 + kast2;
                                    if (nr_kasts == 0)
                                    {
                                        fyrsta_kast = summa;
                                    }

                                    if (summa == 7 || summa == 11)
                                    {
                                        Console.WriteLine("thu vannst eftir " + nr_kasts + " kost");
                                        break;
                                    }
                                    else if (summa == 2 || summa == 3 || summa == 12)
                                    {
                                        Console.WriteLine("Thu tapar eftir " + nr_kasts + " kost " + " med " + summa + " stig");
                                        break;
                                    }
                                    else
                                    {
                                        if (summa == fyrsta_kast)
                                        {
                                            if (nr_kasts != 0)
                                            {
                                                Console.WriteLine("thu vannst thar sem thu fekkst sama fjolda stiga og i fyrsta kasti eftir " + nr_kasts + " kost");
                                                break;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("thu fekkst " + summa + " Stig. I kasti " + nr_kasts);

                                            stig = summa;
                                        }
                                    }

                                    nr_kasts++;
                                } while (nr_kasts != 7);
                                Console.ReadLine();
                            } while (afram != 0);
                        }
                        break;
                    case 8://notandi aetlar ad haetta
                        {}
                        break;
                    case 9:
                        {
                            int staerd = 0;
                            Random rand = new Random();

                            Console.WriteLine("Sladu inn staerd fylkis sem mun fyllast af random tolum milli 1 og 100");
                            staerd = Convert.ToInt32(Console.ReadLine());

                            int[] fylki = new int[staerd];

                            for (int i = 0; i < fylki.Length; i++)
                            {
                                fylki[i] = rand.Next(1, 101);
                            }
                            Console.WriteLine("Staersta stak = " + fylki.Max());
                            Console.WriteLine("Medaltal = " + fylki.Average());
                            Console.WriteLine("Summa = " + fylki.Sum());
                            Console.WriteLine("Allt fylkid:");
                            for (int i = 0; i < fylki.Length; i++)
                            {
                                if (i == (fylki.Length-1))
                                {
                                    Console.Write(fylki[i]);
                                }
                                else
                                {
                                    Console.Write(fylki[i] + ", ");
                                }
                            }
                        }
                        break;
                    case 10:
                        {
                            Random rand = new Random();
                            int[] fylki = new int[6];
                            int sjo = 0;

                            for (int i = 0; i < fylki.Length; i++)
                            {
                                Console.WriteLine("Sladu inn einkunn " + (i + 1));
                                fylki[i] = Convert.ToInt32(Console.ReadLine());
                            }
                            for (int i = 0; i < fylki.Length; i++)
                            {
                                if (fylki[i] == 7)
                                {
                                    sjo++;
                                }
                                else if (fylki[i] <= 5)
                                {
                                    Console.WriteLine("nemandi " + (i + 1) + " fekk 5 eda undir med " + fylki[i]);
                                }
                            }
                            Console.WriteLine("fjoldi nemanda med 7 var " + sjo);
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Invalid input");
                        }
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }//while lokar
        }
    }
}
