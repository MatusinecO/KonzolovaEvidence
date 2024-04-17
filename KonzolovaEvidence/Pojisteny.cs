using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Matusinec_1
{
    public class Pojisteny
    {
        /// <summary>
        /// Jméno pojištěného
        /// </summary>
        public string Jmeno { get; private set; }
        /// <summary>
        /// Příjmení pojištěného
        /// </summary>
        public string Prijmeni { get; private set; }
        /// <summary>
        /// Věk pojištěného (int)
        /// </summary>
        public int Vek { get; private set; }
        /// <summary>
        /// Telefonní číslo pojištěného
        /// </summary>
        public string TelCislo { get; private set; }

        /// <summary>
        /// Konstruktor pro třídu Pojisteny
        /// </summary>
        /// <param name="jmeno">Jméno</param>
        /// <param name="prijmeni">Příjmení</param>
        /// <param name="vek">Věk</param>
        /// <param name="telCislo">Telefonní číslo</param>
        public Pojisteny(string jmeno, string prijmeni, int vek, string telCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            TelCislo = telCislo; 
        }

        /// <summary>
        /// Vypisuje textovou reprezentaci pojištěného
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("\t{0} \t{1} \t{2} \t{3}",Jmeno,Prijmeni,Vek,TelCislo);
        }
    }
}
