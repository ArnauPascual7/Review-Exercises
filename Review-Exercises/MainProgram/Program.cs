using MyLibrary;
namespace MainProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MsgPrice = "Introdueix el preu inicial:";
            const string MsgDiscountPrice = "Introdueix el preu amb descompte:";
            const string MsgResult = "Percentatge de descompte: {0}%";

            float initialPrice = 0;
            float discountPrice = 0;

            initialPrice = ReadUserInput(initialPrice, MsgPrice);
            discountPrice = ReadUserInput(discountPrice, MsgDiscountPrice);

            float discount = MyLibrary.Math.DiscountPercentage(initialPrice, discountPrice);

            Console.WriteLine(MsgResult, discount);
        }
        public static float ReadUserInput(float num, string Msg)
        {
            while (num == 0)
            {
                Console.WriteLine(Msg);

                num = CheckUserInput(Console.ReadLine());
            }
            return num;
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
