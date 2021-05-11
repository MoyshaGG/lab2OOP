using System;

namespace lab2_1exe
{
    class Program
    {
        delegate double Delegates(int x);
        static void Main(string[] args)
        {
            Console.WriteLine("Вводьте рядки послiдовно один за одним ");
            Console.WriteLine("Поки вони матимуть вигляд: 0 x чи 1 x чи 2 x ");
            Console.WriteLine("Тобто цифра вiд 0 до 2, а пiсля неї через пробiл запис конкрентного дiйсного числа");
            Console.WriteLine("Програма обчислюватиму одну з трьох функцiй: ");
            Console.WriteLine("    0 -- sqrt(abs(x))");
            Console.WriteLine("    1 -- x^3" );
            Console.WriteLine("    2 -- x + 3,5");
            Console.WriteLine("(згiдно цифри на початку) i виводитиме результат ");
            Console.WriteLine();
            Console.WriteLine("Якщо вхiдний рядок не задовольнятиме цей формат, програма завершить свою роботу");


            Delegates[] Methods = new Delegates[] {First, Second, Third };

            while (true)
            {
                try
                {
                    int[] nums = Array.ConvertAll(Convert.ToString(Console.ReadLine()).Split(' '), int.Parse);
                    double output = Methods[nums[0]](nums[1]);
                    Console.WriteLine(output);
                }
                catch (Exception e)
                {
                    
                    Console.WriteLine("Неправильнi данi. Для виходу з програми натиснiть будь яку клавiшу");
                    break;
                }
            }
            static double First(int x)
            {
               return Math.Sqrt(Math.Abs(x));
            }
            static double Second(int x)
            {
                return x* x *x;
            }
            static double Third(int x)
            {
               return x + 3.5;
            }

        }
    }
}
