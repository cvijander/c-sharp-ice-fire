// See https://aka.ms/new-console-template for more information
Console.WriteLine("10 karaktera ");

Random slucajno = new Random();

for (int i = 0; i < 10; i++)
{
    int cha = slucajno.Next(65,91);
    char slovo = (char)cha;
    Console.WriteLine("slovo je " +slovo + " ima sledeci karakter " +cha);
    
}
