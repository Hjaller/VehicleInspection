using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInspection
{
    internal class Truck :  Vehicle
    {

        public Truck(string brand, string model, DateTime productionDate, DateTime lastInspection)
            : base(brand, model, productionDate, lastInspection)
        {
        }

        public override bool InspectionStatus()
        {
            int productionYears = DateTime.Now.Year - ProductionDate.Year;
            int inspectionYears = DateTime.Now.Year - LastInspection.Year;

            return productionYears > 1 && inspectionYears > 1;
        }

        public override string DisplayInfo()
        {
            return $"Truck: {Brand} {Model}";
        }

        public override void SetTireType(bool isWinterTire)
        {
            MaxRimSize = isWinterTire ? 17 : 20;
        }
    }
}
