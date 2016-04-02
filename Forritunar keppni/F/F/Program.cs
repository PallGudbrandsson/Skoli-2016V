using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F
{
    class Program
    {
        static void Main(string[] args)
        {
            int fjoldiKeppenda = Convert.ToInt32(Console.ReadLine());
            SortedDictionary<long, long> requested = new SortedDictionary<long, long>(); //minnsta og staerstra staerd sem keppandi ma fa
            long[] min = new long[fjoldiKeppenda];
            long[] max = new long[fjoldiKeppenda];
            bool[] done = new bool[fjoldiKeppenda];
            SortedDictionary<long, long> available = new SortedDictionary<long, long>(); //bolirnir sem eru tikl
            string input = null;
            string[] lel;
            long lengstaBil =0;

            for (int i = 0; i < fjoldiKeppenda; i++)
            {
                input = Console.ReadLine();
                lel = input.Split(' ');
                min[i] = Convert.ToInt64(lel[0]);
                max[i] = Convert.ToInt64(lel[1]);
            }
            lel = Console.ReadLine().Split(' ');
            for (int i = 0; i < fjoldiKeppenda; i++)
            {
                if (max[i]-min[i] > lengstaBil)
                {
                    lengstaBil = max[i] - min[i];
                }
            }
            for (long i = 0; i < lel.Length; i++)
            {
                if (available.ContainsKey(Convert.ToInt64(lel[i])))
                {
                    available[Convert.ToInt64(lel[i])] += 1;
                }
            }
            for (long i = 0; i < fjoldiKeppenda; i++)
            {
                {
                    available[min[i]] = -1;
                    done[i] = true;
                }
            }
            for (long i = 0; i < fjoldiKeppenda; i++)
            {
                if (done[i] == false)
                {
                    for (long b = lengstaBil; b > 0 ; b++)
                    {
                        if (max[i]-min[i] == b)
                        {

                            for (long a = min[i]; a < max[i]; a++)
                            {
                                if (requested.ContainsKey(a))
                                {
                                    available[a] = -1;
                                }
                            }
                        }
                    }
                }
            }
            bool flag = true;
            for (int i = 0; i < done.Length; i++)
            {
                if (done[i] == false)
                {
                    flag = false;
                }
            }
            if (flag == true)
            {
                Console.WriteLine("Jebb");
            }
            else
            {
                Console.WriteLine("Neibb");
            }
            Console.ReadLine();
        }
    }
}
