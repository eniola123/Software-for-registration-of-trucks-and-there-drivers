using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckManager
{
  public  class Drivers : Idriver
    {
        public Drivers(string driversname, int driverslicensenumber)
        {
            DriversName = driversname;
            DriversLicenseNumber = driverslicensenumber;

        }

        public string DriversName
        
        {
            get;            
            set;            
        }   

        public int DriversLicenseNumber
        {
            get;

            set;
            
        }
        public override string ToString()
        {
            return "DriversName: " + DriversName + " DriversLicenseNumber: " + DriversLicenseNumber;
        }
    }
}
