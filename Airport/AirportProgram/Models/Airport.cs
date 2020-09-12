
using System;
using System.Collections.Generic;

namespace AirportProgram.Models
{
   public class Airport
    {
       
        // fields
        public string Name { get; set; }
        public IList<Airplane> Airplanes { get; set; }

        //constructor 
        public Airport(string name, IList<Airplane> airplanes)
        {
            Name = name;
            Airplanes = airplanes;
        }

        /*
         * Return available airplanes that has room and not flying
         */

        public IList<Airplane> ReturnAvailableAirplanes()
        {
            var AvailableAirplanes = new List<Airplane>();
            foreach (Airplane Airplane in Airplanes)
            {
                if (Airplane is PeopleAirplane)
                {
                    if (((PeopleAirplane)Airplane).CurrentNoOfPassengers < ((PeopleAirplane)Airplane).MaxOfPassengers && (!Airplane.IsFlying))
                    {
                        AvailableAirplanes.Add((PeopleAirplane)Airplane);
                    }
                } 

            }

            return AvailableAirplanes;
        }


        /*
         * Prints all airplanes in this airport
         */

        public void PrintAirplanes()
        {
          
            Console.WriteLine($"\n\tAircraft from airport {Name}:");
            foreach (Airplane AirplaneList in Airplanes)
            {
                if (AirplaneList is PeopleAirplane)
                    Console.WriteLine($"\n\tPassenger Plane {AirplaneList.Identification}");
                else
                    Console.WriteLine($"\n\tCargo Plane {AirplaneList.Identification}");
            }
        }
    }
}
