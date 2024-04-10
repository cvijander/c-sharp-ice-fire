namespace FarenhajtUCelzijus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konverotvanje celzijusa u farenhajte i obrnuto");
            for (int i = 20; i<=50;i++)
            {
                Console.WriteLine(i + " celzijusa je " + String.Format("{0:N}", CelzijusiUFarenhajte(i)) + " farenhajta ");
            }

            Console.WriteLine("*******************");

            for (int i =50; i<=80;i++)
            {
                Console.WriteLine(i+ " farenhajta je " + String.Format("{0:N}",FarenhajtiuCelzijus(i)) + " celzijusa");
            }
        }

        public static double CelzijusiUFarenhajte(double celzijusi)
        {
            return (9.0 / 5) * celzijusi + 32;
        }

        public static double FarenhajtiuCelzijus(double farenhajt)
        {
            return (5.0 / 9) * (farenhajt - 32);
        }
    }
}
