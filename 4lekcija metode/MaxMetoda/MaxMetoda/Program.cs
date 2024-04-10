namespace MaxMetoda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Max metoda");

            double one = 5.0;
            double two = 7.5;
           double result = Max(one, two);
            Console.WriteLine(result);
        }

        // vraca maksimum od 2 double vrednosti

        public static double Max(double a, double b)
        {
            if(a>b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
