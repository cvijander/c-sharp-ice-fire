// See https://aka.ms/new-console-template for more information
Console.WriteLine("foreach petlja");

int[] niz = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int suma = 0;

foreach (int n in niz)
{
    suma += n;
}

Console.WriteLine("Suma je " + suma);
