using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Order
{
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }
    public Client Client { get; set; }
    public List<OrderItem> Items { get; set;} = new List<OrderItem>();

    public Order()
    {
    }

    public Order (DateTime moment, OrderStatus status, Client client)
    {
        Moment = moment;
        Status = status;
        Client = client;
    }

    public void AddItem(OrderItem item)
    {
        Items.Add(item);
    }

    public void RemoveItem (OrderItem item)
    {
        Items.Remove(item);
    }

    public double Total()
    {
        double retorno = 0;
        foreach (OrderItem item in Items)
        {
        retorno += item.SubTotal();
        }
        return retorno;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("ORDER SUMMARY:");
        sb.Append("Order moment: ");
        sb.AppendLine(Moment.ToString());
        sb.Append("Order status: ");
        sb.AppendLine(Status.ToString());
        sb.Append("Client: ");
        sb.Append(Client.Name);
        sb.Append(" ");
        sb.Append(Client.BirthDate);
        sb.Append(" - ");
        sb.Append(Client.Email);
        sb.AppendLine();

        sb.AppendLine("ORDER ITEMS:");
        foreach (OrderItem item in Items)
        {
            sb.Append(item.Product.Name);
            sb.Append(", $");
            sb.Append(item.Price);
            sb.Append(", Quantity: ");
            sb.Append(item.Quantity);
            sb.Append(", Subtotal: $");
            sb.Append(item.SubTotal());
            sb.AppendLine();
        }
        sb.Append ("Total price: $");
        sb.AppendLine(Total().ToString());

        return sb.ToString();
    }
}
