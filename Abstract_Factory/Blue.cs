using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class Blue : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Color is Blue");
        }
    }
}
