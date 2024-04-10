namespace Prvi_i_poslednji_karakter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stringopvi");
            Console.WriteLine(Zamena());
            Console.WriteLine(Prvatri());
        }

        public static string  Zamena()
        {
            Console.WriteLine("Unesite string ");
            string tekst = Console.ReadLine();
            char[] nizSlova = tekst.ToCharArray();
            char pocetno = nizSlova[0];
            char zadnje = nizSlova[tekst.Length-1];

            //Console.WriteLine(pocetno +" " + zadnje);
            string nt = tekst.Substring(1 , tekst.Length - 2);
            return zadnje+ nt+ pocetno;
        }

        public static string Prvatri()
        {
            Console.WriteLine("Unesite string ");
            string tekst = Console.ReadLine();
            char[] nizSlova = tekst.ToCharArray();
            string npocetak = "";
           string  ntekst = tekst.Substring(0, 3);
            for (int i = 0;i <3;i++)
            {
                npocetak += ntekst;
            }
            return npocetak;
        }
    }
}
