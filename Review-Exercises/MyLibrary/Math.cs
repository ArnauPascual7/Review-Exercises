namespace MyLibrary
{
    public class Math
    {
        public static string DecimalToHexadecimal(int _decimal)
        {
            int res = 0;
            string hexadecimal = "";

            if (_decimal >= 16)
            {
                while (_decimal >= 16)
                {
                    res = _decimal % 16;

                    hexadecimal = CheckHexadecimalLetter(res) + hexadecimal;

                    _decimal = _decimal / 16;
                }
            }
            hexadecimal = CheckHexadecimalLetter(_decimal) + hexadecimal;
            return hexadecimal;
        }
        public static string CheckHexadecimalLetter(int num)
        {
            switch (num)
            {
                case 10:
                    return "A";
                case 11:
                    return "B";
                case 12:
                    return "C";
                case 13:
                    return "D";
                case 14:
                    return "E";
                case 15:
                    return "F";
                default:
                    return $"{num}";
            }
        }
    }
}
