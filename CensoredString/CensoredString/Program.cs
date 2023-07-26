using System.IO;
using System.Text;

namespace CensoredString
{
    public class program
    {
       
        public static string Uncensor(string str, string vowels)
        {
            string uncensored = "";
            int vowelCounter = 0;

            for (int i = 0; i < str.Length; i++)
            {
                uncensored += (str[i] != '*' ? str[i] : vowels[vowelCounter++]);
            }

            return uncensored;
        }

        public static void Main()
        {
            Console.WriteLine(Uncensor("Wh*r* d*d my v*w*ls g*?", "eeioeo"));
            Console.WriteLine(Uncensor("abcd", ""));
            Console.WriteLine(Uncensor("*PP*RC*S*", "UEAE"));
            Console.WriteLine(Uncensor("sl*wm*t**n", "ooio"));

        }
    }
}