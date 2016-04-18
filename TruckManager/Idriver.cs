using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckManager
{
  public interface Idriver
    {
        string DriversName { get; set; }
        int DriversLicenseNumber { get; set; }
    }
}
