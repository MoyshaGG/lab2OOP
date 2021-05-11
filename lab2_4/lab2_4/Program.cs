using System;

namespace lab2_4
{
    class Program
    {

        public delegate double Del(double one, double delenie, int num);
        static void Main(string[] args)
        {
            Console.Write("Enter the accuracy: ");
            int num = int.Parse(Console.ReadLine());
            var one = 1.0;
            var delenie = 1.0 / 2.0;

            Console.WriteLine("1) 1 + 1/2 + 1/4 + 1/8 + 1/16 + ...\n" +
                "2) 1 + 1/2! + 1/3! + 1/4! + 1/5! + ...\n" +
                "3) 1 + 1/2 - 1/4 + 1/8 - 1/16 + ...\n");
            Del del1 = FirstSum;
            Console.WriteLine($"Результат першої формули: {del1?.Invoke(one, delenie, num)}");
            Del del2 = SecondSum;
            Console.WriteLine($"Результат другої формули: {del2?.Invoke(one, delenie, num)}");
            Del del3 = ThirdSum;
            Console.WriteLine($"Результат третьої формули: {del3?.Invoke(one, delenie, num)}");
            del3.Invoke(one, delenie, num);
            Console.ReadKey();
        }
        private static double FirstSum(double one, double r, int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += one;
                one *= r;
            }
            return Math.Round(sum, 2);
        }
        private static double SecondSum(double a, double r, int n)
        {
            double sum = 0;
            for (double i = 1; i <= n; i++)
            {
                sum += 1.0 / Factorial(i);
            }
            return Math.Round(sum, 2);
        }
        private static double Factorial(double num)
        {
            double res = 1;
            for (double i = num; i > 1; i--)
            {
                res *= i;
            }
            return res;
        }
        private static double ThirdSum(double a, double r, int n)
        {
            var sum = 0.0;
            var PlusOrMinus = true;
            var changingSignsCount = -1;
            double tmp = sum + a;

            for (int i = 1; i <= n; i++)
            {
                changingSignsCount++;

                if (PlusOrMinus)
                {
                    sum += tmp;
                }
                else
                {
                    sum -= tmp;
                }
                if (changingSignsCount == 1)
                {
                    PlusOrMinus = !PlusOrMinus;
                    changingSignsCount = 0;
                }

                tmp = a *= r;
            }
            return Math.Round(sum, 2);
        }
    }
}