using AirportProgram.Interfaces;
using System;


namespace AirportProgram.Models
{
   public class CargoPlane: Airplane, IPropeller
    {
        public double MaxCargo { get; set; }
        public double CurrentCargo { get; set; }

        public CargoPlane(string identification, bool isFlying, double speed, double maxCargo, double currentCargo) : base(identification, isFlying, speed)
        {
            MaxCargo = maxCargo;
            CurrentCargo = currentCargo;
        }


        public override void Load(int Cargo)
        {
            if ((CurrentCargo + Cargo) <= MaxCargo)
            {
                CurrentCargo += Cargo;
                Console.WriteLine($"\n\tAirplane {Identification}" +
                $" loads {Cargo} tons of cargo");

            }

            else
            {
                Console.WriteLine($"\n\tAirplane {Identification} charges {MaxCargo - CurrentCargo}" +
                    $", {Cargo} tons does not fit");
            }
        }

        public override void Unload()
        {
            if (!IsFlying)
            {
                Console.WriteLine($"\n\tAirplane {Identification}" +
                 $" unloads {CurrentCargo} tons of cargo");
                /*
                 * change the current Cargoes to 0 after unloading
                 */
                CurrentCargo = 0;
            }else
            {
                Console.WriteLine($"\n\tAirplane {Identification}" +
              $" cannot unload cargoes because it is still flying");
            }
            
        }

        public override void TakeOff()
        {
            if (!IsFlying)
            {
                IsFlying = true;
                Console.WriteLine($"\n\tPlane {Identification}" +
                    $" rises");
            }
            else
            {
                Console.WriteLine($"\n\t Airplane {Identification} cannot take off, because we are already flying");
            }
        }

        public override void lands()
        {
            if (IsFlying)
            {
                IsFlying = false;
                Console.WriteLine($"\n\tPlane {Identification}" +
                    $" Lands");

            }
            else
            {
                Console.WriteLine($"\n\tAirplane {Identification} cannot land,because we are still on the ground");
            }
        }

        public override string ToString()
        {
            return $"Identification: {Identification} " +
                $"Speed: {Speed}" +
                $"Is flying : {IsFlying}" +
                $"MaxCargo : {MaxCargo}" +
                $"CurrentCargo : {CurrentCargo}";
        }

        public void TighteningPropellers()
        {
            Console.WriteLine(" \n\t Tightening the Propellers...");
        }
    }
}

