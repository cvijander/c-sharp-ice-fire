namespace PrvoVelikoSlovo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Prvo veliko slovo");
                Console.WriteLine("Unesite tekst");
                string ulaz = Console.ReadLine();
                Console.WriteLine("Koliko veliki slova zelite : ");
                int broj = int.Parse(Console.ReadLine());
                //DajMiVelikoSlovo(ulaz);
                Console.WriteLine(DajMiVelikoSlovo(ulaz));
                Console.WriteLine(DajMiVelikoSlovo(ulaz,broj));
            }
            catch (Exception ex)
            {

                Console.WriteLine( "Greska " +ex.Message);
            }

           
        }

        public static string DajMiVelikoSlovo(string  tekst)
        {
            string novi = tekst.Substring(0,1).ToUpper() + tekst.Substring(1).ToLower();
            return novi;
        }

        public static string DajMiVelikoSlovo(string tekst, int broj)
        {
            string novi = tekst.Substring(0, broj).ToUpper() + tekst.Substring(broj).ToLower();
            return novi;
        }
    }
}
