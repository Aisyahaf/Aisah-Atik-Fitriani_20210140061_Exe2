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

        public void InsertionSort()
        {
            
            Console.Write("\nEnter number of elements :");
            int max = Convert.ToInt32(Console.ReadLine());
            int[] aisah = new int[81];
            for (int i = 0; i < max; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] elements : ");
                aisah[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Input int array : ");
            for (int k = 0; k < max; k++) 
                Console.Write(aisah[k] + "");
            Console.Write("\n");
            for (int i = 1;i < max; i++)
            {
                int AF = i - 1;
                while(AF > 0)
                {
                    if (aisah[AF - 1] > aisah[AF])
                    {
                        int temp = aisah[AF - 1];
                        aisah[AF - 1] = aisah[AF];
                        aisah[AF] = temp;
                        AF--;
                    }
                    else
                        break;
                }
            }
            Console.Write("\n\nThe numbers in ascending orders are given below:\n\n");
            for (int i = 0; i < max; i++)
            {
                Console.Write("Sorted [" + (i + 1).ToString() + "] element: ");
                Console.Write(aisah[i]);
                Console.Write("\n");
            }
            
        }

        public void MergeSort()
        {
            int high, mid, low;
            Console.Write("\n\nEnter number of elements: ");
            int max = Convert.ToInt32(Console.ReadLine());
            int[] aisah = new int[81];
            int AF, num, pos ;

            for (int i = 0; i < max; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                aisah[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Input int array : ");
            Console.Write("\n");
            for (int k = 0; k < max; k++)
            {
                Console.Write(aisah[k] + " ");
                Console.Write("\n");
            }

            if (low > high)
            {
                mid = (low + high) / 2;
                
            }
        }


        static void Main(string[] args)
        {
            Program myList = new Program();
            int pilihanmenu;
            char ch;
            do
            {
                do
                {
                    Console.WriteLine("Menu Option");
                    Console.WriteLine("================");
                    Console.WriteLine("1. Linear Search");
                    Console.WriteLine("2. Binary Search");
                    Console.WriteLine("3. Exit");
                    Console.Write("Enter your choice (1,2,3) : ");
                    pilihanmenu = Convert.ToInt32(Console.ReadLine());
                    switch (pilihanmenu)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("................");
                            Console.WriteLine("Linear Search");
                            Console.WriteLine("................");
                            myList.input();
                            myList.InsertionSort();
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("................");
                            Console.WriteLine("Binary Search");
                            Console.WriteLine("................");
                            myList.input();
                            myList.MergeSort();
                            break;
                        case 3:
                            Console.WriteLine("exit.");
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;

                    }
                    Console.WriteLine("\n Pilih Menu Lagi ?????? (y/n) :");
                    ch = char.Parse(Console.ReadLine().ToLower());
                    Console.Clear();
                }
                while (ch == 'y');

                //to exit from the console
                Console.WriteLine("\n Press Return to exit.");
                Console.ReadLine();

            }
            while (pilihanmenu != 3);
        }
}
