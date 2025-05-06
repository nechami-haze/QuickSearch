namespace MyDto
{
    public class location
    {
        public int IndexOfWord { get; set; }
        public string Parasha { get; set; }
        public string Book { get; set; }
        public string Perek { get; set; }
        public string Pasuk { get; set; }
        public string Text { get; set; }


        public location(int index)
        {
            IndexOfWord = index;
        }
        public location()
        {

        }
        public override string ToString()
        {
            return " חומש " +Book + " \n " + Parasha + " \n " + Perek+ " \n  "+" פסוק " +Pasuk+" ' \n "+" '' "+ Text+" '' ";
        }
    }
}
