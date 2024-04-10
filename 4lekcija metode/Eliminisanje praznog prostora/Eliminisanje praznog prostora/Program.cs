namespace Eliminisanje_praznog_prostora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Console.WriteLine(UklanjanjePraznina());
            Console.WriteLine(UklanjanjeSredine(UklanjanjePraznina()));
        }

        public static string UklanjanjePraznina()
        {
            Console.WriteLine("Unesite recenici ");
            string ulaz = Console.ReadLine();
            Console.WriteLine("Ukupno ima sada " +ulaz.Length + " karaktera.");
            ulaz =ulaz.Trim();
            Console.WriteLine("Ukupno ima sada " + ulaz.Length + " karaktera.");
             return ulaz;
        }

        public static string UklanjanjeSredine(string recenica)
        {
            char[] niz = recenica.ToCharArray();
            char[] noviNiz = new char [niz.Length];
            for (int i = 0; i < recenica.Length; i++)
            {
                if (niz[i]==' ' && niz[i+1]==' ')
                {
                    noviNiz[i] = ' ';
                }
                else
                {
                    noviNiz[i]=niz[i];
                }
            }
            Console.WriteLine("Ukupno ima sada " + noviNiz.Length + " karaktera.");
            return new string (noviNiz.ToString());
        }
    }
}
