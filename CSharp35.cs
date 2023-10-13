
//1
int num;

num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}

//2
int n;
int dentro = 0, fora = 0;
int x;

n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    x = int.Parse(Console.ReadLine());

    if (x >= 10 && x <=20)
    {
        dentro++;
    }
    else
    {
        fora++;
    }
}

Console.WriteLine("{0} in",dentro);
Console.WriteLine("{0} out",fora);

//3
int n;
double media1, media2, media3;
double total;
string[] aux;

n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    aux = Console.ReadLine().Split();

    media1 = double.Parse(aux[0]) * 2;
    media2 = double.Parse(aux[1]) * 3;
    media3 = double.Parse(aux[2]) * 5;

    total = (media1 + media2 + media3) / 10;

    Console.WriteLine("{0:f1}",total);
}

//4
int n;
double num1, num2;
string[] aux;

n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    aux = Console.ReadLine().Split();

    num1 = double.Parse(aux[0]);
    num2 = double.Parse(aux[1]);

    if (num2 == 0)
    {
        Console.WriteLine("Divisao impossivel");
    }
    else
    {
        Console.WriteLine(num1 / num2);
    }
}

//5
int num;
int resultado = 1;

num = int.Parse(Console.ReadLine());

for (int i = 1; i < num + 1; i++)
{
    resultado *= i;
}

Console.WriteLine(resultado);

//6
int num;

num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    if (num % i == 0)
    {
        Console.WriteLine(i);
    }
}

//7
int num;
int i = 1;

num = int.Parse(Console.ReadLine());

while (i <= num)
{
    Console.WriteLine("{0} {1} {2}",i , i * i, i * i * i);
    i++;
}