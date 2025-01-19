using MyLibrary;
namespace MainProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Msg = "Introdueix una temperatiura en Celsius:";
            const string MsgResult = "Celsius: {0} - Fahrenheit: {1}";
            const string ErrReadingNum = "ERROR! El valor no es un número";

            int celsius = 0;
            bool flag = true;

            do
            {
                Console.WriteLine(Msg);

                flag = !int.TryParse(Console.ReadLine(), out celsius);

                if (flag)
                {
                    Console.WriteLine(ErrReadingNum);
                }
            } while (flag);

            int fahrenheit = MyLibrary.Math.CelsiusToFahrenheit(celsius);

            Console.WriteLine(MsgResult, celsius, fahrenheit);
        }
    }
}
