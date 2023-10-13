
class PessoaJuridica : Pessoa
{
    public int Funcionarios { get; set; }

    public PessoaJuridica()
    {
    }

    public PessoaJuridica(string nome, double rendaAnual, int funcionarios)
    {
        Nome = nome;
        RendaAnual = rendaAnual;
        Funcionarios = funcionarios;
    }

    public override double Imposto()
    {
        double imposto = 0;
        if (Funcionarios <= 10)
        {
            imposto = RendaAnual * 0.16;
        }
        else
        {
            imposto = RendaAnual * 0.14;
        }

        return imposto;
    }

}
