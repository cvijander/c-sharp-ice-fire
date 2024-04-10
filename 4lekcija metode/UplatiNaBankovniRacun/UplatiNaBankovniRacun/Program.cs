namespace UplatiNaBankovniRacun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uplati na racun");

            BankovniRacun racun1 = new BankovniRacun();
            racun1.Uplati(200);
            Console.WriteLine(racun1);
            BankovniRacun.GetSledeciBrojRacuna();
        }

        public class BankovniRacun
        {
            private static long sledeciBrojRacuna; // staticka promenljiva 
            private long stanje; // atribut stanja 

            public void Uplati(long suma)
            {
                stanje = stanje + suma;
            }

            // staticni metod vraca sledeci raspoloziv broj racuna 
            public static long GetSledeciBrojRacuna()
            {
                sledeciBrojRacuna++;
                return sledeciBrojRacuna;
            }

            // vise metoda i atributa
        }
    }
}
