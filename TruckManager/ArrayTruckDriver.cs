using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace TruckManager
{
    public class ArrayTruckDriver : IMultipleDriverTotrucks 
    
    {
        private IMultipleDriverTotrucks[] DriverTruck;
        private Idriver[] drivers;
        private Itruck[] Kilometer;   
        private static int DEFAULT_MAX_NUMBER_OF_KM = 10000;
        private static int DEFAULT_MAX_NUMBER_OF_Drivers = 1000;
        
        public ArrayTruckDriver()
        {
            drivers = new Idriver[DEFAULT_MAX_NUMBER_OF_Drivers];
            Count = 0;

            Kilometer = new Itruck[DEFAULT_MAX_NUMBER_OF_KM];
            Count = 0;
        }

       
        public void AddDriver(Idriver driverToAdd)
        {
            drivers[Count++] = driverToAdd;
            {
                if (AddDriver(drivers))
                {
                    throw new ArgumentException("driver is already added");
                }
                return ;
            }
        }

        private bool AddDriver(Idriver[] drivers)
        {
            throw new NotImplementedException();
        }

        public void KM(Itruck licenseplatenumber)
        {
            Kilometer[Count++] = licenseplatenumber;
        }

       
        public int Count
        {
            get;
            private set;
        }


        public override string ToString()
        {
            StringBuilder listOfDrivers = new StringBuilder();
            for (int i = 0; i < Count; i++)
            {
                listOfDrivers.AppendLine(drivers.ToString());
            }
            return listOfDrivers.ToString();
        }
    }

}

