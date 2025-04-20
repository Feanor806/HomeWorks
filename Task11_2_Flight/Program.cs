namespace Task11_2_Flight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFlyable[] flights = [
                    new Bird(4500),
                    new Airpalane(10000,350)
                ];

            foreach (IFlyable fly in flights)
            {
                fly.Fly();
            }

            Console.ReadKey();
        }

        public interface IFlyable
        {
            public int MaxAltitude { get; }
            public void Fly();
        }

        public class Bird : IFlyable
        {

            public int MaxAltitude { get; }

            public void Fly()
            {

                Console.WriteLine($"Я лечу на высоте {MaxAltitude} метров");
            }

            public Bird(int maxAltitude)
            {
                MaxAltitude = maxAltitude;
            }
        }

        public class Airpalane : IFlyable
        {
            public int MaxAltitude { get; }

            public int CountPassengers { get; set; }

            public void Fly()
            {
                Console.WriteLine($"Я лечу на высоте {MaxAltitude} метров, везу {CountPassengers} пассажиров");
            }

            public Airpalane(int maxAltitude, int countPassengers)
            {
                MaxAltitude = maxAltitude;
                CountPassengers = countPassengers;
            }
        }
    }
}
