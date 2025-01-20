namespace MyLibrary
{
    public class Math
    {
        public static bool CheckIfArrayOrdered(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1]) return false;
            }
            return true;
        }
    }
}
