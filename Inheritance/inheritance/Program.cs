
// IVehicle car1 = new ElectricVehicle("BA 02 PA 3455");
// IVehicle car2 = new EngineVehicle("BA 02 PA 3455");
//modify instantiation process
//electric vehicle = number, range, batterycapacity
//engine vehicle = number, mileage, engine cc

ElectricVehicle car1 = new ElectricVehicle("BA 02 PA 3455", 350, 70.6f);
Console.WriteLine($"Vehicle number: {car1.VehicleNumber}, Range: {car1.Range}, BatteryCapacity: {car1.BatteryCapacity}");
EngineVehicle car2 = new EngineVehicle("BA 02 PA 3455", 1999.5f, 35.2f);
Console.WriteLine($"Vehicle number: {car2.VehicleNumber}, EngineCC: {car2.EngineCC}, BatteryCapacity: {car2.Mileage}");

Generics g = new ();
g.PrintDetails(car1.VehicleNumber, car2.VehicleNumber);

Generics<string, float> g2 = new ();
g2.PrintDetails(car1.VehicleNumber,car1.Range);
