// See https://aka.ms/new-console-template for more information
Console.WriteLine("Napisati program koji odredjuj sve cele brojeve m in izmedju 1  i 100 koji zadovoljavaju uslov" );

int broj;
Console.WriteLine("Brojevi koji zadovoljavaju uslov ");

for (int i = 1;i <=100;i++)
{
    for (int j = 1;j <=100;j++)
    {
        broj = Math.Abs((int)Math.Pow(j,2) - j * i - (int)Math.Pow(i,2));
            {
            if(broj ==1)
            {
                Console.WriteLine("J= " +j + " I= " + i);
            }
        }
    }
}
