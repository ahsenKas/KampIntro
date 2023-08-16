// See https://aka.ms/new-console-template for more information


Products products1 = new Products();
products1.urunAdi = "Baza";
products1.Fiyati = 549.99;
products1.İndirimMiktarı = 45;

Products products2 = new Products();
products2.urunAdi = "Dolap";
products2.Fiyati = 220;
products2.İndirimMiktarı = 20;

Products products3 = new Products();
products3.urunAdi = "Masa";
products3.Fiyati = 250;
products3.İndirimMiktarı = 15;

Products[] products = new Products[] {products1, products2, products3 };

for (int i = 0; i < products.Length; i++)
{
    Console.WriteLine(products[i].urunAdi+ " " + products[i].Fiyati+ " %" + products[i].İndirimMiktarı);

}

Console.WriteLine("For döngüsü bitişi");
Console.WriteLine();

foreach (var product in products)
{
    Console.WriteLine(product.urunAdi + " " + product.Fiyati + " %" + product.İndirimMiktarı);
}

Console.WriteLine("Foreach döngüsü bitişi");
Console.WriteLine();

int a = 0;
while (a<products.Length)
{
    Console.WriteLine(products[a].urunAdi + " " + products[a].Fiyati + " %" + products[a].İndirimMiktarı);
    a++;
}

Console.WriteLine("While döngüsü bitişi");
Console.WriteLine();
class Products
{
    public string urunAdi { get; set; }
    public double  Fiyati { get; set; }
    public int İndirimMiktarı { get; set; }

}
