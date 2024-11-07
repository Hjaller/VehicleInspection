using System;

namespace VehicleInspection
{
    internal class Car : Vehicle
    {
        public Car(string brand, string model, DateTime productionDate, DateTime lastInspection)
            : base(brand, model, productionDate, lastInspection)
        {
        }

        public override bool InspectionStatus()
        {
            int productionYears = DateTime.Now.Year - ProductionDate.Year;
            int inspectionYears = DateTime.Now.Year - LastInspection.Year;

            return productionYears > 4 && inspectionYears > 2;
        }

        public override string DisplayInfo()
        {
            return $"Car: {Brand} {Model}";
        }

        public override void SetTireType(bool isWinterTire)
        {
            MaxRimSize = isWinterTire ? 16 : 22;
        }
    }
}
