namespace ObtanjeStringa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Obrnuti string");
            Console.WriteLine("Obrnuti broj od 15 je " + ObrniBroj(15));
            Console.WriteLine("Obrnuti broj od 2345 je " + ObrniBroj(2345));
            Console.WriteLine("Obrnuti broj od 6598 je " + ObrniBroj(6598));

        }

        static int ObrniBroj(int broj)
        {
            string tekstualnibroj = broj.ToString();
            char[] nizBroja = tekstualnibroj.ToCharArray();
            Array.Reverse(nizBroja);
            return int.Parse( nizBroja);
        }
    }
}
