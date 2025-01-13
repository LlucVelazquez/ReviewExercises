using MyLibrary;
namespace MainProgram
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const string Msg = "Introdueix la temperatura en Celsius: ";
            float celsius, kelvin;
            Console.WriteLine(Msg);
            celsius = float.Parse(Console.ReadLine());
            kelvin = MyLibrary.Math.CelsiusToKelvin(celsius);
            Console.WriteLine(kelvin);
        }
    }
}
