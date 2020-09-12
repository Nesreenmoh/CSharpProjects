
using AirportProgram.Interfaces;
using System;

namespace AirportProgram.Models
{
   public class PeoplePlane : Airplane, IJetEngine
    {

     
        public int MaxOfPassengers { get; set; }

        public int CurrentNoOfPassengers { get;  set; }

      

        public PeoplePlane(string identification, int maxOfPassengers, int currentNoOfPassengers, bool isFlying, double speed): base(identification, isFlying, speed)
        {
           
            MaxOfPassengers = maxOfPassengers;
            CurrentNoOfPassengers = currentNoOfPassengers;
          
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
            Console.WriteLine("\n\tThe People plane is Starting ....");
        }
    }
}
