namespace _6_domaci_Fibnocaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonaci");
            Console.WriteLine("Svaki elemnt je zbir prethodna dva ");
            Zbir();
        }

        
        public static void Zbir()
        {
            int num1 =0;
            int num2 = 1;
            int nElement=num1;

            Console.Write("Koliko zelite da unesete brojeva:  ");
            int broj = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < broj; i++) 
            {
                Console.Write(num1 +" ");

                // zamena vrednosti 
                int num3 = num2 + num1;
                nElement = num1;
                num1 = num2;
                num2 = num3;
                //Console.WriteLine(num3);
                
                
            }
            Console.Write("N element u tom nizu " + nElement);




        }




    }
}
