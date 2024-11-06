namespace VehicleInspection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string carBrand = "Audi";
            string carModel = "A6";
            DateTime carProductionDate = new DateTime(2018, 7, 1);
            DateTime carLastInspection = new DateTime(2022, 12, 8);
            Vehicle car = new Car(carBrand, carModel, carProductionDate, carLastInspection);


            string truckBrand = "Volvo";
            string truckModel = "FH";
            DateTime truckProductionDate = new DateTime(2018, 10, 1);
            DateTime truckLastInspection = new DateTime(2021, 10, 1);
            Vehicle truck = new Truck(truckBrand, truckModel, truckProductionDate, truckLastInspection);

            Console.WriteLine(car.DisplayInfo());
            Console.WriteLine(car.InspectionStatus());
            Console.WriteLine();
            Console.WriteLine(truck.DisplayInfo());
            Console.WriteLine(truck.InspectionStatus());
        }
    }
}
