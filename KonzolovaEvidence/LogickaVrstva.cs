namespace Projekt_Matusinec_1
{
    public class LogickaVrstva
    {
        private EvidencePojistencu databaze;
        private Vypisovac vypisovac;
        public LogickaVrstva()
        {
            databaze = new EvidencePojistencu();
            vypisovac = new Vypisovac();
        }

        /// <summary>
        /// Metoda pro spuštění logické vrstvy aplikace. 
        /// Obsahuje switch pro možnosti volby
        /// Opakuje se v cyklech, dokud ji uživatel neukončí
        /// </summary>
        public void Start()
        {
            char znak;
            bool pokracovat = true;
            while (pokracovat)
            {
                Console.WriteLine(vypisovac.UvodniObrazovka());
                Console.WriteLine(vypisovac.Moznosti());
                znak = Console.ReadKey().KeyChar;
                switch (znak)
                {
                    case '1': Pridej(); break;

                    case '2': Vyhledej(); break;

                    case '3': Vymaz(); break;

                    case '4': Vypis(); break;

                    case '5':
                        pokracovat = false;
                        Console.WriteLine(vypisovac.UkonceniAplikace());
                        break;

                    default: Console.WriteLine(vypisovac.NeplatnaVolba()); break;
                }
                Console.WriteLine(vypisovac.Pokracovat());
                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
            }
        }



        private string ValidovatTextovePole(string prompt)
        {
            string vstup;
            bool platnyVstup;

            do
            {
                Console.Write(prompt);
                vstup = Console.ReadLine();

                platnyVstup = !Validator.PrazdnePole(vstup) && Validator.PouzeText(vstup) && Validator.DelkaTextu(vstup);

                if (!platnyVstup)
                {
                    Console.WriteLine(vypisovac.NeplatnyTextovyVstup());
                }
            } while (!platnyVstup);

            return vstup;
        }

        private string ValidovatTelefonniCislo(string prompt)
        {
            string telCislo;
            bool platneTelCislo;

            do
            {
                Console.Write(prompt);
                telCislo = Console.ReadLine();

                platneTelCislo = Validator.PlatneTelefonniCislo(telCislo);

                if (!platneTelCislo)
                {
                    Console.WriteLine(vypisovac.NeplatneTelCislo());
                }
            } while (!platneTelCislo);

            return telCislo;
        }

        private int ValidovatVek(string prompt)
        {
            int vek;
            bool platnyVek;

            do
            {
                Console.Write(prompt);
                string vstup = Console.ReadLine();

                platnyVek = int.TryParse(vstup, out vek) && Validator.PlatnyVek(vstup);

                if (!platnyVek)
                {
                    Console.WriteLine(vypisovac.NeplatnyVek());
                }
            } while (!platnyVek);

            return vek;
        }

        /// <summary>
        /// Metoda přidává nový záznam do evidence po validaci vstupů
        /// </summary>
        public void Pridej()
        {
            string jmeno = ValidovatTextovePole(vypisovac.ZadaniJmena());
            string prijmeni = ValidovatTextovePole(vypisovac.ZadaniPrijmeni());
            int vek = ValidovatVek(vypisovac.ZadaniVeku());
            string telCislo = ValidovatTelefonniCislo(vypisovac.ZadaniTelCisla());

            databaze.PridejPojisteneho(jmeno, prijmeni, vek, telCislo);
            Console.WriteLine(vypisovac.PotvrzeniPridani());
        }

        /// <summary>
        /// Metoda vyhledává na základě jména a příjmení
        /// </summary>
        public void Vyhledej()
        {
            string jmeno = ValidovatTextovePole(vypisovac.ZadaniJmena());
            string prijmeni = ValidovatTextovePole(vypisovac.ZadaniPrijmeni());
            Console.WriteLine(databaze.NajdiPojisteneho(jmeno, prijmeni));
        }

        /// <summary>
        /// Metoda slouží ke smazání jednotlivých záznamů v evidenci
        /// </summary>
        public void Vymaz()
        {
            string jmeno = ValidovatTextovePole(vypisovac.ZadaniJmena());
            string prijmeni = ValidovatTextovePole(vypisovac.ZadaniPrijmeni());
            databaze.VymazPojisteneho(jmeno, prijmeni);
            Console.WriteLine(vypisovac.PotvrzeniOdebrani());
        }

        /// <summary>
        /// Metoda slouží pro výpis všech záznamů ze seznamu
        /// </summary>
        public void Vypis()
        {
            List<Pojisteny>? seznamPojistenych = databaze.VypisVsechnyZaznamy();
            if (seznamPojistenych == null)
            {
                Console.WriteLine(vypisovac.PrazdnaEvidence());
            }
            else
            {
                foreach (var pojisteny in seznamPojistenych)
                {
                    Console.WriteLine($"{pojisteny.Jmeno}\t{pojisteny.Prijmeni}\t{pojisteny.Vek}\t{pojisteny.TelCislo}");
                }
            }
        }


    }
}






