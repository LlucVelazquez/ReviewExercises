using MyLibrary;
namespace MainProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string Msg = "Introdueix la temperatura en kelvin: ";
            float kelvin = 0;
            float fahrenheit;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine(Msg);
                kelvin = ValidarNum(Console.ReadLine());
                if (kelvin != 0)
                {
                    flag = false;
                }
            }
            fahrenheit = MyLibrary.Math.KelvinToFahrenheit(kelvin);
            Console.WriteLine(fahrenheit);
        }
        public static float ValidarNum(string input)
        {
            float num = 0;
            try
            {
                num = float.Parse(input);
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return num;
        }
    }
}
