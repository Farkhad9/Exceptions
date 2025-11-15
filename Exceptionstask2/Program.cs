namespace Exceptionstask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Kelvin kelvin = new Kelvin(500);
            Celsius celsius = kelvin;
            Console.WriteLine(celsius.Degree);

        }
    }
}
