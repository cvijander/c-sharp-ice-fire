using System.ComponentModel.DataAnnotations;

namespace NepravilnoPozivanjeStatickeMetode
{
    internal class Program
    {
        int Max(int m, int n)
        {
            return (m >n) ? m : n;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Nepravilno pozivanje promenljive iz statickom metoda ");
            int n = 100;
            int m = 200;

            //Console.WriteLine("Max of m ,n is: " +Max(m,n));
            // main je staticki metod, ne moze da poziva metod objekta max 
        }
    }
}
