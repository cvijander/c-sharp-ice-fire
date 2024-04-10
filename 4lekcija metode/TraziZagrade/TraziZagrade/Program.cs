namespace TraziZagrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trazi zagrade ");
            Proveri();
        }
        

        public static void Proveri()
        {
            Console.WriteLine("Unesi tekst");
            string teskt = Console.ReadLine();
            char[] niz = teskt.ToCharArray();
            int brojacLeve = 0;
            int brojacDesne = 0;

            for (int i = 0; i < niz.Length; i++)
            {
                if (niz[i]=='(')
                {
                    brojacLeve++;
                }
                else if (niz[i]==')') 
                {
                    brojacDesne++;
                }
            }
            if (brojacLeve> brojacDesne)
            {
                Console.WriteLine(brojacLeve+ " Ima vise levih" +brojacDesne);
            }
            else if(brojacLeve < brojacDesne)
            {
                Console.WriteLine( brojacLeve+ " Ima vise desnih " + brojacDesne);
            }
            else
            {
                Console.WriteLine("Isti je broj");
            } 
                
        }

    }
}
