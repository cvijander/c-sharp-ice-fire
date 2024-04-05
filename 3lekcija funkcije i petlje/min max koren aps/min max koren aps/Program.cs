// See https://aka.ms/new-console-template for more information
Console.WriteLine("Unesemo string abs, max, min, sqrt ");

double rezultat = 0;
double prvaVrednost = 0;
double drugaVrednost = 0;

Console.WriteLine("Unesite operaciju \r\n " + "Za apsolutnu vrednost: 1 \r\n"
    + "Za maximum dva broja: \t 2 \r\n" 
    + "Za minimum dva broja: \t 3 \r\n"
    + "Za koren vrednosti: \t 4 \r\n");

int operacija =int.Parse    (Console.ReadLine());

switch (operacija)
{
    case 1:
        Console.WriteLine("Unesite vrednost");
        prvaVrednost =double.Parse (Console.ReadLine());
        rezultat = Math.Abs (prvaVrednost);
        break;

    case 2:
        Console.WriteLine("Unesite prvu vrednost ");
        prvaVrednost = double.Parse (Console.ReadLine());
        Console.WriteLine("Unesite drugu vrednost");
        drugaVrednost = double.Parse(Console.ReadLine());
        rezultat = Math.Max(prvaVrednost, drugaVrednost);
        break;

    case 3:
        Console.WriteLine("Unesite prvu vrednost");
        prvaVrednost =double.Parse (Console.ReadLine());
        Console.WriteLine("Unesite drugu vrednost");
        drugaVrednost =double.Parse(Console.ReadLine());
        rezultat = Math.Min(prvaVrednost, drugaVrednost);
        break;

    case 4:
        Console.WriteLine("Unesite vrednost");
        prvaVrednost = double.Parse(Console.ReadLine());
        rezultat = Math.Sqrt(prvaVrednost);
        break;


}

Console.WriteLine("Resenje je " + rezultat);

