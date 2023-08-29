using System.Net.Http.Headers;
using System.Xml.Schema;

Console.WriteLine("Ange en produkt");
string produkt = Console.ReadLine();
Console.WriteLine("Ange pris på produkten");
double pris = double.Parse(Console.ReadLine());
Console.WriteLine("Ange antal att köpa");
int antal = int.Parse(Console.ReadLine());
double total = antal * pris;

Console.WriteLine($"{antal} {produkt} kostar {total}");


