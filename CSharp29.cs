
// 3)
int a, b;
string[] aux;
bool resultado = false;

aux = Console.ReadLine().Split();

a = int.Parse(aux[0]);
b = int.Parse(aux[1]);

if (a > b)
{
    if (a % b == 0)
    {
        resultado = true;
    }
    else
    {
        resultado = false;
    }
}
else if (b > a)
{
    if (b % a == 0)
    {
        resultado = true;
    }
    else
    {
        resultado = false;
    }
}

if (resultado == true)
{
    Console.WriteLine("Sao multiplos!");
}
else
{
    Console.WriteLine("Nao sao multiplos!");
}
*/


//4
int horaAtual, horaFinal;
int resultado = 0;
string[] aux;

aux = Console.ReadLine().Split();

horaAtual = int.Parse(aux[0]);
horaFinal = int.Parse(aux[1]);

if (horaAtual > horaFinal)
{
    resultado = (24 % horaAtual) + horaFinal;
}
else if (horaFinal > horaAtual)
{
    resultado = horaFinal - horaAtual;
}
else if (horaAtual == horaFinal)
{
    resultado = 24;
}

Console.WriteLine("O JOGO DUROU {0} HORA(S)",resultado);
*/


//5)

double codigo, qtd;
double total = 0;
string[] aux;

aux = Console.ReadLine().Split();

codigo = double.Parse(aux[0]);
qtd = double.Parse(aux[1]);

if (codigo == 1)
{
    total = 4 * qtd;
}
else if (codigo == 2)
{
    total = 4.50 * qtd;
}
else if (codigo == 3)
{
    total = 5 * qtd;
}
else if (codigo == 4)
{
    total = 2 * qtd;
}
else if (codigo == 5)
{
    total = 1.50 * qtd;
}

Console.WriteLine("Total a pagar: {0}",total);
*/


double num;

num = double.Parse(Console.ReadLine());

if (num >= 0 && num <= 25)
{
    Console.WriteLine("[0,25]");
}
else if (num > 25 && num <= 50)
{
    Console.WriteLine("(25,50]");
}
else if (num > 50 && num <= 75)
{
    Console.WriteLine("(50,75]");
}
else if (num > 75 && num <= 100)
{
    Console.WriteLine("(75,100]");
}
else
{
    Console.WriteLine("Fora de intervalo!");
}
*/


double x, y;
string[] aux;

aux = Console.ReadLine().Split();

x = double.Parse(aux[0]);
y = double.Parse(aux[1]);

if (x > 0)
{
    if (y > 0)
    {
        Console.WriteLine("Q1");
    }
    else if (y < 0)
    {
        Console.WriteLine("Q4");
    }
    else if (y == 0)
    {
        Console.WriteLine("Eixo X");
    }
}

if (x < 0)
{
    if (y > 0)
    {
        Console.WriteLine("Q2");
    }
    else if (y < 0)
    {
        Console.WriteLine("Q3");
    }
    else if (y == 0)
    {
        Console.WriteLine("Eixo X");
    }
}

if (x == 0)
{
    if (y != 0)
    {
        Console.WriteLine("Eixo Y");
    }
    else if (y == 0)
    {
        Console.WriteLine("ORIGEM");
    }
}
*/


//8

double salario, salarioAux;
double taxa1 = 0, taxa2 = 0, taxa3 = 0;
double total;

salario = double.Parse(Console.ReadLine());
salarioAux = salario;

if (salario > 2000)
{
    if (salario > 4500)
    {
        taxa1 = (3000 - 2000) * 0.08;
        taxa2 = (4500 - 3000) * 0.18;
        taxa3 = (salario - 4500) * 0.28;
    }
    else if (salario > 3000 && salario <= 4500)
    {
        taxa1 = (3000 - 2000) * 0.08;
        taxa2 = (salario - 3000) * 0.18;
    }
    else if (salario > 3000 && salario <= 4500)
    {
        taxa1 = (salario - 2000) * 0.08;
    }
}

total = taxa1 + taxa2 + taxa3;

Console.WriteLine(total);
