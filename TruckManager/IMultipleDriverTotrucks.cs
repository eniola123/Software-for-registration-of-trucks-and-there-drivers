using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckManager
{
   public interface IMultipleDriverTotrucks 
    {
        void AddDriver(Idriver driverToAdd) ;
        int Count { get; }
        void KM(Itruck licenseplatenumber);
    }
}
