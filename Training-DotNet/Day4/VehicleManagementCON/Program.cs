using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementLIB;

namespace VehicleManagementCON
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehObj = new Vehicle(100,"Alto","Car",4);
            Console.WriteLine("Vehicle No. - " + vehObj.VehicleNo);
            Console.WriteLine("Vehicle Name - " + vehObj.VehicleName);
            Console.WriteLine("Vehicle Type - " + vehObj.VehicleType);
            Console.WriteLine("VehicleCapacity - " + vehObj.VehicleCapacity);
        }
    }
}
