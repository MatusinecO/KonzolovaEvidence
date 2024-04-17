using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Projekt_Matusinec_1
{
    public class Validator
    {
        /// <summary>
        /// Metoda zachycující prázdné pole při vstupu
        /// </summary>
        /// <param name="text">Parametrem je text jako například jméno, či příjmení</param>
        /// <returns></returns>
        public static bool PrazdnePole(string text)
        {
            return string.IsNullOrEmpty(text);
        }

        /// <summary>
        /// Metoda ověřuje, zda jsou zadány pouze písmena. Pokud záznam obsahuje číslici, nebo speciální znak, metoda vrací false
        /// </summary>
        /// <param name="text">Parametrem je text jako například jméno, či příjmení</param>
        /// <returns></returns>
        public static bool PouzeText(string text)
        {
            foreach (char znak in text)
            {
                if (!char.IsLetter(znak))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Metoda ověří, zda je text dostatečně dlouhý například pro jméno.
        /// </summary>
        /// <param name="text">Parametrem je text jako například jméno, či příjmení</param>
        /// <returns></returns>
        public static bool DelkaTextu(string text)
        {
            return text.Length >= 2;
        }

        /// <summary>
        /// Metoda validuje věk kontrolou, zda vstup není prázdný a je v rozmezí 1 - 120 let
        /// </summary>
        /// <param name="vek">Věk jako celé číslo</param>
        /// <returns></returns>
        public static bool PlatnyVek(string vek)
        {
            if (string.IsNullOrEmpty(vek))
            {
                return false;
            }


            if (int.TryParse(vek, out int vekCislo))
            {
                return vekCislo >= 0 && vekCislo <= 120;
            }

            return false;
        }

        /// <summary>
        /// Metoda ověřuje, zda je telefonní číslo ve správném formátu s předvolbou, nebo bez ní. Umožňuje přidání "+" do předvolby
        /// </summary>
        /// <param name="telefonniCislo">Telefonní číslo v rozsahu 9 čílel, nebo 12 čísel a znaménko "+"</param>
        /// <returns></returns>
        public static bool PlatneTelefonniCislo(string telefonniCislo)
        {
            if (string.IsNullOrEmpty(telefonniCislo))
            {
                return false;
            }

            // Ověření, že telefonní číslo má 9 až 12 číslic

            Match match = Regex.Match(telefonniCislo, "^[0-9]{9}|^[+][0-9]{1,2}[0-9]{9,12}$");

            return match.Success;
        }




    }
}
