namespace Abstract_Factory
{
    public class VehicleFactory : AbstractFactory
    {
        public IVehicle getVehicle(string vehicleType)
        {
            if (vehicleType == null)
            {
                return null;
            }
            else if (vehicleType.Equals("Car"))
            {
                return new Car();
            }
            else if (vehicleType.Equals("MotorCycle"))
            {
                return new MotorCycle();
            }
            return null;
        }
    }
}