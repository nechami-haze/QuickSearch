namespace Dal
{
    public class dal
    {
        public static string OpenFile()
        {

            string h = File.ReadAllText(@"C:\Users\משתמש חדש\Desktop\AllTora.txt");
            return h;

        }
    }
}
