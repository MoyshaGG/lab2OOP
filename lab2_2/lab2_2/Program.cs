using System;

namespace lab2_2
{
    class Program
    {
        public delegate int MyDelegate();
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(Timer.Count);
            myDelegate();

            Console.ReadLine();
        }

    }
}
