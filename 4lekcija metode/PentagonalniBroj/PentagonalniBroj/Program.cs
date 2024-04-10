namespace PentagonalniBroj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pentagonalni broj");

            for (int i = 0;i<100;i++)
            {
                Console.WriteLine("Za broj " +i + " dobijamo sledeci :" +PentagonalniBroj(i));
            }
        }

        public static int PentagonalniBroj(int i )
        {
            int resenje = (i * ((3 * i) - 1)) / 2;
            return resenje;
        }


    }
}
