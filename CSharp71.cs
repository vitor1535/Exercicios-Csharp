using csharp;


//1
int n;
string nome;
string email;
int quarto;

Console.WriteLine("Quantos quartos serão alugados?");
n = int.Parse(Console.ReadLine());

AluguelQuartos[] alugadores = new AluguelQuartos[10];

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Rent #{0}",i + 1);

    Console.WriteLine("Name: ");
    nome = Console.ReadLine();

    Console.WriteLine("Email: ");
    email = Console.ReadLine();

    Console.WriteLine("Room: ");
    quarto = int.Parse(Console.ReadLine());

    alugadores[quarto] = new AluguelQuartos(nome, email, quarto);
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(alugadores[i]);
}
