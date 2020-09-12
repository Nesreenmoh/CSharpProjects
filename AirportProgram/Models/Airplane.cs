
namespace AirportProgram.Models
{
    public class Airplane
    {
      

        public string Identification { 
            get;
            private set; }

        public bool IsFlying { get; set; }


        public double Speed { get; set; }



        public Airplane(string identification, bool isFlying, double speed)
        {
            Identification = identification;
            IsFlying = isFlying;
            Speed = speed;
        
        }




    }
}
