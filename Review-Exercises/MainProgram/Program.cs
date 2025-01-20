using MyLibrary;
namespace MainProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string Msg = "Introdueix el preu del ticket:";
            const string MsgResult = "Has de deixar una propina de {0}€";

            float cost = 0;

            while (cost == 0)
            {
                Console.WriteLine(Msg);
                cost = CheckUserInput(Console.ReadLine());
            }

            float tip = (MyLibrary.Math.ReturnTip(cost));

            Console.WriteLine(MsgResult, tip);
        }
        public static float CheckUserInput(string input)
        {
            const string ErrFormatException = "ERROR! NO ÉS UN NOMBRE ENTER";
            const string ErrOverflowException = "ERROR! EL NOMBRE ÉS MASSA GRAN";
            const string ErrException = "ERROR INESPERAT";

            float num = 0;
            try
            {
                num = float.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine(ErrFormatException);
            }
            catch (OverflowException)
            {
                Console.WriteLine(ErrOverflowException);
            }
            catch (Exception)
            {
                Console.WriteLine(ErrException);
            }
            return num;
        }
    }
}
