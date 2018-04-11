using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = { "Alex", "Donald", "Brain", "Tom" };
           
            int len = str.Length;          // получаем длину строки с помощью метода Length
            Random rand = new Random();    
            Console.WriteLine("List of names before mixing\n"); 
            /// <summary>
            ///  вывод исходного порядка элементов массива 
            /// <summary>
            for (int i = 0; i < len; i++)
                Console.WriteLine(" " + str[i]);
        
            /// <summary>
            ///  вывод элементов массива после перестановки элементов 
            /// <summary>
            Console.WriteLine("\nList of names after mixing\n");
            for (int i = len - 1; i >= 0; i--)
            {
                int r = rand.Next(i + 1);  // генерирование случайных чисел средствами класса Random
                string temp = str[r];      // буфер для строкового значения массива со случайым индексом
                str[r] = str[i];           
                str[i] = temp;             
                Console.WriteLine(" " + str[i]);
            }

            
        }
    }
}
