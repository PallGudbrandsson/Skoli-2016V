using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_mi1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder();
            str.Append(Console.ReadLine());
            string rebuilt = null;
            int current = 0;

            for (int i = 0; i < str.Length; i++)
            {
                rebuilt += str[i];
                if (str[i]=='<')
                {
                    rebuilt = rebuilt.Remove(current);
                    rebuilt = rebuilt.Remove(current - 1);
                    current -= 1;
                }
                else
                {
                    current++;
                }
            }
            Console.WriteLine(rebuilt);
            Console.ReadLine();
        }
    }
}
