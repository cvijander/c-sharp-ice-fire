// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// unos koordinata tri temena trougla

Console.WriteLine("Unesite x i y koordinate tri tacke ");
Console.WriteLine("Prva tacka: ");
Console.WriteLine("x: ");
double x1=double.Parse(Console.ReadLine());
Console.WriteLine("y: ");
double y1=double.Parse(Console.ReadLine());
Console.WriteLine("Druga tacka");
Console.WriteLine("x: ");
double x2=double.Parse(Console.ReadLine());
Console.WriteLine("y: ");
double y2=double.Parse(Console.ReadLine());
Console.WriteLine("Treca tacka");
Console.WriteLine("x: ");
double x3 = double.Parse(Console.ReadLine());
Console.WriteLine("y: ");
double y3=double.Parse(Console.ReadLine());

//proracun tri stranice trougla
double a = Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));
double b= Math.Sqrt((x1 -x3)  * (x1 - x3) + (y1-y3) * (y1 - y3));
double c = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

// proracun tri ugla trogla
double A = Math.Acos((a * a - b * b - c * c) / (-2 * b * c));
double B = Math.Acos((b * b - a * a - c * c) / (-2 * a * c));
double C= Math.Acos(( c * c - b* b -a*a) / (-2 * a * b));

//prikaz rezulatat
Console.WriteLine("Tri ugla su " +Math.Round(A*100) + " " + Math.Round(B*100) +" " + Math.Round(c *100));



