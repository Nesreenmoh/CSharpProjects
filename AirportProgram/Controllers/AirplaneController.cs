using AirportProgram.Models;
using System;


namespace AirportProgram.Controllers
{

    public class AirplaneController
    {
        private Airplane airplane;
        public AirplaneController(Airplane airplane)
        {
            this.airplane = airplane;
           
        }

        public void loadpassengers(int NoOfPassengers)
        {
            if ((airplane.CurrentNoOfPassengers + NoOfPassengers)<= airplane.MaxOfPassengers )
            {
                airplane.CurrentNoOfPassengers += NoOfPassengers;
                Console.WriteLine($"\n\tAirplane {airplane.Identification}" +
                $" loads {NoOfPassengers} passengers");

            }

            else
            {
                Console.WriteLine($"\n\tAirplane {airplane.Identification} charges {airplane.MaxOfPassengers - airplane.CurrentNoOfPassengers}" +
                    $", {NoOfPassengers}  do not fit");
            }
               
        }

        public void Unloadpassengers()
        {

            Console.WriteLine($"\n\tAirplane {airplane.Identification}" +
                $" discharges {airplane.CurrentNoOfPassengers} passengers");

        }

        public void TakeOff()
        {
            if (!airplane.IsFlying)
            {
                airplane.IsFlying = true;
                Console.WriteLine($"\n\tPlane {airplane.Identification}" +
                    $" rises");
            }
            else
            {
                Console.WriteLine($"\n\t Airplane {airplane.Identification} cannot take off, because we are already flying");
            }
           

        }

        public void Lands()
        {
            if (airplane.IsFlying)
            {
                airplane.IsFlying = false;
                Console.WriteLine($"\n\tPlane {airplane.Identification}" +
                    $" Lands");

            }
            else
            {
                Console.WriteLine($"\tAirplane {airplane.Identification} cannot land,because we are still on the ground");
            }

        }

    }
}
