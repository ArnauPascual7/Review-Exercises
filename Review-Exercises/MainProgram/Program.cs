using MyLibrary;
namespace MainProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string Msg = "Introdueix un nombre:";

            Console.WriteLine(Msg);
            int seconds = CheckUserInput(Console.ReadLine());
            Console.WriteLine(MyLibrary.Math.SecondsToTime(seconds));
        }
        public static int CheckUserInput(string input)
        {
            int num = 0;
            try
            {
                num = int.Parse(input);
            }
            catch (FormatException e)
            {
                throw new FormatException("ERROR! NO ÉS UN NOMBRE ENTER", e);
            }
            catch (OverflowException e)
            {
                throw new OverflowException("ERROR! EL NOMBRE ÉS MASSA GRAN", e);
            }
            catch (Exception e)
            {
                throw new Exception("ERROR INESPERAT", e);
            }
            return num;
        }
    }
}
