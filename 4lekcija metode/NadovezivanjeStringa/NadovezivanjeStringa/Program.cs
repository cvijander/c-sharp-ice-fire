using System.Text;

namespace NadovezivanjeStringa
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            try
            {

                Console.WriteLine("Nadovezivanje stringa N puta");
                Console.WriteLine("Unesite zeljeni tekst ");
                string ulaz = Console.ReadLine();
                Console.Write("Unesite broj ponavljanja: ");
                int bPonavljanja = int.Parse(Console.ReadLine());
                Console.Write("Unesite i treci parametar m: ");
                int m =int.Parse(Console.ReadLine());
                Console.WriteLine("Rezultat " + Nadovezivanje(ulaz, bPonavljanja));
                Console.WriteLine("Rezultat preko string buildera");
                Console.WriteLine("Rezulata " + NadovezivanjeStringBulder(ulaz, bPonavljanja));
                Console.WriteLine("***************************************");
                 Nadovezivanje(ulaz, bPonavljanja,m);
                Console.WriteLine("Rezultat preko string buildera sa tri parametra" );
                Console.WriteLine("Rezulata " + NadovezivanjeStringBulder(ulaz, bPonavljanja,m));
            }
            catch (Exception ex)
            {

                Console.WriteLine("Greska " +ex.Message );
            }
            
        }
                

        public static string Nadovezivanje(string tekst, int broj )
        {
            string noviTekst = "";
            for (int i = 0;i< broj;i++ )
            {
                noviTekst += tekst +" | ";
            }
            return noviTekst;
        }

        public static void Nadovezivanje(string tekst, int broj, int m)
        {
            string[,] Matrica = new string[m, broj];
            string noviTekst = "";
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < broj; j++)
                {
                    
                     noviTekst += tekst + " | ";
                    Matrica[i, j] = noviTekst;
                    Console.Write(Matrica[i,j]);
                }
                Console.WriteLine();


            }
            
            
        }

        public static string NadovezivanjeStringBulder(string tekst, int broj)
        {
            StringBuilder b = new StringBuilder(tekst.Length * broj);
            for (int i = 0; i < broj; i++)
            {
                b.Append(tekst);
                b.Append(" | ");
            }
            return b.ToString();
              
        }
        public static string NadovezivanjeStringBulder(string tekst, int broj,int m)
        {
            StringBuilder b = new StringBuilder(tekst.Length * broj);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < broj; j++)
                {
                    b.Append(tekst);
                    b.Append(" | ");
                }
                Console.WriteLine();
            }
            return b.ToString();


        }
    }
}
