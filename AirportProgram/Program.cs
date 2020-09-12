using AirportProgram.Controllers;
using AirportProgram.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace AirportProgram
{
   public  class Program
    {
        static void Main(string[] args)
        {
            AirplaneController airplaneController1, airplaneController2;

            Airplane PeopleAireplane1 = new PeoplePlane("ABC123",60,20,false,234.0);
            Airplane PeopleAireplane2 = new PeoplePlane("DDD888",70,30,false,555.0);

            airplaneController1 = new AirplaneController((PeoplePlane)PeopleAireplane1);
            airplaneController1.loadpassengers(50);
            airplaneController1.Lands();

            airplaneController1.TakeOff();

            airplaneController2 = new AirplaneController((PeoplePlane)PeopleAireplane2);
            airplaneController2.loadpassengers(23);
            airplaneController1.Lands();
            airplaneController1.Unloadpassengers();

            airplaneController2.TakeOff();
            airplaneController2.TakeOff();
            airplaneController2.Lands();
            airplaneController2.Unloadpassengers();


            /*
            * Adding cargo Plane to the airport
            * 
            */
            CargoPlane cargoPlane1 = new CargoPlane("FF2134", false, 345.7, 2000, 1000);
            CargoPlane cargoPlane2 = new CargoPlane("PLA166", false, 400, 4000, 2000);

            /// creating Airport and adding airplanes to it
            IList<Airplane> Airplanes = new List<Airplane>();
            Airplanes.Add(PeopleAireplane1);
            Airplanes.Add(PeopleAireplane2);
            Airplanes.Add(cargoPlane1);
            Airplanes.Add(cargoPlane2);
            Airport airport = new Airport("Eindhoven", Airplanes);

            AirportController AirportController = new AirportController(airport);
            AirportController.PrintAirplanes();

            /*
             * Requesting airplane are not flying and has room for passengers
             */
            var AvailableAirplanes= AirportController.ReturnAvailableAirplanes();
            foreach(var Plane in AvailableAirplanes)
            {
                Console.WriteLine($"\n\tPlane {Plane.Identification} requested.Is not flying, still room for {((PeoplePlane)(Plane)).MaxOfPassengers- ((PeoplePlane)Plane).CurrentNoOfPassengers} passengers.");
            }

            airplaneController2.loadpassengers(25);


            CargoController cargoController1 = new CargoController(cargoPlane1);
            cargoController1.Lands();
            cargoController1.LoadCargo(3000);
            cargoController1.TakeOff();


        }
    }
}
