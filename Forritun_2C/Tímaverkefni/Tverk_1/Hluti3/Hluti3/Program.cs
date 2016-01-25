using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hluti3
{
    class Program
    {
        static List<bool> slett(List<int> tolur)
        {
            List<bool> slettar = new List<bool>();

            for (int i = 0; i < tolur.Count; i++)
            {
                if (tolur[i]%2==0)
                {
                    slettar.Add(true);
                }
                else
                {
                    slettar.Add(false);
                }
            }

            return slettar;
        }
        static void Main(string[] args)
        {
            List<int> tolur = new List<int>();
            List<bool> slettar = new List<bool>();
            int amount = 1;

            while (true)
            {
                tolur.Clear();
                slettar.Clear();
                Console.WriteLine("Enter the amount of numbers you want to check");
                amount = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < amount; i++)
                {
                    Console.WriteLine("Enter number " + (i + 1));
                    tolur.Add(Convert.ToInt32(Console.ReadLine()));
                }

                slettar = slett(tolur);

                for (int i = 0; i < slettar.Count; i++)
                {
                    if (slettar[i]==true)
                    {
                        Console.WriteLine(tolur[i] + " is even");
                    }
                    else
                    {
                        Console.WriteLine(tolur[i] + " is not even");
                    }
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
