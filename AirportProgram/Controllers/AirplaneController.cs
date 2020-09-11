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
                Console.WriteLine($"\n\tNot possible reach to the maximum number");
            }
               
        }

        public void Unloadpassengers()
        {

            Console.WriteLine($"\n\tAirplane {airplane.Identification}" +
                $" unloads {airplane.CurrentNoOfPassengers} passengers");

        }

        public void TakeOff()
        {
            airplane.IsFlying = true;
            Console.WriteLine($"\n\tPlane {airplane.Identification}" +
                $" takes off");

        }

        public void Lands()
        {
            airplane.IsFlying = false;
            Console.WriteLine($"\n\tPlane {airplane.Identification}" +
                $" Lands");

        }

    }
}
