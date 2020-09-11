using AirportProgram.Controllers;
using AirportProgram.Models;
using System;

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
            airplaneController1.loadpassengers(40);
            airplaneController1.TakeOff();

            airplaneController2 = new AirplaneController(airplane2);
            airplaneController2.loadpassengers(23);
            airplaneController1.Lands();
            airplaneController1.Unloadpassengers();

            airplaneController2.TakeOff();
            airplaneController2.Lands();
            airplaneController2.Unloadpassengers();

        }
    }
}
