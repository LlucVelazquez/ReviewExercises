namespace MyLibrary
{
    public class Math
    {
        public static string SecondToText(int sec)
        {
            int minutes, hours;
            minutes = sec / 60;
            hours = minutes / 60;
            sec = sec % 60;
            minutes = minutes % 60;

            return ($"{hours} hores {minutes} minuts {sec} segons");
        }
    }
}
