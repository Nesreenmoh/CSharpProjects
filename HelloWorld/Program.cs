using System;
using HelloWorld.Models; // import part

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var ferrari = new Car("ferrari", carType.SEDAN);
            ferrari.Drive();
            ferrari.DriveForDistance(34);
            var miles = ferrari.CalculateMilesDriven();
            Console.WriteLine(miles);
            ferrari.FillTank(200);
            ferrari.DriveForDistance(10);

            Car[] cars = new Car[4];
            cars[0] = ferrari;
            cars[1] = new Car("2132", carType.HATCHBACK);


            // foreach loop
            foreach (var car in cars)
            {
                car.DriveForDistance(10);
                car.Drive();

            }

            Car[,] board = new Car[2, 2];





        }
    }
}
