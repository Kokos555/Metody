using System;

namespace MatematikaUtil
{
    public class Matika
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="prvek"></param>
        /// <param name="cislo"></param>
        /// <param name="mocnina"></param>
        /// <returns></returns>
        static public int Mocnina(int prvek,int cislo,int mocnina)
        {
            for (int p = 1; p < mocnina; p++)
            {
                prvek *= cislo;
            }
            return prvek;
        }
    }
}
