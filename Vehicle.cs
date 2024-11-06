using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInspection
{
    internal abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime LastInspection { get; set; }


        public Vehicle(string brand, string model, DateTime productionDate, DateTime lastInspection)
        {
            Brand = brand;
            Model = model;
            ProductionDate = productionDate;
            LastInspection = lastInspection;
        }

        public abstract bool InspectionStatus();

        public virtual string DisplayInfo()
        {
            return $"Brand: {Brand}, Model: {Model}, Production Date: {ProductionDate}, Last Inspection: {LastInspection}";
        }
    }
}
