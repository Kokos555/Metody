using System;

namespace RetezecUtil
{
    public class Retezec
    {
        /// <summary>
        /// Zjistí jestli v text obsahuje cislo.
        /// </summary>
        /// <param name="text">Celý text</param>
        /// <param name="pocet">Pocet na ukládaní číslic které jsou v textu</param>
        /// <param name="soucet">Soucet čísel, která jsou lichá</param>
        /// <returns>Celkový počet čísel, a soucet lichcých čísel</returns>
        static public bool Obsahuje(string text, out int pocet, out int soucet)
        {
            soucet = 0;
            pocet = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= '0' && text[i] <= '9')
                {
                    pocet++;
                    if ((text[i] - 48) % 2 == 1)
                    {
                        soucet += text[i] - 48;
                    }
                }
            }
            if (pocet == 0) return false;
            return true;
        }
    }
}
