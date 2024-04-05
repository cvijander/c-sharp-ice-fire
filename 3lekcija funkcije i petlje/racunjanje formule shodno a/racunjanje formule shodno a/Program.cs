// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Unesite a ");
int a = int.Parse(Console.ReadLine());
double broj =0;

if(a<10)
{
    broj = a * Math.Sqrt(10 + Math.E) + Math.Sin(Math.PI * 4);
}
else if (a <50 && a>= 10)
{
    broj = Math.Max(Math.PI * 10, Math.E * 12) + Math.Pow(2, a);
}
else if (a >=50)
{
    broj = a * Math.Abs(Math.Log(Math.E + 4) - Math.PI);
}
Console.WriteLine("Rezulatat je " +broj);


char ch = '9';
//Char.IsDigit('ch');
