using MyLibrary;
namespace MainProgram
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const string Msg = "Introdueix la temperatura en celsius";
            float celsius, fahrenheit;
            Console.WriteLine(Msg);
            celsius = float.Parse(Console.ReadLine());
            fahrenheit = MyLibrary.Math.CelsiusToFahrenheit(celsius);
            Console.WriteLine(fahrenheit);
        }
    }
}
