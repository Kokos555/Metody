using MatematikaUtil;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PoleUtil
{
    public class Pole
    {
        /// <summary>
        /// Generovaní čísel do pole.
        /// </summary>
        /// <param name="pocet">Počet prvků </param>
        /// <param name="dolni_mez">Dolní interval</param>
        /// <param name="horni_mez">Horní internval</param>
        /// <returns>Vygenerované pole prvnků</returns>
        static public int[] Generovani(int pocet, int dolni_mez = 1, int horni_mez = 100)
        {
            Random nh = new Random();
            int[] pole = new int[pocet];
            for (int i = 0; i < pocet; i++)
            {
                int x = nh.Next(dolni_mez, horni_mez);
                pole[i] = x;
            }
            return pole;
        }

        /// <summary>
        /// Zobrazení do listboxu.
        /// </summary>
        /// <param name="cisla">Jméno listboxu</param>
        /// <param name="pole">Pole vygenerovaných čísel</param>
        static public void Zobrazit(ListBox cisla, int[] pole)
        {
            cisla.Items.Clear();
            for (int i = 0; i < pole.Length; i++)
            {
                cisla.Items.Add(pole[i]);
            }
        }
        /// <summary>
        /// Součet sudých čísel a počet lichých čísel
        /// </summary>
        /// <param name="pocet">Počet pro lichá čísla</param>
        /// <param name="pole">Pole vygenerovaných čísel</param>
        /// <returns>Součet sudých čísel a počet lichých</returns>
        static public int SoucetAPocet(out int pocet, int[] pole)
        {
            pocet = 0;
            int soucet = 0;
            foreach (int cisla in pole)
            {
                if (cisla % 2 == 0)
                {
                    soucet += cisla;
                }
                else
                {
                    pocet++;
                }
            }
            return soucet;
        }
        /// <summary>
        /// Zjištění jestli je posloupnost rostoucí.
        /// </summary>
        /// <param name="pole">Pole vygenerovaných čísel</param>
        /// <returns>Rostoucí posloupnost</returns>
        static public bool Roustouci(int[] pole)
        {
            for (int i = 1; i < pole.Length; i++)
            {
                if (pole[i] <= pole[i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Výměna maxima s posledním prvkem pole.
        /// </summary>
        /// <param name="pole">Pole vygenerovaných čísel</param>
        static public void Vymena(int[] pole)
        {
            int max = pole.Max();
            int poradi = Array.IndexOf(pole, max);
            int posledni_radek_pole = pole.Length - 1;
            pole[poradi] = pole[posledni_radek_pole];
            pole[posledni_radek_pole] = max;
        }
        /// <summary>
        /// Vynulovaní prkvů a mocnina prvků v poli
        /// </summary>
        /// <param name="pole">Pole vygenerovaných prvků</param>
        /// <param name="mocnina">Mocni na kterou se budou umocňovat prvky</param>
        /// <returns>Záporné prvky v poli dá na hodnotu 0 a kladné prvky v poli to umocní na zvolené číslo</returns>
        static public int[] VynulovaniAMocnina(int[] pole, int mocnina)
        {
            for (int i = 0; i < pole.Length; i++)
            {
                int cislo = pole[i];
                if (pole[i] < 0)
                {
                    pole[i] = 0;
                }
                else
                {
                    pole[i] = Matika.Mocnina(pole[i], cislo, mocnina);
                }
            }
            return pole;
        }
    }
}
