using Dal;
using MyDto;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
//using System.Xml;
using Newtonsoft.Json;


namespace SearchProject
{
    public class BLL
    {
        public static int X;
        public static int Y;

        private static List<location> l = new List<location>();
        private static string T = dal.OpenFile();
        //public static List<location> TTTT()//הכנסת כל התורה לרשימה
        //{
        //    string[] chumashim = T.Split('$');
        //    string lastPerek = "";
        //    for (int i = 0; i < chumashim.Length; i++)
        //    {
        //        string findChumashStart = chumashim[i].Substring(chumashim[i].IndexOf("~") + 1);
        //        string sefer = findChumashStart.Substring(0, findChumashStart.IndexOf("פרק"));
        //        string[] parashot = chumashim[i].Split('^');
        //        for (int j = 1; j < parashot.Length; j++)
        //        {
        //            int indexParashot1 = parashot[j].IndexOf("~");
        //            int indexParashot2 = parashot[j].IndexOf("!");
        //            string parasha = "";
        //            if (indexParashot1 < indexParashot2)
        //            {
        //                parasha = parashot[j].Substring(0, indexParashot1);
        //            }
        //            else
        //            {
        //                parasha = parashot[j].Substring(0, indexParashot2);
        //            }
        //            string first = parashot[j].Substring(parashot[j].IndexOf("{") + 1);
        //            string firstPasukInParasha = first.Substring(0, first.IndexOf('}'));
        //            string[] prakim = parashot[j].Split('~');
        //            bool flag = true;
        //            for (int n = 1; n < prakim.Length; n++)
        //            {
        //                string findPerek = prakim[n].Substring(prakim[n].IndexOf("פרק"));
        //                string perek = findPerek.Substring(0, findPerek.IndexOf('!'));
        //                if (!firstPasukInParasha.Equals("א") && flag)
        //                {
        //                    perek = lastPerek;
        //                    n = n - 1;
        //                }
        //                flag = false;
        //                string[] psukim = prakim[n].Split('!');
        //                for (int k = 1; k < psukim.Length; k++)
        //                {
        //                    string findPasuk = psukim[k].Substring(psukim[k].IndexOf("{") + 1);//אינדקס התחלת הפסוק
        //                    string pasuk = findPasuk.Substring(0, findPasuk.IndexOf('}'));//הפסוק מיוצג כאות
        //                    string text = psukim[k].Substring(psukim[k].IndexOf("}") + 1);//הפסוק מיוצג כמלל
        //                    l.Add(new location()
        //                    {
        //                        Parasha = parasha,
        //                        Pasuk = pasuk,
        //                        Perek = perek,
        //                        Book = sefer,
        //                        Text = text
        //                    });
        //                    // הליסט שלי יכיל הרבה פארט תורה
        //                    // 😀😀😀😀😀😀😀😀😀😀😀😀😀😀😀
        //                    // כלומר, הליסט של כל התורה יהיה מורכב
        //                    // מהרבה אובייקטים שכל אחד מייצג פסוק בתורה
        //                    // ומכיל פרטים עליו: באיזה חומש הוא,
        //                    // באיזו פרשה, באיזה פרק, באיזה פסוק ומה תוכנו
        //                }
        //                lastPerek = perek;
        //            }
        //        }
        //    }
        //    string updateJson = JsonConvert.SerializeObject(l);
        //    //StreamWriter allTora = new StreamWriter(@"C:\Users\משתמש חדש\Desktop\AllTora.txt");
        //    StreamWriter allTora = new StreamWriter(@"C:\Users\משתמש חדש\Desktop\PcSharp\Dal\bin\Debug\Objects.json");

        //    allTora.WriteLine(updateJson);
        //    allTora.Close();

        //    return l;
        //}

        public static List<location> deserializeJson()
        {
            string pp = File.ReadAllText(@"C:\Users\משתמש חדש\Desktop\PcSharp\Dal\bin\Debug\objects.json");
            List<location> l = JsonConvert.DeserializeObject<List<location>>(pp);
            return l;
        }
        public static List<location> Answer(string anyword)
        {
            X = 0;
            anyword= ConversionForEnglish(anyword);
            
            // int index = T.IndexOf(anyword);
            List<location> all = deserializeJson();//ליסט של כל התורה מחולקת לפסוקים
            List<location> find = new List<location>();//ליסט של הפסוקים שבהם קיימת המילה המבוקשת
            foreach (var item in all)
            {
                if (item.Text.IndexOf(anyword) != -1)
                {
                    find.Add(item);
                    X++;
                }
            }
            return find;
        }

        public static List<location> RT(string anyword)
        {
            anyword = ConversionForEnglish(anyword);
            Y = 0;
            if (anyword.Length < 2 || anyword.Contains(' '))
                return null;

            List<String> indexes = new List<String>();
            String result = "";
            String txt = Dal.dal.OpenFile();
            int j = 0, k = 0;
            while (txt.Length != 0)
            {
                for (int i = 0; i < txt.Length && j < anyword.Length;)
                {
                    if (txt.StartsWith(anyword[j]))
                    {
                        //שרשור המילה הנכונה וחיתוך הטקסט לאחריה ע"פ אורכה
                        k = 1;
                        while (txt[i] != ' ' && i < txt.Length - 1)
                        {
                            result += txt[i];
                            i++;
                            k++;
                        }
                        txt = txt.Substring(k);
                        i = 0;
                        result += ' ';
                        j++;
                    }
                    else
                    {
                        j = 0;
                        result = "";
                        k = 1;
                        // חוזר על חלק מהנל אך כך בהיר יותר
                        while (txt[i] != ' ' && i < txt.Length - 1)
                        {
                            k++;
                            i++;
                        }
                        txt = txt.Substring(k);
                        i = 0;
                        j = 0;
                    }
                    if (j == anyword.Length)
                    {
                        if (!indexes.Contains(result))
                            Y++;
                        indexes.Add(result);
                        // לסדר את החיתוך- אחרי המילה הראשונה
                        txt = txt.Substring(txt.IndexOf(result) + 1);
                        result = "";
                        j = 0;
                    }
                }
            }
            List<location> places = new List<location>();
            // כתוב בשתי הפונקציות בנפרד ולא בראשית כדי שלא יוסיף כותרות עבור כל קריאה לפונקציה
            location title = new location();
            if (indexes.Count != 0)
                for (int i = 0; i < indexes.Count; i++)
                {
                    List<location> ss = new List<location>();
                    string res = indexes[i];
                    ss = Answer(res);
                    //הוספת רשימה לרשימה
                    places.AddRange(ss);
                }
            return places;

            places.Clear();
            location noResults = new location();
            //noResults.Book = "לא נמצאו ראשי תבות עבור הערך המבוקש";
            places.Add(noResults);
            return places;

        }


        public static string ConversionForEnglish(string anyword)
        {
            {
                for (int i = 0; i < anyword.Length; i++)
                {
                    anyword = anyword.Replace('t', 'א');
                    anyword = anyword.Replace('c', 'ב');
                    anyword = anyword.Replace('s', 'ד');
                    anyword = anyword.Replace('v', 'ה');
                    anyword = anyword.Replace('u', 'ו');
                    anyword = anyword.Replace('d', 'ג');
                    anyword = anyword.Replace('z', 'ז');
                    anyword = anyword.Replace('j', 'ח');
                    anyword = anyword.Replace('y', 'ט');
                    anyword = anyword.Replace('h', 'י');
                    anyword = anyword.Replace('f', 'כ');
                    anyword = anyword.Replace('l', 'ך');
                    anyword = anyword.Replace('k', 'ל');
                    anyword = anyword.Replace('n', 'מ');
                    anyword = anyword.Replace('o', 'ם');
                    anyword = anyword.Replace('b', 'נ');
                    anyword = anyword.Replace('i', 'ן');
                    anyword = anyword.Replace('x', 'ס');
                    anyword = anyword.Replace('g', 'ע');
                    anyword = anyword.Replace('p', 'פ');
                    anyword = anyword.Replace(';', 'ף');
                    anyword = anyword.Replace('m', 'צ');
                    anyword = anyword.Replace('.', 'ץ');
                    anyword = anyword.Replace('e', 'ק');
                    anyword = anyword.Replace('r', 'ר');
                    anyword = anyword.Replace('a', 'ש');
                    anyword = anyword.Replace(',', 'ת');
                }
           return anyword;
            }
        }
}
}


    //    X = 0;
    //    // int index = T.IndexOf(anyword);
    //    List<location> all = deserializeJson();//ליסט של כל התורה מחולקת לפסוקים
    //    List<location> find = new List<location>();//ליסט של הפסוקים שבהם קיימת המילה המבוקשת
    //    for (var item = 0; item < all.Count; item++)
    //    {
    //        int i = anyword.Length;
    //        int j = 0;
    //        while (j < i && all[item].Text.Substring(0).IndexOf(anyword.Substring(j)) != -1)
    //        {
    //            j++;
    //            item++;

//        }
//        if (i == j)
//        {
//            X++;
//            find.Add(all[item]);
//        }
//        else
//        {
//            j = 0;
//        }
//    }
//    return find;
//}

