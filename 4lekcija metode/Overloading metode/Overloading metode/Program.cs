namespace Overloading_metode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int Max(int m, int n)
        {
            return (m > n) ? m : n;
        }

        public float Max(float m, float n)
        {
            return (n > m) ? n : m;
        }

        public float Max (float m ,float n, float o)
        {
            return Max(Max(m, n), o);
        }

        public int RacunajSumu(int a)
        {
            return a;
        }
        /*
        public float RacunajSumu(int b)
        {
            return b;
        }
        */


    }
}
