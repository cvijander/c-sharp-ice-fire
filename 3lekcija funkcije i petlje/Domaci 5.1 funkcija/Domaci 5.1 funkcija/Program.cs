// See https://aka.ms/new-console-template for more information
Console.WriteLine("Napraviti program koji daje resenje " );

Console.Write("Unesite x (ceo broj) : ");
int x = int.Parse( Console.ReadLine() );

double x1 = x;

double y = (Math.Pow(x, 3) - 4) /  Math.Sqrt(Math.Floor(5*x1));

Console.WriteLine("Resenje " + y);
