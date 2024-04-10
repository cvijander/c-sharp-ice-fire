namespace Dupliranje_tacke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dve tacke ");
            Tacka t = new Tacka();
            DupliranjeTacke dbl = new DupliranjeTacke();
            t.Print();
            dbl.Dvaputa(t);
            t.Print();
        }
    }

    public class Tacka
    {
        public int x = 3;
        public int y = 5;

        public void Print()
        {
            Console.WriteLine("x= " + x+ " ;y= " + y);
        }
    }

    public class DupliranjeTacke
    {
        // kreirana je referenca ka tacki t sa t = new Tacka()
        public void Dvaputa(Tacka t)
        {
            Console.WriteLine("Ulaz u dupliranjetacke");
            t.Print();
            t.x = t.x * 2;
            t.y = t.y * 2;
            t.Print();
            Console.WriteLine("Napusstanje metoda dvaPuta");
        }
    }
}
