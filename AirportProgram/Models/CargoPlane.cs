

namespace AirportProgram.Models
{
    public class CargoPlane : Airplane
    {
      

        public double MaxCargo { get; set; }
        public double CurrentCargo { get; set; }

        public CargoPlane(string identification, bool isFlying,double speed,  double maxCargo, double currentCargo) : base(identification, isFlying, speed)
        {
            MaxCargo = maxCargo;
            CurrentCargo = currentCargo;
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
