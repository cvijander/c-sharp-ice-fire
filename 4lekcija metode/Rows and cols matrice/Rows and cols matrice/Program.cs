namespace Rows_and_cols_matrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool OstaniuPetlji = true;

            while (OstaniuPetlji)
            {
                try
                {
                   OstaniuPetlji =  MainMenu();
                }
                catch (Exception ex )
                {

                    Console.WriteLine("Greska " + ex.Message);
                }           
            }                     

        }

        public static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Glavni meni");
            Console.WriteLine("1) Kvadratna matrica ");
            Console.WriteLine("2) Matrica sa dve promenljive (broj kolona i broj redova) ");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                KvadratnaMatrica();
                return true;
            }
            else if (result == "2")
            {
                MatricaSaDvePromenljive();
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void PokaziMatricu(int rows, int cols)
        {
            Random rand =new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(rand.Next(10,101)+ " ");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }

        public static void PokaziMatricu(int n)
        {
            Random r = new Random();
             for(int i = 0;i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(r.Next(10,101) + " ");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }

        public static  void KvadratnaMatrica()
        {
            Console.Clear();
            Console.WriteLine("Odabrali ste kvadratnu matricu koja sadrzi samo jedan tj broj redova je istovremeno i broj kolona");
            Console.Write("Unesite broj n: ");
            int rowsCols = int.Parse(Console.ReadLine());
            PokaziMatricu(rowsCols);
        }

        public static void  MatricaSaDvePromenljive()
        {
            Console.Clear();
            Console.Write("Unesite broj redova: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Unesite broj kolona: ");
            int cols = int.Parse(Console.ReadLine());

            PokaziMatricu(rows, cols);
        }

        


    }
}
