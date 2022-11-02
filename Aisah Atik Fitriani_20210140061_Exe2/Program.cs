using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise2
{
    class Program
    {
        int[] aisah = new int[81];
        int n;
        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 81))
                    break;
                else
                    Console.WriteLine("\n.Array should have minimum 1 and maximum 81 elements.\n");
            }

            Console.WriteLine("");
            Console.WriteLine("--------------------");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("--------------------");
            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                aisah[i] = Int32.Parse(s1);
            }

        }
    }
}
