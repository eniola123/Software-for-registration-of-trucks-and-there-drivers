using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckManager
{
    public class Truck : Itruck
    {
        public Truck (int licenseplatenumber, int numberOfdrivinginkm, int averagefuelconsumption, int numberoffuelpurchase)
        {

            LicensePlateNumber = licenseplatenumber;
            NumberOfDrivingInKM = numberOfdrivinginkm;
            AverageFuelConsumption = averagefuelconsumption;
            NumberOfFuelPurchase = numberoffuelpurchase;
        }

        public int AverageFuelConsumption
        {
            get;
            set;
          
        }

        public int LicensePlateNumber
        {
            get;
            set;
        }

        public int NumberOfDrivingInKM
        {
            get;
            set;
        }

        public int NumberOfFuelPurchase
        {
            get;
           set;
        }
        public override string ToString()
        {
            return "LicensePlateNumber: " + LicensePlateNumber + " NumberOfDrivingInKM: " + NumberOfDrivingInKM + "AverageFuelConsumption:" + AverageFuelConsumption + "NumberOfFuelPurchase:" + NumberOfFuelPurchase;
        }
    }
}
