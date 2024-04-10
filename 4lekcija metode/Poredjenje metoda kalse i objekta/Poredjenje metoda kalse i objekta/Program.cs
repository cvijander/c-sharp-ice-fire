namespace Poredjenje_metoda_kalse_i_objekta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Poredjenje metode kalse i objekta ");
            Console.WriteLine("Koje je vase ime: ");
           // string ime = GetReady(); // greska fali refenrecna na objekat
        }

        public string GetReady()
        {
            return Console.ReadLine();
        }
    }
}
