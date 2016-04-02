using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K
{
    class Program
    {
        static void Main(string[] args)
        {
            long staerdSafns = Convert.ToInt64(Console.ReadLine());
            string[] simanumer = new string[staerdSafns];
            string input = null;
            string nota = null;

            for (long i = 0; i < staerdSafns; i++)
            {
                simanumer[i] = Console.ReadLine();
            }
            long fyrirspurnir = Convert.ToInt64(Console.ReadLine());
            long[] fjoldi = new long[fyrirspurnir];

            for (long i = 0; i < fyrirspurnir; i++)
            {
                input = Console.ReadLine();
                for (long b = 0; b < staerdSafns; b++)
                {
                    nota = null;
                    for (long a = 0; a < input.Length; a++)
                    {
                        char h = simanumer[b][a];
                        nota = nota + h;
                        if (nota == input)
                        {
                            fjoldi[i]++;
                        }
                    }
                }
            }
            for (long i = 0; i < fyrirspurnir; i++)
            {
                Console.WriteLine(fjoldi[i]);
            }
            Console.ReadLine();
        }
    }
}
