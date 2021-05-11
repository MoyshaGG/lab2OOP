using System;

namespace lab2_3
{
    class Program
    {
        public delegate void Div(int[] mas);
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,5,6,7,8,9};
            Div three = new Div(Three);
            Div seven = new Div(Seven);
            Console.WriteLine("Числа що дiляться на 3");
            three(arr);
            
            Console.WriteLine("Числа що дiляться на 7");
            seven(arr);
        }
        public static void Three(int[] arr)
        {
            foreach( int index in arr)
            {
            
                if(index%3 == 0)
                {
                    Console.Write(" " + index);
                }
            }
            Console.WriteLine();
        }
        public static void Seven(int[] arr)
        {
            foreach (int index in arr)
            {
               
                if (index % 7 == 0 )
                {
                    Console.Write(" " + index);
                }
            }
            Console.WriteLine();


        }
    }
}
