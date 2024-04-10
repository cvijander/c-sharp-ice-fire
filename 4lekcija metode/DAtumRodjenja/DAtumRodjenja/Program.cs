namespace DAtumRodjenja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("JMBG");
                Console.WriteLine("Unesite JMBG ");
                string jmbgUlaz = Console.ReadLine();
                ProveraIspravnostiJmbg(jmbgUlaz);
                Console.WriteLine("Pol je " +GetPolNaOsnovuJMBG(jmbgUlaz));
                Console.WriteLine(GetDatumRodjenja(jmbgUlaz));
            }
            catch (Exception ex)
            {

                Console.WriteLine("Greska " + ex.Message);
            }

        }

        public static string GetPolNaOsnovuJMBG(string jmbg)
        {
            string pol = "";
            string jm= ProveraIspravnostiJmbg(jmbg);
            
                int bbb = int.Parse(jm.Substring(9, 3));

                if(bbb <= 500)
                {
                    pol = "Musko";
                }
                else
                {
                    pol = "Zensko";
                }
                           
            return pol;

        }

        public static string GetDatumRodjenja(string jmbg)
        {
            string jm = ProveraIspravnostiJmbg(jmbg);
            int dan = int.Parse(jm.Substring(0, 2));
            int mesec = int.Parse(jm.Substring(2, 2));
            int godina = int.Parse(jm.Substring(4, 3));
            if(godina >700)
            {
                godina = 1000 + godina;
            }
            else
            {
                godina = 2000 + godina;
            }
            return "Datum rodjenja je " + dan + ". " + mesec + ". "  + godina+".";
        }

        public static string ProveraIspravnostiJmbg(string jmbg)
        {
            // jbmg da je tacno 13 , prvi karakter da je manji od 3(realno mogu da stavim i da je veci od 0 ) pa smo mogli da je prva dva manja od 32 npr itd 
            if ((jmbg.Length == 13) && (int.Parse(jmbg.Substring(0, 1)) < 3) && (int.Parse(jmbg.Substring(2, 2)) < 13) && (int.Parse(jmbg.Substring(2, 2)) > 0))
            {
                return jmbg;
            }
            else
            {
                return "Greska";
            }
        }
    }

}
