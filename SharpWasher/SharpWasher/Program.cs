using System;

namespace SharpWasher
{
    class Program
    {
        delegate void WashDelegate(Car car);
        static void Main(string[] args)
        {

            Garage garage = new Garage();
            Car car1 = new Car("Renault");
            Car car2 = new Car("Skoda");
            Car car3 = new Car("Porshe", true);
            Car car4 = new Car("Cadillac");
            Car car5 = new Car("Bentley");

            garage.Add(car1);
            garage.Add(car2);
            garage.Add(car3);
            garage.Add(car4);
            garage.Add(car5);

            Console.WriteLine("Список машин та статус очистки.");
            Console.WriteLine();

            foreach (var index in garage)
            {
                Console.WriteLine(index);

            }
            Console.WriteLine();
            Console.WriteLine("Чистка...");
            Console.WriteLine();

            Washer washer = new Washer();
            WashDelegate washMachine = washer.Wash;
            foreach (var car in garage)
            {
                washMachine(car);
                Console.WriteLine(car);

            }
            Console.ReadKey();
        }
    }
}
