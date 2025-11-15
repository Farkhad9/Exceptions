

namespace Exceptions
{
    internal partial class Program
    {
        internal class Celsius
        {
            public Celsius(int celsius)
            {
                Degree = celsius;
            }
            public int Degree { get; set; }
            public static implicit operator Celsius(Kelvin kelvin)
            {
                return new Celsius(kelvin.Degree - 273);
            }
        }
        
    }
}
