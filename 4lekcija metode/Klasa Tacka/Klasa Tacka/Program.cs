namespace Klasa_Tacka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Klasa tacka ");

            Tacka tackaA = new Tacka();   // pozivamo prvi konstruktor
            Tacka tackaB =new Tacka(10,11);  // pozivamo drugi konstruktor B(10,11)
 
            tackaA.Pomeri(94, 172);   //  A(94,172)
            tackaB.Pomeri(24 - 12, 34 * 3 - 45); // B je sada 12, 57

            int col = 87, row = 55;

            tackaA.Pomeri(col, row);  // unosimo vrednosti ali posto je refenti tip onda se menja  i samo a
            tackaB.Pomeri(col - 4, row * 3 + 34);     // B je sada 83 , 165+34  199
        }
    }

    public class Tacka
    {
        public int x;
        public int y;

        // prazan default konstruktor
        public Tacka()  
        {

        }

        // konstruktor sa dva parametra 
        public Tacka(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // metoda 
        public void Pomeri(int x, int y)
        {
            this.x = x;
            this.y= y;
        }


    }
}
