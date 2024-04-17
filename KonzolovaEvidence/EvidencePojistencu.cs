using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Projekt_Matusinec_1
{

    /// <summary>
    /// Tady přidat instanci vypisovače a z výpisů pojištěných odebrat konkrétní výpis
    /// a nahradit jej vypisovačem!
    /// </summary>
    public class EvidencePojistencu
    {
        private Vypisovac vypisovac;
        /// <summary>
        /// List pro uložení záznamů
        /// </summary>
        private List<Pojisteny> pojisteni;

        /// <summary>
        /// Konstruktor pro třídu Databaze
        /// </summary>
        public EvidencePojistencu()
        {
            pojisteni = new List<Pojisteny>();
            vypisovac = new Vypisovac();
        }

        /// <summary>
        /// Metoda pro přidání nového záznamu do databáze
        /// </summary>
        /// <param name="jmeno">Jméno pojištěného</param>
        /// <param name="prijmeni">Příjmení pojištěného</param>
        /// <param name="vek">Věk pojištěného</param>
        /// <param name="telCislo">Telefonní číslo pojištěného</param>
        public void PridejPojisteneho(string jmeno,string prijmeni,int vek, string telCislo)
        {
            pojisteni.Add(new Pojisteny(jmeno,prijmeni,vek,telCislo));
        }

        /// <summary>
        /// Metoda pro vyhledání záznamu podle jména a přijmení
        /// </summary>
        /// <param name="jmeno">Jméno pojištěného</param>
        /// <param name="prijmeni">Přijmení pojištěného</param>
        /// <returns></returns>
        public Pojisteny? NajdiPojisteneho(string jmeno, string prijmeni) 
        {
            for (int i = 0; i < pojisteni.Count; i++)
            {
                if (pojisteni[i].Jmeno==jmeno && pojisteni[i].Prijmeni == prijmeni)
                {
                    return pojisteni[i];
                }
            }
            return null;
        }

        /// <summary>
        /// Metoda pro smazání záznamu podle jména a přijmení
        /// </summary>
        /// <param name="jmeno">Jméno pojištěného</param>
        /// <param name="prijmeni">Přijmení pojištěného</param>
        public void VymazPojisteneho(string jmeno, string prijmeni)
        {
            for (int i = 0; i < pojisteni.Count; i++)
            {
                if (pojisteni[i].Jmeno == jmeno && pojisteni[i].Prijmeni == prijmeni)
                {
                    pojisteni.RemoveAt(i);
                    break;
                }
            }
        }


        public List<Pojisteny>? VypisVsechnyZaznamy()
        {
            if (pojisteni.Count == 0)
            {
                return null;
            }
            else
            {
                return pojisteni;
            }
        }
    }
}
