using AirportProgram.Models;
using System;
using System.Collections.Generic;


namespace AirportProgram
{
   public class Program
    {
        static void Main(string[] args)
        {

            /*
             * create People Airplane
             */
            PeopleAirplane PeopleAirplane1 = new PeopleAirplane("ABC123", 60, 20, false, 234.0);
            PeopleAirplane PeopleAirplane2 = new PeopleAirplane("DDD888", 70, 30, false, 555.0);

            /*
             * Create Cargo Airplane
             */

            CargoPlane cargoPlane1 = new CargoPlane("FF2134", false, 345.7, 2000, 1000);
            CargoPlane cargoPlane2 = new CargoPlane("PLA166", false, 400, 4000, 2000);

            /*
             * Add the airplanes to a list 
             */
            IList<Airplane> Airplanes = new List<Airplane>();
            Airplanes.Add(PeopleAirplane1);
            Airplanes.Add(PeopleAirplane2);
            Airplanes.Add(cargoPlane1);
            Airplanes.Add(cargoPlane2);

            /*
             * create an airport and add a list of airplanes to it
             */
            Airport Airport1 = new Airport("Endhoven", Airplanes);

            /*
             * Print all the data of the airport
             */
            Console.WriteLine("\n********************************************");
            Airport1.PrintAirplanes();
            Console.WriteLine("\n********************************************");
            Console.WriteLine("\n\t People Airplane Operations");
            //Load passengers 
            PeopleAirplane1.Load(30);
            // ask for landing while it is on the ground
            PeopleAirplane1.lands();
            // the plane takeoff
            PeopleAirplane1.TakeOff();
            // try to unload the passenngers while it is flying 
            PeopleAirplane1.Unload();
            // the plane lands
            PeopleAirplane1.lands();
            // the plane unload the passengers
            PeopleAirplane1.Unload();

            /*
             * Operations on the cargo airplane
             */
            Console.WriteLine("\n********************************************");
            Console.WriteLine("\n\t Cargo Airplane Operations");

            cargoPlane1.lands();
            cargoPlane1.Load(3000);
            cargoPlane1.TakeOff();
            cargoPlane1.Unload();



            Console.WriteLine("\n\t**************************************************");
            /*
             * Requesting passengers airplane are not flying and has room for passengers
             */
            var AvailableAirplanes = Airport1.ReturnAvailableAirplanes();
            try
            {
                foreach (var Plane in AvailableAirplanes)
                {
                    Console.WriteLine($"\n\tPlane {Plane.Identification} requested.Is not flying, still room for {((PeopleAirplane)(Plane)).MaxOfPassengers - ((PeopleAirplane)Plane).CurrentNoOfPassengers} passengers.");
                }
            }catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}

