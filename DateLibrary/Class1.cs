namespace DateLibrary
{
    public class DateLib
    {
        public static string GetFormattedDate(string format)
        {
            return DateTime.Now.ToString(format);
        }
        public static int RandomNumber(int start,int end)
        {
            Random r=new Random();
            return r.Next(start, end);
        }
    }
}
