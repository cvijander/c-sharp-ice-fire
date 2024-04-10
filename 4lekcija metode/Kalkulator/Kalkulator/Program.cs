using System.Data;

namespace Kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rad sa kalkulatorom");
            int a;
            int b;
            Console.Write("a=: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=: ");
            b =int.Parse(Console.ReadLine());

            Kalkulator1 kal = new Kalkulator1();

            //Console.WriteLine(a +" + " +b +" = " + kal.Saberi(a,b) );
            Console.WriteLine(a+ " - "  +b +" =" + Kalkulator1.Saberi(a,b));
            Console.WriteLine(Kalkulator1.Oduzmi());
            Console.WriteLine(Kalkulator1.Pomnozi())
        }

        public class Kalkulator1
        {
            public static int Saberi(int a, int b)
            {
                return a + b;
            }

           public  static int Oduzmi(int a, int b)
            {
                return a - b;
            }

           public static int Pomnozi(int a, int b)
            {
                return a * b;
            }

            static double Pomnozi(double m, double n)
            {
                return m * n;
            }

            static int Podeli(int a, int b)
            {
                return a / b;
            }

            static double Podeli(double m, double n)
            {
                return m / n;
            }

            static int SaberiInterval(int m, int n)
            {
                int zbir = 0;
                for (int i = m; i <= n; i++)
                {
                    zbir += i;
                }
                return zbir;
            }

            static int Min(int m, int n)
            {
                return (m < n) ? m : n;
            }

            static int Max(int m, int n)
            {
                return (m > n) ? m : n;
            }



        }
    }

    
}
