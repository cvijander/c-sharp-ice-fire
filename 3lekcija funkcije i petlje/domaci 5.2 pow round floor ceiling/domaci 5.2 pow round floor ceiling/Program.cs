// See https://aka.ms/new-console-template for more information
Console.WriteLine("Nparaviti progam koji od korinia trazi da unese tekst vrednost i da ...");

double prvaVrednost;
double drugaVrednost;
double rezultat=0;

Console.WriteLine("Unesite pow | round | floor | ceiling  da bi ste izracunali  ");
string odgovor =Console.ReadLine();

 odgovor= odgovor.ToLower();

 switch (odgovor)
{
    case "pow":
        Console.WriteLine("Korisnik unosi dve vrednosti.Prva vrednost oznacava broj koji se podize na neki stepen, a drugi broj predstavlja vrednosti stepena. ");
        Console.WriteLine("Koristi se metoda Math.Pow(broj , stepen)");
        Console.Write("Unesite broj: ");
        prvaVrednost = double.Parse(Console.ReadLine());
        Console.Write("Unesite stepen: ");
        drugaVrednost = double.Parse(Console.ReadLine());
        rezultat = Math.Pow(prvaVrednost, drugaVrednost);        
        break;

    case "round":
        Console.WriteLine("Korisnik unosi jedan broj koji se zaokruzuje koriscenjem Math.Round(x) metode");
        Console.Write("Unesite vrednost: ");
        prvaVrednost= double.Parse(Console.ReadLine());
        rezultat = Math.Round(prvaVrednost);        
        break;

    case "floor":
        Console.WriteLine("Korisnik unosi jedan broj koji se zaokruzuje koeriscenjem Math.Floor(x) metode ");
        Console.Write("Unesite vrednost: ");
        prvaVrednost =double.Parse(Console.ReadLine());
        rezultat = Math.Floor(prvaVrednost);       
        break;

    case "ceiling":
        Console.WriteLine("Korisnik unosi jedan broj koji se zaokruzuje koriscenjem Math.Ceiling(x) metode ");
        Console.Write("Unesite vrednost: ");
        prvaVrednost =double.Parse(Console.ReadLine());
        rezultat = Math.Ceiling(prvaVrednost);        
        break;

 }

Console.WriteLine("Rezultat je " + rezultat);
