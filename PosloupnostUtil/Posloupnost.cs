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
        /// <summary>
        /// Obsah a tělesová uhlopříčka čtverce
        /// </summary>
        /// <param name="a">Strana A</param>
        /// <param name="uhlopricka_ctverce">Proměnná do které se bude ukládat tělosová uhlopříčka čtverce</param>
        /// <returns>Vrací tělesovou uhlopříčku a ohsah čtverce</returns>
        static public double Obsah(double a, out double uhlopricka_ctverce)
        {
            double obsah_ctverce = a * a;
            uhlopricka_ctverce = a * Math.Sqrt(2);
            return obsah_ctverce;
        }
        /// <summary>
        /// Obsah a tělesová uhlopříčka obdelníku
        /// </summary>
        /// <param name="a">Strana A</param>
        /// <param name="b">Strana B</param>
        /// <param name="uhlopricka_obdelniku">Porměnná do které se bude ukládat tělesová uhlopříčka obdelníku</param>
        /// <returns>Vrací tělesovou uhlopříčku a ohsah obdelníku</returns>

        static public double Obsah(double a, double b, out double uhlopricka_obdelniku)
        {
            double obsah_obdelniku = a * b;
            uhlopricka_obdelniku = Math.Sqrt((a * a) + (b * b));
            return obsah_obdelniku;
        }
        /// <summary>
        /// Objem a tělesová uhlopříčka krychle
        /// </summary>
        /// <param name="a">Strana A</param>
        /// <param name="telesova_uhlopricka">Tělesová uhlopříčka krychle</param>
        /// <returns>Vrací tělesovou uhlopříčku a ohsah krychle</returns>

        static public double Objem(double a, out double telesova_uhlopricka)
        {
            double objem_krychle = a * a * a;
            telesova_uhlopricka = a * Math.Sqrt(3);
            return objem_krychle;
        }
        /// <summary>
        /// Objem a tělesová uhlopříčka kvadru
        /// </summary>
        /// <param name="a">Strana A</param>
        /// <param name="b">Strana B</param>
        /// <param name="c">Strana C</param>
        /// <param name="telesova_uhlopricka_kvadru">Tělesová uhlopříčka Kvádru</param>
        /// <returns>Vrací tělesovou uhlopříčku a ohsah kvadru</returns>
        static public double Objem(double a, double b, double c, out double telesova_uhlopricka_kvadru)
        {
            double objem = a * b * c;
            telesova_uhlopricka_kvadru = Math.Sqrt((a * a) + (b * b) + (c * c));
            return objem;
        }
    }
}
