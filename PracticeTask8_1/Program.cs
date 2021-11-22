using System;

namespace PracticeTask8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int N = Convert.ToInt32(Console.ReadLine());
            string Buffer = "";
            while (N != 0)
            {
                Buffer += Convert.ToString(N%10);
                N = N / 10;
            }
            Console.WriteLine(Convert.ToInt32(Buffer));
            Console.Write("Введите число: ");
            N = Convert.ToInt32(Console.ReadLine());
            Buffer = "";
            for (int i = 0; i <= N; i++)
            {
                Buffer += Convert.ToString(N % 10);
                N = N / 10;
            }
            Console.WriteLine(Convert.ToInt32(Buffer));
        }
    }
}
