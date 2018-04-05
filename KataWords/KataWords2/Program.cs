using System;
using System.Collections.Generic;
using System.Linq;

namespace KataWordsRefactor
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> result = new Dictionary<string, int>();
            string cad = "aqui aqui esta esta aqui mañana mañana mañana ok oki ok de de tu mar claro oscuro estar";

            String[] palabras = cad.Split(" ");
            
            for (int i = 0; i < palabras.Length; i++)
            {
                int cont = 0;

                for (int j = 0; j < palabras.Length; j++)
                {
                    if (palabras[i].Contains(palabras[j]))
                    {
                        cont++;
                    }
                }

                if (!result.ContainsKey(palabras[i]))
                    result.Add(palabras[i], cont);
            }

            var maxResult = from q in result
                            where (q.Value == result.Values.FirstOrDefault())
                            select q;

            foreach (var item in maxResult)
            {
                Console.Write(item.Key + " ");
            }
        }
    }
}
