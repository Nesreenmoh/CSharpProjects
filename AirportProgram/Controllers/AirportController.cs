
using AirportProgram.Models;
using System;
using System.Collections.Generic;

namespace AirportProgram.Controllers
{
   public class AirportController
    {
        public Airport Airport { set; get; }

        public AirportController(Airport airport)
        {
            this.Airport = airport;
        }


        public IList<Airplane> ReturnAvailableAirplanes()
        {
            var AvailableAirplanes = new List<Airplane>() ;
            foreach (Airplane Airplane in Airport.Airplanes)
            {
                if (Airplane is PeoplePlane)
                {
                    if (((PeoplePlane)Airplane).CurrentNoOfPassengers < ((PeoplePlane)Airplane).MaxOfPassengers && (!Airplane.IsFlying))
                    {
                        AvailableAirplanes.Add((PeoplePlane)Airplane);
                    }
                }
                    
            }

            return AvailableAirplanes;
        }

        public void PrintAirplanes()
        {
            Console.WriteLine("\n********************************************");
            Console.WriteLine($"\n\tAircraft from airport {Airport.Name}:");
            foreach (Airplane AirplaneList in Airport.Airplanes){
                if(AirplaneList is PeoplePlane)
                Console.WriteLine($"\n\tPassenger Plane {AirplaneList.Identification}");
                else
                    Console.WriteLine($"\n\tCargo Plane {AirplaneList.Identification}");
            }
        }
    }
}
