using csharp;


//1
Console.WriteLine("Enter cliente data: ");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());

Client client = new Client(name, email, birthDate);

Console.WriteLine();
Console.WriteLine("Enter order data: ");
DateTime moment = DateTime.Now;
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

Order order = new Order (moment, status, client);

Console.Write("How many items to this order? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Enter #{0} item data:",i + 1);
    Console.Write("Product name: ");
    string nameProduct = Console.ReadLine();
    Console.Write("Product price: ");
    double price = double.Parse(Console.ReadLine());
    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    Product product = new Product (nameProduct,price);

    OrderItem orderItem = new OrderItem(quantity, price, product);

    order.AddItem(orderItem);
}

Console.WriteLine(order);
