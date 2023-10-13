
interface Installment
{
    public DateTime DueDate { get; set; }
    public double Amount { get; set; }

    public double[] Parcel(double value, int months);
}
