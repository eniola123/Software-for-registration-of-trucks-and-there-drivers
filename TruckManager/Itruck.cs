using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckManager
{
    public interface Itruck
    {
        int LicensePlateNumber { get; set; }
        int NumberOfDrivingInKM { get; set; }
        int AverageFuelConsumption { get; set; }
        int NumberOfFuelPurchase { get; set; }

    }
}
