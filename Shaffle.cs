using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = { "Alex", "Donald", "Brain", "Tom" };
           
            int len = str.Length;
            Random rand = new Random();
            Console.WriteLine("List of names before mixing\n");

            for (int i = 0; i < len; i++)
                Console.WriteLine(" " + str[i]);
            /// пермешивание массива строк
            /// 
            
            Console.WriteLine("\nList of names after mixing\n");
            for (int i = len - 1; i >= 0; i--)
            {
                int r = rand.Next(i + 1);
                string temp = str[r];
                str[r] = str[i];
                str[i] = temp;
                Console.WriteLine(" " + str[i]);
            }

            Console.ReadLine();
        }
    }
}
