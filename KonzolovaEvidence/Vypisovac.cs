using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Matusinec_1
{
    public class Vypisovac
    {
        /// <summary>
        /// Metoda vypisuje úvodní obrazovku s možnostmi volby
        /// </summary>
        /// <returns>Grafické zobrazení aplikace</returns>
        public string UvodniObrazovka()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"==========Evidence pojištěných==========");
            sb.AppendLine("Menu: ");
            sb.AppendLine("1 - Přidat pojištěného");
            sb.AppendLine("2 - Vyhledat pojištěného");
            sb.AppendLine("3 - Vymazat pojištěného");
            sb.AppendLine("4 - Vypsat seznam pojištěných");
            sb.AppendLine("5 - Ukončit program");


            return sb.ToString();

        }

        
        
        /// <summary>
        /// Vypíše text pro zadání jména
        /// </summary>
        /// <returns></returns>
        public string ZadaniJmena() => "Zadejte jméno: ";
        /// <summary>
        /// Vypíše text pro zadání příjmení
        /// </summary>
        /// <returns></returns>
        public string ZadaniPrijmeni() => "Zadejte příjmení: ";
        /// <summary>
        /// Vypíše text pro zadání věku
        /// </summary>
        /// <returns></returns>
        public string ZadaniVeku() => "Zadejte věk: ";
        /// <summary>
        /// Vypíše text pro zadání telefonního čísla
        /// </summary>
        /// <returns></returns>
        public string ZadaniTelCisla() => "Zadejte telefonní číslo: ";
        /// <summary>
        /// Vypíše text pro zadání možnosti výběru ze switche
        /// </summary>
        /// <returns></returns>
        public string Moznosti() => "Zadejte možnost: ";
        /// <summary>
        /// Informuje o úspěšném přidání záznamu
        /// </summary>
        /// <returns></returns>
        public string PotvrzeniPridani() => "Pojištený byl úspěšně přidán";
        /// <summary>
        /// Informuje o úspěšném odebrání záznamu
        /// </summary>
        /// <returns></returns>
        public string PotvrzeniOdebrani() => "Pojištený byl úspěšně odebrán";
        /// <summary>
        /// Vypíše text, který informuje o nespávném zadání vstupu textu
        /// </summary>
        /// <returns></returns>
        public string NeplatnyTextovyVstup() => "Toto pole musí obsahovat minimálně 2 znaky a nesmí zůstat prázdné";
        /// <summary>
        /// Informuje o nesprávném zadání věku na vstupu
        /// </summary>
        /// <returns></returns>
        public string NeplatnyVek() => "Zadejte číslo v rozmezí 0 - 120. Pole nesmí zůstat prázdné..";
        /// <summary>
        /// Vypíše výzvu k stisknutí klávesy pro pokračování v aplikaci
        /// </summary>
        /// <returns></returns>
        public string Pokracovat() => "Pro pokračování stiskněte libovolnou klávesu...";
        /// <summary>
        /// Informuje o špatně zadaném telefonním čísle
        /// </summary>
        /// <returns></returns>
        public string NeplatneTelCislo() => "Zadejte telefonní číslo ve formátu 123456789, nebo +123456789123";
        /// <summary>
        /// Informuje o nesprávné volbě (jiný znak než číslice, nebo číslice mimo rozsah switche)
        /// </summary>
        /// <returns></returns>
        public string NeplatnaVolba() => "Neplatná volba, opakujte výběr...";
        /// <summary>
        /// informuje o stavu databáze, pokud v ní není žádný záznam
        /// </summary>
        /// <returns></returns>
        public string PrazdnaEvidence() => "V evidenci nejsou žádní pojištění";
        /// <summary>
        /// Vypíše rozloučení po ukončení aplikace
        /// </summary>
        /// <returns></returns>
        public string UkonceniAplikace() => "Děkujeme za použítí aplikace!";
    }


}
