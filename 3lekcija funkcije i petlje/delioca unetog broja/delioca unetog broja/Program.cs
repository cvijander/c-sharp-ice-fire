// See https://aka.ms/new-console-template for more information
Console.WriteLine("Delioc unetog broja ");

Console.Write("Unesi broj : ");
int broj = int.Parse(Console.ReadLine());

for (int i = 1; i <= broj/2; i++)
{
    if(broj % i ==0)
    {
        Console.WriteLine(i +" ");
    }
}
