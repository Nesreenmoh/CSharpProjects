

namespace AirportProgram.Models
{
    public abstract class Airplane
    {
     

        public string Identification { get; set; }
        public bool IsFlying { get; set; }
        public double Speed  {get; set;}

        public Airplane(string identification, bool isFlying, double speed)
        {
            Identification = identification;
            IsFlying = isFlying;
            Speed = speed;
        }

        public abstract void Load(int PeopleOrCargo);
        public abstract void Unload();
        public abstract void TakeOff();
        public abstract void lands();
    }
}
