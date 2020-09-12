

using AirportProgram.Interfaces;
using System;

namespace AirportProgram.Models
{
    public class CargoPlane : Airplane, IPropeller
    {
      

        public double MaxCargo { get; set; }
        public double CurrentCargo { get; set; }

        public CargoPlane(string identification, bool isFlying,double speed,  double maxCargo, double currentCargo) : base(identification, isFlying, speed)
        {
            MaxCargo = maxCargo;
            CurrentCargo = currentCargo;
        }

        public void TighteningPropellers()
        {
            Console.WriteLine(" \n\t Tightening the Propellers...");
        }
        public override string ToString()
        {
            return $"Identification: {Identification} " +
                $"Speed: {Speed}" +
                $"Is flying : {IsFlying}"+
                $"MaxCargo : {MaxCargo}" +
                $"CurrentCargo : {CurrentCargo}";
        }
    }
}
