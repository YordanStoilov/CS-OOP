
namespace NeedForSpeed;
public class RaceMotorcycle : Motorcycle
{
    public new double DefaultFuelConsumption { get; set; } = 8;
    public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
    {
        FuelConsumption = DefaultFuelConsumption;
    }
}
