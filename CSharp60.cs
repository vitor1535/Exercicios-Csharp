using csharp;


//1
ContaBancaria cb1;
int numeroConta;
string titular;
string resposta;
double valor;

Console.WriteLine("Entre com o numero da conta: ");
numeroConta = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o titular da conta: ");
titular = Console.ReadLine();

Console.WriteLine("Havera deposito inicial?");
resposta = Console.ReadLine();
            
if (resposta == "s")
{
    Console.WriteLine("Insira o valor: ");
    valor = double.Parse(Console.ReadLine());
    cb1 = new ContaBancaria(numeroConta, titular, valor);
}
else
{
    cb1 = new ContaBancaria(numeroConta, titular);
}

Console.WriteLine("Dados da conta: ");
Console.WriteLine(cb1);

Console.WriteLine("Insira um valor para depósito: ");
valor = double.Parse(Console.ReadLine());
cb1.Depositar(valor);

Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(cb1);

Console.WriteLine("Insira um valor para saque: ");
valor = double.Parse(Console.ReadLine());
cb1.Sacar(valor);

Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(cb1);
