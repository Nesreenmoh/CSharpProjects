
namespace AirportProgram.Models
{
    public class Airplane
    {
      

        public string Identification { get; set; }

        public bool IsFlying { get; set; }


        public double Speed { get; set; }

        public int Max { get; set; }

        public int Current { get; set; }


        public Airplane(string identification, bool isFlying, double speed)
        {
            Identification = identification;
            IsFlying = isFlying;
            Speed = speed;
        
        }




    }
}
