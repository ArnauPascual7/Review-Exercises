using MyLibrary;
namespace MainProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string Msg = "Introdueix un nombre:";
            const string MsgResult = "Decimal: {0} - Hexadecimal: {1}";

            Console.WriteLine(Msg);
            int _decmial = CheckUserInput(Console.ReadLine());

            string hexadecimal = MyLibrary.Math.DecimalToHexadecimal(_decmial);

            Console.WriteLine(MsgResult, _decmial, hexadecimal);
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
