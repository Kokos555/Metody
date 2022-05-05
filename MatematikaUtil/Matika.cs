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

        /// <summary>
        /// Zjištění prvočísla
        /// </summary>
        /// <param name="cislo">Číslo ze kterého chceme zjistit prvočislo</param>
        /// <returns>Vrátí bool, jestli číslo je/není prvočíslo</returns>
        static public bool Prvocislo(int cislo)
        {
            if (cislo == 1)
            {
                return false;
            }
            if (cislo == 2)
            {
                return true;
            }
            if (cislo % 2 == 0)
            {
                return false;
            }
            for (int i = 3; i <= Math.Sqrt(cislo); i += 2)
            {
                if (cislo % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
