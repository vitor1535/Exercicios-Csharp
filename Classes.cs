namespace csharp
{
    class Cadastro
    {
        public string Nome = "";
        public int Idade;
    }

    class Funcionario42
    {
        public string Nome = "";
        public int Salario;
    }

    class Retangulo45
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return ((Largura * 2) + (Altura * 2));
        }

        public double Diagonal()
        {
            return (Math.Sqrt(Largura * Largura + Altura * Altura));
        }
    }

    class Funcionario45
    {
        public string Nome = "";
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double qtd)
        {
            double porcentagem = qtd * 0.01;
            SalarioBruto += SalarioBruto * porcentagem;
        }

        public override string ToString()
        {
            return Nome + ", $" + SalarioLiquido();
        }
    }

    class Aluno45
    {
        public string Nome = "";
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public string Situacao = "REPROVADO";

        public double NotaFinal()
        {
            return (Nota1 + Nota2 + Nota3);
        }

        public void CalcularSituacao()
        {
            if (NotaFinal() >= 60)
            {
                Situacao = "APROVADO";
            }
            else
            {
                Situacao = "REPROVADO";
            }
        }

        public double PontosFaltantes()
        {
            return 60 - NotaFinal();
        }
    }

    class ConversorDeMoeda
    {
        public static double Converter (double x, double y)
        {
            double total = x * y;
            return total + total * 0.06;
        }
    }

    class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set;}

        public ContaBancaria (int numeroConta, string titular) 
        {
            NumeroConta = numeroConta;
            Titular = titular;

        }

        public ContaBancaria (int numeroConta, string titular, double saldo) 
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {   
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor + 5;
        }

        public override string ToString()
        {
            return NumeroConta + ", Titular: " + Titular + ", Saldo: $" + Saldo;
        }
    }

    class AluguelQuartos
    {
        public string Nome {set; get;}
        public string Email {set; get;}
        public int Quarto {set; get;}

        public AluguelQuartos (string nome, string email, int quarto)
        {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }

        public override string ToString()
        {
            return Quarto + ": " + Nome + ", " + Email;
        }
    }

    class Funcionarios78
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public double Salario {get; private set;}

        public Funcionarios78 (int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void Aumento(double x)
        {
            Salario += Salario * (x / 100);
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario;
        }

    }
}