namespace VehicleInspection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string carBrand = "Audi";
            string carModel = "A6";
            bool carWinter = false;
            DateTime carProductionDate = new DateTime(2018, 7, 1);
            DateTime carLastInspection = new DateTime(2020, 12, 8);
            Vehicle car = new Car(carBrand, carModel, carProductionDate, carLastInspection);
            car.SetTireType(carWinter);


            string truckBrand = "Volvo";
            string truckModel = "FH";
            bool truckWinter = true;
            DateTime truckProductionDate = new DateTime(2018, 10, 1);
            DateTime truckLastInspection = new DateTime(2021, 10, 1);
            Vehicle truck = new Truck(truckBrand, truckModel, truckProductionDate, truckLastInspection);
            truck.SetTireType(truckWinter);

            Console.WriteLine(car.DisplayInfo());
            Console.WriteLine(car.InspectionStatus() ? "Bilen skal synes" : "Bilen skal ikke synes");
            Console.WriteLine($"Max rim size {car.MaxRimSize}");
            Console.WriteLine();
            Console.WriteLine(truck.DisplayInfo());
            Console.WriteLine(truck.InspectionStatus() ? "Lastbilen skal synes" : "Lastbilen skal ikke synes");
            Console.WriteLine($"Max rim size {truck.MaxRimSize}");
            Console.WriteLine();
            Console.WriteLine(car.GetInterfaceInfo());
        }
    }
}
