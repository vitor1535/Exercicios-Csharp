
class IPaypal : Installment
{
    public DateTime DueDate { get; set; }
    public double Amount { get; set; }

    public IPaypal(DateTime dueDate, double amount)
    {
        DueDate = dueDate;
        Amount = amount;
    }

    public double[] Parcel(double value, int months)
    {
        double[] vetor = new double[months];
        value = value / (double)months;
        double valueAux = value;

        for (int i = 1; i <= months; i++)
        {
            value += value * (0.01 * i);
            value += value * 0.02;

            vetor[i-1] = value;
            value = valueAux;
        }

        return vetor;
    }
}
