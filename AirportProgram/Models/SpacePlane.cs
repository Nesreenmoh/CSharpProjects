using AirportProgram.Interfaces;
using System;


namespace AirportProgram.Models
{
    public class SpacePlane : Airplane, IJetEngine, IFlyingMissiles
    {
        public SpacePlane(string identification, bool isFlying, double speed) : base(identification, isFlying, speed)
        {
        }

        public void StartingMortor()
        {
            Console.WriteLine("SpacePlane is starting ...");
        }

       public void FlyingToTheRockets()
        {
            Console.WriteLine("SpacePlane is flying to the Rockets ...");
        }
    }
}
