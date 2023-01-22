using System;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            int i = 1; s = i; i++;
            do
            {
                s += (2 * i - 1);
            }
            while (s <= (2 * i - 1));
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
