﻿using System;
using System.Windows.Forms;

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
        /// <summary>
        /// Jestli textbox obsahuje slovo
        /// </summary>
        /// <param name="slova">Slova, nebo věty</param>
        /// <param name="nejdelsi_slovo">Nějakou proměnou jako u Max</param>
        /// <param name="nejkratsi_slovo">Nějakou proměnou jako u Min</param>
        /// <returns>Vrací jestli daný text, obsahuje slovo, potom vrací nejdelší a nejkratší slovo</returns>
        static public bool ObsahujeSlovo(string[] slova, out string nejdelsi_slovo, out string nejkratsi_slovo)
        {
            nejkratsi_slovo = slova[0];
            nejdelsi_slovo = "";
            int projelo = 0;
            for (int i = 0; i < slova.Length - 1; i++)
            {
                if (slova[i].Length > nejdelsi_slovo.Length)
                {
                    nejdelsi_slovo = slova[i];
                }
                else if (slova[i].Length < nejkratsi_slovo.Length)
                {
                    nejkratsi_slovo = slova[i];
                }
                projelo = 1;
            }
            if (projelo == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// Zobrazení slov do listboxu
        /// </summary>
        /// <param name="cisla">Název Listboxu</param>
        /// <param name="slova">Celé slova</param>
        static public void Zobraz(ListBox cisla, string[] slova)
        {
            for (int i = 0; i < slova.Length; i++)
            {
                cisla.Items.Add(slova[i]);
            }
        }
        /// <summary>
        /// Zjištění jestli je slovo/věta alfanum.
        /// </summary>
        /// <param name="slovo">Proměná string, kde je zapsáno cokoli v listboxu</param>
        /// <param name="male_pismena">Proměná int na počet malých písmen</param>
        /// <param name="cifry">Proměná cifra na počet cifer</param>
        /// <param name="jine_znaky">Proměná jiné znaky na počet jiných znaků, než malých písmen a cifer</param>
        /// <returns>Vrací bool, jestli je slovo Alfanum, což znamená že slovo/věta je složena jenom z čísel a písmen</returns>
        static public bool JeAlfanum(string slovo, out int male_pismena, out int cifry, out int jine_znaky)
        {
            male_pismena = 0;
            cifry = 0;
            jine_znaky = 0;
            int projelo = 0;
            for (int i = 0; i < slovo.Length; i++)
            {
                if (slovo[i] >= 'a' && slovo[i] <= 'z')
                {
                    male_pismena++;
                }
                else if (slovo[i] >= '0' && slovo[i] <= '9')
                {
                    cifry++;
                }
                else if (slovo[i] != ' ')
                {
                    jine_znaky++;
                }
                projelo = 1;
            }
            if (projelo != 0 && jine_znaky == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="chain">Slova</param>
        /// <returns></returns>
        static public string Smaz(string chain)
        {
            int i = 0;
            while (i < chain.Length)
            {
                if (char.IsDigit(chain[i]))
                {
                    chain = chain.Remove(i, 1);
                }
                else i++;
            }
            return chain;
        }
    }
}
