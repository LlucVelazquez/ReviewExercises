using MyLibrary;
namespace MainProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string MsgBase = "La base del triangle: ";
            const string MsgAlt = "La altura del triangle: ";
            float baseTriangle, alturaTriangle, areaTriangle;
            Console.Write(MsgBase);
            baseTriangle = float.Parse(Console.ReadLine());
            Console.Write(MsgAlt);
            alturaTriangle = float.Parse(Console.ReadLine());
            areaTriangle = MyLibrary.Math.AreaTriangle(baseTriangle, alturaTriangle);
            Console.Write(areaTriangle);
        }
    }
}
