using MyLibrary;
using System;
using System.Linq.Expressions;
namespace MainProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string Msg = "Introdueix dos nombres:";
            const string ErrMoreThan2 = "ERROR! Has escrit més de dos nombres";
            const string ErrLestThan2 = "ERROR! Has escrit menys de dos nombres";
            const string ErrReadingNum = "ERROR! '{0}' no es un número";

            string[] arr = new string[3];
            float height = 0;
            float width = 0;
            bool hFlag = true;
            bool wFlag = true;

            while (arr.Length != 2 || hFlag || wFlag)
            {
                Console.WriteLine(Msg);
                arr = Console.ReadLine().Split(" ", 3, StringSplitOptions.RemoveEmptyEntries);

                if (arr.Length > 2)
                {
                    Console.WriteLine(ErrMoreThan2);
                }
                else if (arr.Length < 2)
                {
                    Console.WriteLine(ErrLestThan2);
                }
                else
                {
                    hFlag = !float.TryParse(arr[0], out height);
                    wFlag = !float.TryParse(arr[1], out width);

                    if (hFlag)
                    {
                        Console.WriteLine(ErrReadingNum, arr[0]);
                    }
                    if (wFlag)
                    {
                        Console.WriteLine(ErrReadingNum, arr[1]);
                    }
                }
            }
            Console.WriteLine("Area del triangle: " + MyLibrary.Math.CalcTriangleArea(height, width));
        }
    }
}
