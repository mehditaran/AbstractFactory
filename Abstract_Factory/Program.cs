using System;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory vehicleFactory = (VehicleFactory)FactoryProducer.getFactory("VEHICLE");
            IVehicle car = vehicleFactory.getVehicle("Car");
            car.showVehicleType();
            IVehicle motorCycle = vehicleFactory.getVehicle("MotorCycle");
            motorCycle.showVehicleType();

            ColorFactory colorFactory = (ColorFactory)FactoryProducer.getFactory("COLOR");

            IColor redColor = colorFactory.getColor("RED");
            redColor.Fill();
            IColor blueColor = colorFactory.getColor("BLUE");
            blueColor.Fill();
        }
    }
}
