// See https://aka.ms/new-console-template for more information
Console.WriteLine("funkcija");

Console.WriteLine("Unesite x ");
int x = int.Parse   (Console.ReadLine());

int y = (int)(Math.Pow(x, 2) - 2) /(int) Math.Sqrt(2*x);

Console.WriteLine(y);