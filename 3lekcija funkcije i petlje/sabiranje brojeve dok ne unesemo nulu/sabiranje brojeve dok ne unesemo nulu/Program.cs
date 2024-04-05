// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Racunjanje sume svih brojeva dok se ne unese nula ");

int broj = int.Parse(Console.ReadLine());
int suma = 0;

while (broj != 0)
{
    suma += broj;
    broj = int.Parse(Console.ReadLine());
}
Console.WriteLine("Sunma je " +suma);