
class ImportedProduct : Product
{
    public double CustomsFee { get; set; }

    public ImportedProduct()
    {
    }

    public ImportedProduct(string name, double price, double customsFee)
    {
        Name = name;
        Price = price;
        CustomsFee = customsFee;
    }

    public override string PriceTag()
    {
        return Name + " $" + TotalPrice() + "(Customs fee : $" + CustomsFee + ")";
    }

    public double TotalPrice()
    {
        return Price + CustomsFee;
    }
}
