namespace Abstract_Factory
{
    public class ColorFactory : AbstractFactory
    {
        public IColor getColor(string color)
        {
            if (color == null)
            {
                return null;
            }
            if (color.Equals("RED"))
            {
                return new Red();
            }
            if (color.Equals("BLUE"))
            {
                return new Blue();
            }
            return null;
        }
    }
}