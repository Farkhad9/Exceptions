

using Exceptions.Models;

namespace Exceptions
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //double result = Exchange(Currecy.Try, 2);
            //Console.WriteLine($"konvertasiya neticesinde elde olunmush mebleg: {result}");
            #endregion
            #region task2
            //Kelvin kelvin = new Kelvin(500);
            //Celsius celsius = kelvin;
            //Console.WriteLine($" degree is : { celsius.Degree}");
            #endregion
        }
        #region task1
        public static double Exchange(Enum curr, double azn)
        {
            if (curr.GetType() != typeof(Currecy))
            {
                throw new Exception($"Gonderilen Enum Obyekti Currecy Enum Deyil");
            }
            Currecy currecy = (Currecy)curr;

            switch (currecy)

            {
                case Currecy.Usd:
                    return azn * 0.59;
                case Currecy.Eur:
                    return azn * 0.55;
                case Currecy.Try:
                    return azn * 17.89;
                default:
                    throw new Exception("bilinməyən valyuta");
            }

        }
        #endregion
    }
}
