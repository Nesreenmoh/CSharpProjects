using AirportProgram.Models;
using System;


namespace AirportProgram.Controllers
{
    public class CargoController
    {
       
        public CargoPlane CargoPlane { get; set; }

        public CargoController(CargoPlane cargoPlane)
        {
            CargoPlane = cargoPlane;
        }

        public void LoadCargo(int Cargo)
        {
            if ((CargoPlane.CurrentCargo + Cargo) <= CargoPlane.MaxCargo)
            {
                CargoPlane.CurrentCargo += Cargo;
                Console.WriteLine($"\n\tAirplane {CargoPlane.Identification}" +
                $" loads {Cargo} tons of cargo");

            }

            else
            {
                Console.WriteLine($"\n\tAirplane {CargoPlane.Identification} charges {CargoPlane.MaxCargo - CargoPlane.CurrentCargo}" +
                    $", {Cargo} tons does not fit");
            }
        }

        public void UnloadCargos()
        {

            Console.WriteLine($"\n\tAirplane {CargoPlane.Identification}" +
                $" unloads {CargoPlane.CurrentCargo} tons of cargo");
            /*
             * change the current Cargoes to 0 after unloading
             */
            CargoPlane.CurrentCargo = 0;
        }

        public void TakeOff()
        {
            if (!CargoPlane.IsFlying)
            {
                CargoPlane.IsFlying = true;
                Console.WriteLine($"\n\tPlane {CargoPlane.Identification}" +
                    $" rises");
            }
            else
            {
                Console.WriteLine($"\n\t Airplane {CargoPlane.Identification} cannot take off, because we are already flying");
            }


        }

        public void Lands()
        {
            if (CargoPlane.IsFlying)
            {
                CargoPlane.IsFlying = false;
                Console.WriteLine($"\n\tPlane {CargoPlane.Identification}" +
                    $" Lands");

            }
            else
            {
                Console.WriteLine($"\n\tAirplane {CargoPlane.Identification} cannot land,because we are still on the ground");
            }

        }
    }
}
