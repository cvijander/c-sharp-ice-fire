// See https://aka.ms/new-console-template for more information
Console.WriteLine("Formule");

Console.Write("Unesite x: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Uneli ste " + x + " za vrednost X");

Console.WriteLine("Prvo resavamo jednacinu X1 ");

double xdou = x;
double x1 = (Math.Pow(x, 3) - 4) / Math.Sqrt(Math.Floor(5*xdou));

Console.WriteLine("Resenje za x1 " + x1 );

Console.WriteLine("Resavamo jednacinu X2");
double x2 = (Math.Pow(x, 3) - 5 * Math.Pow(x, 3) - 6 * x + 2) / Math.Sqrt(2 * x); //ovde je mozda mat greska mozda je trebalo na drugi stepen posto vec ima na trecem

Console.WriteLine("Resenje za x2 " + x2);

double rezultat = x1 * x2 / Math.Sqrt(x);

Console.WriteLine("Rezulata je " +rezultat);
