using System;
using System.Collections.Generic;
using System.Text;

namespace AirportProgram.Models
{
    public class Airport
    {

        public string Name { get; set; }

        public IList<Airplane> Airplanes { get; set; }


        public Airport(string name, IList<Airplane> airplanes)
        {
            Name = name;
            Airplanes = airplanes;
        }


    }
}
