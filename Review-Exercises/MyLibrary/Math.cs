namespace MyLibrary
{
    public class Math
    {
        public static bool CheckPostalCode(string str)
        {
            char[] arrCharPostalCode = str.ToCharArray();
            
            if (arrCharPostalCode.Length == 5)
            {
                int[] arrIntPostalCode = new int[arrCharPostalCode.Length];

                for (int i = 0; i < arrCharPostalCode.Length; i++)
                {
                    arrIntPostalCode[i] = CharToInt(arrCharPostalCode[i]);
                    if (arrIntPostalCode[i] == -1) return false;
                }
                return true;
            }
            return false;
        }
        public static int CharToInt(char ch)
        {
            int num = -1;
            try
            {
                num = int.Parse(ch.ToString());
            }
            catch (Exception)
            {
                num = -1;
            }
            return num;
        }
    }
}
