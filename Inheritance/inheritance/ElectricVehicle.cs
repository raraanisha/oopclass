public class ElectricVehicle : Vehicle, IVehicle
{
public ElectricVehicle(string number, short range, float batterycapacity)
: base(number)

{
    Range = range;
    BatteryCapacity = batterycapacity;

}

public float BatteryCapacity { get; set; }
public short Range { get; set; }

public float GetDistanceCovered(float batteryUsedPercentage) => Range / 100 * batteryUsedPercentage;
}


public float GetMileage(float batteryUsedPercentage)
{
    Range / batteryUsedPercentage
    return mileagePerPercent;
}
}
