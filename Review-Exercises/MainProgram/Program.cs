using MyLibrary;
namespace MainProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string MsgTicket = "Introdueix el preu del ticket:";
            const string MsgPeople = "Introdueix el nombre de persones:";
            const string MsgResult = "Cada persona ha de deixar una propina de {0}€";

            float cost = 0;
            int people = 0;

            while (cost == 0 || people == 0)
            {
                Console.WriteLine(MsgTicket);
                cost = CheckUserInput(Console.ReadLine());

                Console.WriteLine(MsgPeople);
                people = Convert.ToInt32(CheckUserInput(Console.ReadLine()));
            }

            float tip = (MyLibrary.Math.ReturnTip(cost, people));

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