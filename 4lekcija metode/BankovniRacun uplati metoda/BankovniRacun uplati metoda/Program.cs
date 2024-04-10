namespace BankovniRacun_uplati_metoda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bankovni racun ");
            BankovniRacun mojRacun = new BankovniRacun();

            //unos iznosa uloganja 
            Console.WriteLine("Unesi iznos ulaganja");
            long novac = long.Parse(Console.ReadLine());

            // poziv metoda za uplatu novca na mojRacun
            mojRacun.Uplati(novac);
        }
    }

    public class BankovniRacun
    {
        private long stanje;
        public void Uplati(long suma)
        {
            stanje = stanje + suma;
        }
    }
}
