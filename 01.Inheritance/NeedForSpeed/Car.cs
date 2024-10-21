
namespace NeedForSpeed;
public class Car : Vehicle
{
    public new double DefaultFuelConsumption { get; set; } = 3;
    public Car(int horsePower, double fuel) : base(horsePower, fuel)
    {
        FuelConsumption = DefaultFuelConsumption;
    }
}
