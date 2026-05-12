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

        public static long ReverseNumber(int n)
        {
            char[] ary=n.ToString().ToCharArray();
            string s = "";
            foreach (char c in ary)
            {
                s+= c;
            }
            return int.Parse(s);
        }
    }
}
