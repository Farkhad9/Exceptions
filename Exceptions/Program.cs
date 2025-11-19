

using Exceptions.Models;
using System.Xml;

namespace Exceptions
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Menu");
                Console.WriteLine("1. Square");
                Console.WriteLine("2. Rectangular");
                Console.WriteLine("0. Quit");


                Console.WriteLine("Zehmet olmasa komanda secin: ");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "1":
                        try
                        {
                            Console.WriteLine("Zehmet olmasa kvadratin terefini qeyd edin: ");
                            int side = Convert.ToInt32(Console.ReadLine());
                            Square square = new Square(side);
                            square.CalcArea();

                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: Invalid input format. Please enter a valid integer.");
                        }
                        break;

                    case "2":
                        try
                        {
                            Console.WriteLine("Zehmet olmasa duzbucaqlinin tereflerini qeyd edin: ");
                            int width = Convert.ToInt32(Console.ReadLine());
                            int length = Convert.ToInt32(Console.ReadLine());
                            Rectangular rectangular = new Rectangular(width, length);
                            rectangular.CalcArea();

                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: Invalid input format. Please enter a valid integer.");
                        }
                        break;
                    case "0":
                        {
                            Console.WriteLine("istifade etdiyiniz ucun tesekkurler");
                            return;
                        }
                    default:
                        Console.WriteLine("Seciminiz Yanlisdir!!");
                        break;
                }
            }
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
