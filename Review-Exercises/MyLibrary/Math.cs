namespace MyLibrary
{
    public class Math
    {
        public static int CountDigits(int num)
        {
            num = num / 10;

            if (num <= 0) return 1;

            return 1 + CountDigits(num);
        }
    }
}
