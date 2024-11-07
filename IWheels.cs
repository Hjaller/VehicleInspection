using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInspection
{
    internal interface IWheels
    {
        public int MaxRimSize { get; set; }

        public void SetTireType(bool isWinterTire);

        public string Info() 
        {
            return "Brug mig for alle objekter som køres på hjul.";
        }
    }
}
