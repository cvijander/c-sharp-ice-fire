namespace _6.domaciTrougao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool izlazIzPetlja = true;
            try
            {
                while (izlazIzPetlja)
                {
                    izlazIzPetlja = GlavniMeni();

                }
            }
            catch (Exception ex )
            {
                Console.WriteLine("Greska " +ex.Message);
            }
        }

        public static bool GlavniMeni()
        {
            Console.Clear();
            Console.WriteLine("Odaberite tip trougla ");
            Console.WriteLine("1) Jednakostranicni - samo ima jednu stranici: ");
            Console.WriteLine("2) Jednakokraki - ima dve stranice razlicite ");
            Console.WriteLine("3) Raznokraki dakle 3 razlicitre stranice ");
            Console.WriteLine("4) Exit");

            string ulaz = Console.ReadLine();

            if(ulaz == "1")
            {
                Jednakostranicni();
                return true;
            }
            else if(ulaz =="2")
            {
                Jednakokraki();
                return true;
            }
            else if (ulaz =="3")
            {
                Raznostrancni();
                return true;
            }
            else if (ulaz =="4")
            {
                return false;
            }
            else
            {
                return true;
            }                   
  
        }


        public static int UnosStranice()
        {
            Console.Clear();
            Console.Write("Unesite stranicu a: ");
            int a = int.Parse(Console.ReadLine());
            return a;
        }
       

        public static void TrougaoUnos(int a)
        {
            //a = UnosStranice();
            Trougao t = new Trougao(a);
            t.Povrsina(a);
            Console.WriteLine("Povrsina jednakostranicnog je " + t.Povrsina(a));
            
        }
        public static void TrougaoUnos(int a,int b)
        {            
           // a = UnosStranice();
          //  b= UnosStranice();
            Trougao t = new Trougao(a, b);
            t.Povrsina(a,b);
            Console.WriteLine("Povrsina jednakokrakog je " + t.Povrsina(a,b));
        }
        public static void TrougaoUnos(int a, int b, int c)
        {
            Console.Clear();
           // a = UnosStranice();
           // b = UnosStranice();
          //  c =UnosStranice();
            Trougao t = new Trougao(a, b,c);
            t.Povrsina(a,b,c);
            Console.WriteLine("Povrsina ovo je testy dakle a * b* c je " + t.Povrsina(a, b,c));
        }

        public static void Jednakostranicni()
        {
            Console.Clear();
            Console.WriteLine("Odabrali ste jednakostranicni trougao ");
            Console.WriteLine("Dakle unosite samo jednu stranicu");            
            TrougaoUnos(UnosStranice());
            Console.ReadLine();
            
        }
        public static void Jednakokraki()
        {
            Console.Clear();
            Console.WriteLine("Odabrali ste jednakokraki trougao ");
            Console.WriteLine("Dakle unosite 2  stranice");
            TrougaoUnos(UnosStranice(), UnosStranice());
            Console.ReadLine();
        }
        public static void Raznostrancni()
        {
            Console.Clear();
            Console.WriteLine("Odabrali ste raznostrancni trougao ");
            Console.WriteLine("Dakle unosite 3  stranice");
            TrougaoUnos(UnosStranice(), UnosStranice(), UnosStranice());
            Console.ReadLine();
        }

    }


}
