namespace OpTester_prenos_po_referenci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prenos po referenci ");

            string poruka = "Samo jedan objekat";
            ObjectPrinter op = new ObjectPrinter();
            Console.WriteLine("Prva vredsnot poruke " + poruka);

            op.Print(poruka);
            Console.WriteLine("Druga vrednost poruke " + poruka);
        }
    }

    class ObjectPrinter
    {
        public void Print(string st) 
        {
            Console.WriteLine("Vrednost parametra : " + st);
        }
    }
}
