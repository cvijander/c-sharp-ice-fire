using System.Transactions;

namespace Obim_trougla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Obim trougla ");
            double k1 = 3, k2 = 4;
            Trougao nt = new Trougao();
            double O = nt.Obim(k1,k2);
        }


    }

    public  class Trougao
    {
        public int a { get; set; }
        private int b { get; set; }
        public int c { get; set; }

        public  Trougao()
        {

        }

        Trougao (int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public  double Obim (double a, double b)
        {
            double c = Math.Sqrt(a*a + b*b);
            return a + b + c;
        }
    }
}
