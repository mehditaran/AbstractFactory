using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class FactoryProducer
    {
        public static AbstractFactory getFactory(string choice)
        {
            if (choice.Equals("VEHICLE"))
            {
                return new VehicleFactory();
            }
            else if (choice.Equals("COLOR"))
            {
                return new ColorFactory();
            }
            return null;
        }
    }
}
