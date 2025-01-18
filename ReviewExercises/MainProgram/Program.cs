using MyLibrary;
namespace MainProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string MsgPreu = "Introdueix el preu inicial: ";
            const string MsgPreuDescompte = "Introdueix el preu amb descompte: ";
            float preu = 0;
            float preuDescompte = 0;
            float descompte;
            LoopNum(MsgPreu, preu);
            LoopNum(MsgPreuDescompte, preuDescompte);
            descompte = MyLibrary.Math.CalculateDiscount(preu, preuDescompte);
            Console.WriteLine(descompte);

        }
        public static void LoopNum(string Msg, float num)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine(Msg);
                num = ValidateNum(Console.ReadLine());
                if (num != 0)
                {
                    flag = false;
                }
            }
        }
        public static float ValidateNum(string input)
        {
            float num = 0;
            try
            {
                num = float.Parse(input);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return num;
        }
    }
}
