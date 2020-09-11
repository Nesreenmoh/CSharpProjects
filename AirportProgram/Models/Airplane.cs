
namespace AirportProgram.Models
{
    public class Airplane
    {
       

        public string Identification { get; set; }
        public int MaxOfPassengers { get; set; }

        public int CurrentNoOfPassengers { get; set; }

        public bool IsFlying { get; set; }

        public double Speed { get; set; }


        public Airplane(string identification, int maxOfPassengers, int currentNoOfPassengers, bool isFlying, double speed)
        {
            Identification = identification;
            MaxOfPassengers = maxOfPassengers;
            CurrentNoOfPassengers = currentNoOfPassengers;
            IsFlying = isFlying;
            Speed = speed;
        }

        public override string ToString()
        {
            return
                $"Identification {Identification} " +
                $"Max Number of Passengers {MaxOfPassengers} " +
                $"Current Number of Passengers {CurrentNoOfPassengers}" +
                $"Speed {Speed}"+
                $"Is flying : {IsFlying}";
        }

    }
}
