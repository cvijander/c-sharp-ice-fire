namespace Sfera_metoda__Setpoluprecnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Sfera poluprecnik ");
            Sfera sf = new Sfera();
            sf.Setpoluprecnik(10);
        }
    }

    public class Sfera
    {
        private double poluprecnik;

        public void Setpoluprecnik (double r)
        {
            if(r <0 )
            {
                return;
            }
            else
            {
                poluprecnik = r;
            }
        }
    }
}
