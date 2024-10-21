
namespace NeedForSpeed;
public abstract class Vehicle
{
    protected Vehicle(int horsePower, double fuel)
    {
        Fuel = fuel;
        HorsePower = horsePower;
    }

    public double DefaultFuelConsumption { get; set; } = 1.25;
    public virtual double FuelConsumption { get; set; }
    public virtual double Fuel { get; set; }
    public int HorsePower { get; set; }

    public virtual void Drive(double kilometers)
    {
        Fuel = Math.Max(0, Fuel - (kilometers * FuelConsumption));
    }
}
