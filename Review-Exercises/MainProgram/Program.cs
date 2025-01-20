using MyLibrary;
namespace MainProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Msg = "Introdueix un número:";
            const string MsgResult = "El nombre té {0} xifres";

            int num = 0;

            while (num == 0)
            {
                Console.WriteLine(Msg);
                num = CheckUserInput(Console.ReadLine());
            }

            int xifres = (MyLibrary.Math.CountDigits(num));

            Console.WriteLine(MsgResult, xifres);
        }
        public static int CheckUserInput(string input)
        {
            const string ErrFormatException = "ERROR! NO ÉS UN NOMBRE ENTER";
            const string ErrOverflowException = "ERROR! EL NOMBRE ÉS MASSA GRAN";
            const string ErrException = "ERROR INESPERAT";

            int num = 0;
            try
            {
                num = int.Parse(input);
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
