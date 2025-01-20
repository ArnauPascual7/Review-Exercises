using MyLibrary;
namespace MainProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MsgOrderedArray = "Array ordenada";
            const string MsgNotOrderedArray = "Array desordenada";

            int[] array = {1, 2, 5};

            Console.WriteLine(MyLibrary.Math.CheckIfArrayOrdered(array) ? MsgOrderedArray : MsgNotOrderedArray);
        }
    }
}
