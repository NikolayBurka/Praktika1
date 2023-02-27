using System;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());//кол-во
            Console.Write("Введите число");
            string m = Console.ReadLine();//Спасибо
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(m);
            }
            Console.Read();

            for (int i = 10; i <= 99; i++)
                if (i % 10 + i / 10 == (i * 2) % 10 + (i * 2) / 10 % 10 + (i * 2) / 100)
                {
                    Console.Write("{0}\t", i);
                }
            int count = 0;
            for (int x = 2; x <= 99; x++)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine(x); count++;
                }
            }
            Console.WriteLine($"кол-во={count}");

            for (int i = 10; i <= 99; i++)
                if (i % 10 + i / 10 == (i * 11) % 10 + (i * 11) / 10 % 10 + (i * 11) / 100)
                {
                    Console.Write("{0}\t", i);
                }
            int count = 0;
            for (int x = 11; x <= 99; x++)
            {
                if (x % 11 == 0)
                {
                    Console.WriteLine(x); count++;
                }
            }
            Console.WriteLine($"кол-во={count}");

            for (int i = 10; i <= 99; i++)
                if (i % 16 + i / 16 == (i * 16) % 16 + (i * 16) / 16 % 16 + (i * 16) / 100)
                {
                    Console.Write("{0}\t", i);
                }
            int count = 0;
            for (int x = 16; x <= 99; x++)
            {
                if (x % 16 == 0)
                {
                    Console.WriteLine(x); count++;
                }
            }
            Console.WriteLine($"кол-во={count}");
            int count = 0;
            int k = 0; s = 0;
            for (int i = 10; i <= 99; i++)
                if (i % 25 + i / 25 == (i * 25) % 25 + (i * 25) / 25 % 25 + (i * 25) / 100)
                {
                    Console.Write("{0}\t", i);
                }

            for (int x = 25; x <= 99; x++)
            {
                {
                    Console.WriteLine(x); count++;
                    k++;
                    s++ = x;
                }
            }
            Console.WriteLine($"кол-во={count}");
            Console.Read();
        }
    }
}
