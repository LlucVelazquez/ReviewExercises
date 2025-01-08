using MyLibrary;
using System.ComponentModel.DataAnnotations;
namespace MainProgram
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const string Msg= "Introdueix un numero";
            Console.WriteLine(Msg);
            int sec = ValidarNum(Console.ReadLine());
            Console.WriteLine(MyLibrary.Math.SecondToText(sec));
        }
        public static int ValidarNum(string input)
        {
            int num = 0;
            try 
            {
                num = int.Parse(input);
            } catch (Exception e)
            {
                throw new Exception("Error inesperat", e);
            }
            return num;
        }
    }
}
