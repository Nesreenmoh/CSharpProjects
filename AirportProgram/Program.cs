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

            Airplane airplane1 = new Airplane("ABC123",60,20,false,234.0);
            Airplane airplane2 = new Airplane("DDD888",70,30,false,555.0);

            airplaneController1 = new AirplaneController(airplane1);
            airplaneController1.loadpassengers(50);
            airplaneController1.Lands();

            airplaneController1.TakeOff();

            airplaneController2 = new AirplaneController(airplane2);
            airplaneController2.loadpassengers(23);
            airplaneController1.Lands();
            airplaneController1.Unloadpassengers();

            airplaneController2.TakeOff();
            airplaneController2.TakeOff();
            airplaneController2.Lands();
            airplaneController2.Unloadpassengers();


            /// creating Airport and adding airplanes to it
            IList<Airplane> Airplanes = new List<Airplane>();
            Airplanes.Add(airplane1);
            Airplanes.Add(airplane2);
            Airport airport = new Airport("Eindhoven", Airplanes);

            AirportController AirportController = new AirportController(airport);
            AirportController.PrintAirplanes();

            /*
             * Requesting airplane are not flying and has room for passengers
             */
            var AvailableAirplanes= AirportController.ReturnAvailableAirplanes();
            foreach(var Plane in AvailableAirplanes)
            {
                Console.WriteLine($"\n\tPlane {Plane.Identification} requested.Is not flying, still room for {Plane.MaxOfPassengers- Plane.CurrentNoOfPassengers} passengers.");
            }

            airplaneController2.loadpassengers(25);
        }
    }
}
