using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class Car : IVehicle
    {
        public void showVehicleType()
        {
            Console.WriteLine("Vehicle: Car");
        }
    }
}
