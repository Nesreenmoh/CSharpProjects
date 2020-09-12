using AirportProgram.Models;
using System;


namespace AirportProgram.Controllers
{

    public class AirplaneController
    {
        private PeoplePlane PeopleAireplane;
        public AirplaneController(PeoplePlane PeopleAirplane)
        {
            this.PeopleAireplane = PeopleAirplane;
           
        }

        public void loadpassengers(int NoOfPassengers)
        {
            if ((PeopleAireplane.CurrentNoOfPassengers + NoOfPassengers)<= PeopleAireplane.MaxOfPassengers )
            {
                PeopleAireplane.CurrentNoOfPassengers += NoOfPassengers;
                Console.WriteLine($"\n\tAirplane {PeopleAireplane.Identification}" +
                $" loads {NoOfPassengers} passengers");

            }

            else
            {
                Console.WriteLine($"\n\tAirplane {PeopleAireplane.Identification} charges {PeopleAireplane.MaxOfPassengers - PeopleAireplane.CurrentNoOfPassengers}" +
                    $", {NoOfPassengers}  do not fit");
            }
               
        }

        public void Unloadpassengers()
        {

            Console.WriteLine($"\n\tAirplane {PeopleAireplane.Identification}" +
                $" discharges {PeopleAireplane.CurrentNoOfPassengers} passengers");

            /*
             * change the current passengers to 0 after unloading
             */
            PeopleAireplane.CurrentNoOfPassengers = 0;

        }

        public void TakeOff()
        {
            if (!PeopleAireplane.IsFlying)
            {
                PeopleAireplane.IsFlying = true;
                Console.WriteLine($"\n\tPlane {PeopleAireplane.Identification}" +
                    $" rises");
            }
            else
            {
                Console.WriteLine($"\n\t Airplane {PeopleAireplane.Identification} cannot take off, because we are already flying");
            }
           

        }

        public void Lands()
        {
            if (PeopleAireplane.IsFlying)
            {
                PeopleAireplane.IsFlying = false;
                Console.WriteLine($"\n\tPlane {PeopleAireplane.Identification}" +
                    $" Lands");

            }
            else
            {
                Console.WriteLine($"\tAirplane {PeopleAireplane.Identification} cannot land,because we are still on the ground");
            }

        }

    }
}
