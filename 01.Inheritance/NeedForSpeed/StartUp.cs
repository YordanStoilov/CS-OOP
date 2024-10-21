namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Car sportCar = new(298, 80);
            Console.WriteLine(sportCar.DefaultFuelConsumption);
            Console.WriteLine(sportCar.FuelConsumption);
        }
    }
}
