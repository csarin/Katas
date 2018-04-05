using System;
using System.Collections.Generic;
using System.Linq;

namespace KataWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string cad = "aqui aqui esta esta aqui mañana mañana mañana ok oki ok de de tu mar claro oscuro estar";

            List<string> aux = ExtractWord(cad);

            var result = from p in aux
                         group p by p into g
                         orderby g.Count() descending
                         select new { Word = g.Key, Count = g.Count() };

            var maxResult = from q in result
                            where (q.Count == result.FirstOrDefault().Count)
                            select q;

            foreach (var item in maxResult)
            {
                Console.Write(item.Word + " ");
            }
        }
        
        public static List<string> ExtractWord(string cad)
        {
            List<string> words = new List<string>();

            while (cad.Contains(" "))
            {
                words.Add(cad.Substring(0, cad.IndexOf(' ')));
                cad = cad.Substring(cad.IndexOf(' ')+1);
                ExtractWord(cad);
            }

            words.Add(cad);

            return words;
        }
    }
}
