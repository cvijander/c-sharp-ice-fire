using System.Reflection;

namespace Blizanci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Prikazi();
        }

        public static void Prikazi()
        {
            int num1 = 3;
            int num2 = 5;

            for (int i = 0; i < 1000; i+=2)
            {
                Console.Write(num1+" ");

                int num3 = num2 ;
                num2 = num1 ;
            }

        }
    }
}
