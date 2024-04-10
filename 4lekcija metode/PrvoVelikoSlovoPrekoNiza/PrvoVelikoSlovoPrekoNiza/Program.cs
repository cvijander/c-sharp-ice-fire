namespace PrvoVelikoSlovoPrekoNiza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prvo veliko slovo preko chara");
            Console.WriteLine("Unesite rec");
            string unos =Console.ReadLine();
            Console.WriteLine(DajMiVelikoSlovo(unos));
        }

        public static string DajMiVelikoSlovo(string tekst)
        {
            char[] nizOdKaraktera = tekst.ToCharArray();
            for (int i = 0; i < tekst.Length; i++)
            {
                if(i==0)
                {
                    nizOdKaraktera[i] = Char.ToUpper(nizOdKaraktera[i]);
                }
                else
                {
                    nizOdKaraktera[i] = Char.ToLower(nizOdKaraktera[i]); 

                }
            }
            return new string(nizOdKaraktera);
        }
    }
}
