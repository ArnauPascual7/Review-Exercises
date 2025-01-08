namespace MyLibrary
{
    public static class Math
    {
        public static string SecondsToTime(int seconds)
        {
            int minutes = 0;
            int hours = 0;

            if (seconds < 0) throw new Exception("ERROR! S'ESPERA UN NOMBRE POSITIU");

            minutes = seconds / 60;
            hours = minutes / 60;
            seconds = seconds % 60;
            minutes = minutes % 60;

            return $"{hours} hores {minutes} minuts {seconds} segons";
        }
    }
}
