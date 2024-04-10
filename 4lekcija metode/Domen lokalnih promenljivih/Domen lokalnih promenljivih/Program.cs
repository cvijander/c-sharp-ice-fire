namespace Domen_lokalnih_promenljivih
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Racun
    {
        private int stanje;

        public void Uplati(int suma)
        {
            stanje = stanje + suma;
        }

        public void Isplati(int suma)
        {
            int skini = 15;
            stanje = stanje - suma - skini;
        }
    }
}
