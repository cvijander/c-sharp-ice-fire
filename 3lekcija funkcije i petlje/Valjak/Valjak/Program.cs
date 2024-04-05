// See https://aka.ms/new-console-template for more information
using System.Transactions;

Console.WriteLine("Hello, World!");

Console.WriteLine("Unesite poluprecnik valjka ");
int poluprecnikValjka =int.Parse(Console.ReadLine());
Console.WriteLine("Unesite visinu valjka ");
int visinaValjka =int.Parse(Console.ReadLine());
double povrsinaBaza = 2 * Math.Pow(poluprecnikValjka, 2) * Math.PI;
double povrsinaOmotaca = 2 * poluprecnikValjka * Math.PI * visinaValjka;
double povrsinaValjka = povrsinaBaza + povrsinaOmotaca;
Console.WriteLine("Povrsina valjka je :" + povrsinaValjka);