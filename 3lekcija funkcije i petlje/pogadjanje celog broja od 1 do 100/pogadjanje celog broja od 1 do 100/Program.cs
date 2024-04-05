// See https://aka.ms/new-console-template for more information

Random ra= new Random();
int zamisljeniBroj;
int pokusanBroj;
bool pogodak;
int brojPokusaja = 1;
int donjaGranica=0;
int gornjaGranica=0;

List<int> listaBrojeva = new List<int>();

Console.WriteLine("Program funkcionise tako sto korisnik prvo unosi donju i gornju granicu raspona zamisljenog tajnog broja");
Console.WriteLine("Nakon sto korisnik unese vrednost nekog broja dobija poruku (1 pogodili ste)");
Console.WriteLine("2 zamisljeni broj je veci - i tada je neophodno da sledeci broj koji unosi mora biti veci od unetog ,dok ako se unese manji dobija se poruka ");
Console.WriteLine("3 zamisljeni broj je manji - i tada je neophdono da sledeci broj koji unosi mora biti maji od unetgo, dok ako se unese veci dobija se poruka ");

Console.Write("Unesite donju granicu raspona za pogadjanje: ");
donjaGranica = int.Parse(Console.ReadLine());
Console.Write("Unesite godnju granicu raspona za pogadnaje: ");
gornjaGranica =int.Parse(Console.ReadLine());


zamisljeniBroj = (int)(ra.Next(donjaGranica, (gornjaGranica+1)));
pogodak = false;

while(pogodak ==false)
{
    Console.WriteLine("Pogodite broj izmedju "+ donjaGranica + " do " + gornjaGranica);
    pokusanBroj = int.Parse(Console.ReadLine());
    if (pokusanBroj >= donjaGranica && pokusanBroj <= gornjaGranica && !listaBrojeva.Contains(pokusanBroj))
    {
        
        if (pokusanBroj < zamisljeniBroj)
        {
            Console.WriteLine("Zamisljeni broj je veci");
            brojPokusaja++;
            DodajBrojuListuAkojeManji(pokusanBroj);
        }
        else if (pokusanBroj > zamisljeniBroj)
        {
            Console.WriteLine("Zamisljeni broj je manji");
            DodajBrojUListuAkojeVeci(pokusanBroj);
            brojPokusaja++;
        }
        else
        {
            Console.WriteLine("Pogodili ste broj");
            pogodak = true;
            listaBrojeva.Add(pokusanBroj);
        }
    }
    else
    {
        Console.WriteLine("Pokusan broj nije u skladu sa donjim granicom koja je " +donjaGranica + " ili sa gornjom " +gornjaGranica +" ili vec ta lista sadrzi broj  " );
    }
    
}

Console.WriteLine("Trebalo Vam je samo " + brojPokusaja + " pokusaja.");

Console.WriteLine("Dosadasnji brojevi uneti u listu su ");

foreach (int broj in listaBrojeva)
{
    Console.Write(broj+" ");
}

void DodajBrojuListuAkojeManji(int n)
{   

    for(int i = donjaGranica;i <= n; i++)
    {
        if(!listaBrojeva.Contains(i))
        {
            listaBrojeva.Add(i);
        }
       
    }
}

void DodajBrojUListuAkojeVeci(int n)
{
    for (int i = gornjaGranica; i >= n; i--)
    {
        if(!listaBrojeva.Contains(i))
        {
            listaBrojeva.Add(i);
        }
        
    }
}

