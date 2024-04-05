// See https://aka.ms/new-console-template for more information
Console.WriteLine("Broj je prost");

int n;
Console.WriteLine("Unesite ceo broj veci od 1: ");
n = int.Parse(Console.ReadLine());

int maksimalniDelilac = (int)Math.Sqrt(n);

for (int i = 2; i <= maksimalniDelilac; i++)
{
    if(n % i ==0)
    {
        Console.WriteLine("Broj nije prost");
    }
    
    
}
Console.WriteLine("Broj je prost");
