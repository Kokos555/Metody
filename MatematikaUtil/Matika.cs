using System;

namespace MatematikaUtil
{
    public class Matika
    {
        /// <summary>
        /// Mocnina čísla
        /// </summary>
        /// <param name="cislo">Čislo které bude násobit mocněné číslo</param>
        /// <param name="mocnina">´Mocnina čísla</param>
        /// <returns>Vrátí mocninu čísla</returns>
        static public int Mocnina(int cislo,int mocnina)
        {
            int prvek = 1;
            for (int p = 0; p < mocnina; p++)
            {
                prvek *= cislo;
            }
            return prvek;
        }
    }
}
