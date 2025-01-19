using MyLibrary;
namespace MainProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Msg = "Introdueix una temperatiura en Celsius:";
            const string MsgResult = "Celsius: {0} - Kelvin: {1}";
            const string ErrReadingNum = "ERROR! El valor no es un número";

            float celsius = 0;
            bool flag = true;

            do
            {
                Console.WriteLine(Msg);

                flag = !float.TryParse(Console.ReadLine(), out celsius);

                if (flag)
                {
                    Console.WriteLine(ErrReadingNum);
                }
            } while (flag);

            float fahrenheit = MyLibrary.Math.CelsiusToKelvin(celsius);

            Console.WriteLine(MsgResult, celsius, fahrenheit);
        }
    }
}
