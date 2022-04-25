using System;

namespace PosloupnostUtil
{
    public class Posloupnost
    {
        /// <summary>
        /// Součet aritmetické posloupnosti
        /// </summary>
        /// <param name="a1">První člen</param>
        /// <param name="a2">Druhý člen</param>
        /// <param name="n">Počet členů</param>
        /// <param name="diference">Rozdíl a2 - a1</param>
        /// <returns>Součet n členů arimetické posloupnosti</returns>
        static public int SoucetArPosl(ref int a1, int a2, int n, out int diference)
        {
            diference = a2 - a1;
            int soucet = 0;
            for (int i = 0; i < n - 1; i++)
            {
                soucet += a1;
                a1 += diference;
            }
            soucet += a1;
            return soucet;
        }
    }
}
