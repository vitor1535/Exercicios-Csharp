class UsedProduct : Product
{
    public DateTime ManufactureDate { get; set; }

    public UsedProduct()
    {
    }

    public UsedProduct(string name, double price, DateTime manufactureData)
    {
        Name = name;
        Price = price;
        ManufactureDate = manufactureData;
    }

    public override string PriceTag()
    {
        return Name + "(used)" + " $" + Price + " (Manufacute date: " + ManufactureDate + ")";
    }
}
