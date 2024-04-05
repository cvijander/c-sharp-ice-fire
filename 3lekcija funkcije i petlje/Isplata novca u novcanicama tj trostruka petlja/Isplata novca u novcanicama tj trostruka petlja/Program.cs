// See https://aka.ms/new-console-template for more information
Console.WriteLine("Trostruka petlja tj isplata u tri tipa novcanica ");

bool nadjen =false;
Console.WriteLine("Unesite kolicinu novca u dinarima ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Unesite broj novcanica: ");
int m =int.Parse(Console.ReadLine());

for (int i = 0; i <= m; i++)
{
	for (int j = 0; j <= m; j++)
	{
		for (int k = 0; k <= m; k++)
		{
			if((i*1 + j*3 + k*5 ==n) && (i+ j+ k ==m))
			{
				nadjen=true;
                Console.WriteLine(i + " novacnica od 1 dinar " + j +" novcanica od 3 dinara " + k +" novcanica od 5 dinara ");
            }
		}
	}
}

if(!nadjen)
{
    Console.WriteLine("Nema recenja");
}

