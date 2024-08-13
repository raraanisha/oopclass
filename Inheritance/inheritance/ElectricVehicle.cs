public class ElectricVehicle: Vehicle, IVehicle
{
    public ElectricVehicle(string number, short range, float batteryCapacity) : base (number)
    {
        BatteryCapacity = batteryCapacity;
        Range = range;
    }
    public float BatteryCapacity { get; set; }
    public short Range { get; set; }

    public float GetDistanceCovered(float batteryUsedPercentage)
    {
        //total range //return distance / batteryUsedPercentage * 100;
        //range per percentage //return distance / batteryUsedPercentage;

        //energy efficiency //return distance / (batteryUsedPercentage / 100) * BatteryCapacity;

        // var batteryUsed = batteryUsedPercentage / 100 * BatteryCapacity;
        // return distance / batteryUsed;
        var  mileagePerBatteryUsed = Range/ 100 * batteryUsedPercentage;
        return mileagePerBatteryUsed;
    }

    public float GetRange(float batteryCapacity, float energyEfficiency)
    {
        return batteryCapacity * energyEfficiency;
    }

    public float GetEnergyEfficiency(float distance, float batteryUsed)
    {
        return distance / batteryUsed;
    }
}