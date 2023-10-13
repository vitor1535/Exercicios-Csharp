using csharp;
using System.Collections.Generic;


List<Product> list = new List<Product>();

Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Product #{i+1} data:");

    Console.Write("Common, used or imported (c/u/i)?");
    char answer = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine());

    if (answer == 'c')
    {
        Product p = new Product(name, price);
        list.Add(p);
    }
    else if (answer == 'u')
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

        Product p = new UsedProduct (name, price, manufactureDate);
        list.Add(p);
    }
    else if (answer == 'i')
    {
        Console.Write("Customs fee: ");
        double customsFee = double.Parse(Console.ReadLine());

        Product p = new ImportedProduct(name, price, customsFee);
        list.Add(p);
    }
}

foreach(Product p in list)
{
    Console.WriteLine(p.PriceTag());
}
