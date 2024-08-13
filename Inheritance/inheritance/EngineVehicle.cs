public class EngineVehicle: Vehicle, IVehicle
{
    public EngineVehicle(string name, float engineCC, float mileage) : base(name)
    {
        EngineCC = engineCC;
        Mileage = mileage;
    }

    public float EngineCC { get; set; }
    public float Mileage { get; set;}
    public float GetDistanceCovered(float fuelUsed) => Mileage * fuelUsed;
}


//inherit class and implement interface.