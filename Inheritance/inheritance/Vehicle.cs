public abstract class Vehicle
{
    public Vehicle(string number)
    {
        vehicleNumber = number;

    }
    string vehicleNumber;
    public string vehicleNumber
    {
        get => vehicleNumber;
        set{
            if(value != "" && value.Length > 5)
            vehicleNumber = value;
        }


    }
    public string Brand { get; set; } = "";
    public DateTime Year { get; set; }
    public VehicleType Type { get; set; } = VehicleType.Wa
}