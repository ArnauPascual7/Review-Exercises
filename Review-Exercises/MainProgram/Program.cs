using MyLibrary;
namespace MainProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Msg = "Introdueix un codi postal:";
            const string MsgIsPostalCode = "És un codi postal";
            const string MsgNotPostalCode = "No és un coid postal";

            Console.WriteLine(Msg);

            Console.WriteLine(MyLibrary.Math.CheckPostalCode(Console.ReadLine()) ? MsgIsPostalCode : MsgNotPostalCode);
        }
    }
}
