using System.Text.RegularExpressions;

namespace Itenium.FreelanceJobs.DataAccess.Models
{
    public class Slugify
    {
        public static string GenerateSlug(string phrase)
        {
            string str = RemoveAccent(phrase.ToLower());
            str = Regex.Replace(str, @"[^a-z0-9\s-]", "-");
            str = Regex.Replace(str, @"\s+", " ").Trim();
            str = Regex.Replace(str, @"\s", "-");
            str = Regex.Replace(str, @"-+", "-");
            //str = str.Substring(0, str.Length <= 45 ? str.Length : 45).Trim();
            str = str.Trim(' ', '-');
            return str;
        }

        public static string RemoveAccent(string txt)
        {
            byte[] bytes = System.Text.Encoding.GetEncoding("Cyrillic").GetBytes(txt);
            return System.Text.Encoding.ASCII.GetString(bytes);
        }
    }
}