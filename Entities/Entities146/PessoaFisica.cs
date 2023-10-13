
class PessoaFisica : Pessoa
{
    public double GastoSaude { get; set; }

    public PessoaFisica()
    {
    }

    public PessoaFisica(string nome, double rendaAnual, double gastoSaude)
    {
        Nome = nome;
        RendaAnual = rendaAnual;
        GastoSaude = gastoSaude;
    }

    public override double Imposto()
    {
        double imposto = 0;
        if (RendaAnual < 20000)
        {
            imposto = RendaAnual * 0.15;
            imposto -= GastoSaude * 0.5;
        }
        else
        {
            imposto = RendaAnual * 0.25;
            imposto -= GastoSaude * 0.5;
        }

        return imposto;
    }

}
