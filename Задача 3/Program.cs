using System;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, count = 0;
            Console.Write("Введите число");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число");
            B = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число");
            C = Convert.ToInt32(Console.ReadLine());

            int a = A;
            int b = B;
            while (a >= C)
            {
                a -= C;
                count++;
            }
            while (b >= C)
            {
                b -= C;
                count++;
            }
            Console.WriteLine(+count);
            Console.ReadKey();
        }
    }
}
