namespace _6_domaci_4
{
     
        internal class Program
        {
            static int zbir;
            static void Main(string[] args)
            {
                bool josUPetlji = true;

                try
                {
                    while (josUPetlji)
                    {
                        josUPetlji = MainMenu();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Greska " + ex.Message);
                }
            }

            public static bool MainMenu()
            {

                Console.Clear();
                Console.WriteLine("1) Pokrenite aplikaciju ili nastavite sa unosom novog broja ");
                Console.WriteLine("2) Exit");

                string ulaz = Console.ReadLine();
                if (ulaz == "1")
                {
                    Ngranica();
                    //ZbirBrojeva(Aplikacija());
                    return true;
                }
                else if (ulaz == "2")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            public static void Ngranica()
            {
                Console.Clear();
                Console.Write("Unesite koliko brojeva zelite da aplikacija primi: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    ZbirBrojeva(Aplikacija());
                }
                Console.WriteLine("Kraj");

            }

            public static int Aplikacija()
            {
                Console.Clear();
                int noviBroj;
                Console.Write("Unesite broj: ");
                int broj = int.Parse(Console.ReadLine());
                if(broj % 2 ==0)
                {
                   noviBroj = broj * 3;
                   return noviBroj;
                }
                else
               {
                return 0;
               }
                   
            }

            public static void ZbirBrojeva(int broj)
            {

                zbir += broj;
                Console.WriteLine("Trenutno zbir je " + zbir);
                Console.WriteLine("Kliknite za dalje");
                Console.ReadLine();
            }
        }
    }


