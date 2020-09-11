
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
            IList<Airplane> AvailableAirplanes = new List<Airplane>() ;
            foreach (Airplane Airplane in Airport.Airplanes)
            {
                if((Airplane.CurrentNoOfPassengers< Airplane.MaxOfPassengers) && (!Airplane.IsFlying))
                {
                    AvailableAirplanes.Add(Airplane);
                }
            }

            return AvailableAirplanes;
        }

        public void PrintAirplanes()
        {
            Console.WriteLine("\n********************************************");
            Console.WriteLine($"\n\tAircraft from airport {Airport.Name}:");
            foreach (Airplane AirplaneList in Airport.Airplanes){
                Console.WriteLine($"\n\tAirplane {AirplaneList.Identification}");
            }
        }
    }
}
