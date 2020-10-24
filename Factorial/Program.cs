using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n;
            bool result = int.TryParse(Console.ReadLine(), out n);
            while (result == false)
            {
                Console.WriteLine("Перепроверьте число и введите снова");
                result = int.TryParse(Console.ReadLine(), out n);
            }

            int[] fact = new int[1000];


            fact[0] = 1;
            int size = 1;


            for (int x = 2; x <= n; x++)
            {
                int carry = 0;


                for (int i = 0; i < size; i++)
                {
                    int prod = fact[i] * x + carry;
                    fact[i] = prod % 10;
                    carry = prod / 10;
                }


                while (carry != 0)
                {
                    fact[size] = carry % 10;
                    carry = carry / 10;
                    size++;
                }
            }
            Console.Write("Фарториал: ");
            for (int i = size - 1; i >= 0; i--)
            {
                Console.Write(fact[i]);
            }


        }
    }
}
