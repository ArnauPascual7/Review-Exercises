using MyLibrary;
namespace MainProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Msg = "Introdueix una temperatiura en Kelvin:";
            const string MsgResult = "Kelvin: {0} - Fahrenheit: {1}";
            const string ErrReadingNum = "ERROR! El valor no es un número";

            float kelvin = 0;
            bool flag = true;

            do
            {
                Console.WriteLine(Msg);

                flag = !float.TryParse(Console.ReadLine(), out kelvin);

                if (flag)
                {
                    Console.WriteLine(ErrReadingNum);
                }
            } while (flag);

            float fahrenheit = MyLibrary.Math.KelvinToFahrenheit(kelvin);

            Console.WriteLine(MsgResult, kelvin, fahrenheit);
        }
    }
}
