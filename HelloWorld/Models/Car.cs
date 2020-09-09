using System;

namespace HelloWorld.Models // package as java
{
    public class Car // class name as java
    {
        /*

        */

        private int mileage = 0;
        private double tank = 0;
        private int mxTank = 50;
        private string license;
        private carType type;

        public Car(string newLicense, carType cartype)
        {
            this.license = newLicense;
            this.type = cartype;

        }
        public void Drive()
        {
            Console.WriteLine("Hello World");
            // if (type == carType.SEDAN)
            // {
            //     Console.WriteLine("VROOOOO");
            // }
            switch (type)
            {
                case carType.SEDAN:
                    {
                        Console.WriteLine("VROOOO");
                        break;
                    }
                case carType.HATCHBACK:
                    {
                        Console.WriteLine("HATCHBACK");
                        break;
                    }
            }
        }

        public void DriveForDistance(int distance)
        {
            for (int i = 0; i < distance; i++)
            {
                tank = tank - 1;
            }
            Console.WriteLine("The car is driving for " + distance + " kilometers!");
            mileage += distance;
        }

        public int CalculateMilesDriven()
        {
            var miles = mileage / 1.6;
            return (int)miles;
        }

        public void FillTank(int amount)
        {
            if (tank + amount > mxTank)
            {
                tank = mxTank;
            }
            else
            {
                tank = amount;
            }
            Console.WriteLine("The tank has " + tank);


        }
    }
}
