using AirportProgram.Interfaces;
using System;


namespace AirportProgram.Models
{
    public class PeopleAirplane : Airplane, IJetEngine
    {
      

        public int MaxOfPassengers { get; set; }

        public int CurrentNoOfPassengers { get; set; }


        public PeopleAirplane(string identification, int maxOfPassengers, int currentNoOfPassengers, bool isFlying, double speed): base(identification, isFlying, speed)
        {
            MaxOfPassengers = maxOfPassengers;
            CurrentNoOfPassengers = currentNoOfPassengers;
        }

        public override void lands()
        {
            if (IsFlying)
            {
                IsFlying = false;
                Console.WriteLine($"\n\tPlane {Identification}" +
                    $" Lands");

            }
            else
            {
                Console.WriteLine($"\n\tAirplane {Identification} cannot land,because we are still on the ground");
            }
        }

        public override void Load(int NoOfPassengers)
        {
            if ((CurrentNoOfPassengers + NoOfPassengers) <= MaxOfPassengers)
            {
               CurrentNoOfPassengers += NoOfPassengers;
                Console.WriteLine($"\n\tAirplane {Identification}" +
                $" loads {NoOfPassengers} passengers");

            }

            else
            {
                Console.WriteLine($"\n\tAirplane {Identification} charges {MaxOfPassengers - CurrentNoOfPassengers}" +
                    $", {NoOfPassengers}  do not fit");
            }
        }

        public override void TakeOff()
        {
            if (!IsFlying)
            {
               IsFlying = true;
                Console.WriteLine($"\n\tPlane {Identification}" +
                    $" rises");
            }
            else
            {
                Console.WriteLine($"\n\t Airplane {Identification} cannot take off, because we are already flying");
            }
        }

        public override void Unload()
        {
            if(!IsFlying)
            {
                Console.WriteLine($"\n\tAirplane {Identification}" +
               $" discharges {CurrentNoOfPassengers} passengers");

                /*
                 * change the current passengers to 0 after unloading
                 */
                CurrentNoOfPassengers = 0;
            }
            else
            {
                Console.WriteLine($"\n\tAirplane {Identification}" +
               $" cannot unload passengers because it is still flying");
            }
           

        }

        public override string ToString()
        {
            return
                $"Identification {Identification} " +
                $"Max Number of Passengers {MaxOfPassengers} " +
                $"Current Number of Passengers {CurrentNoOfPassengers}" +
                $"Speed {Speed}" +
                $"Is flying : {IsFlying}";
        }

        public void StartingMortor()
        {
            Console.WriteLine("\n\t People plane is Starting ....");
        }
    }
}
