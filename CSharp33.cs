
//1)

string senha = "";

while (true)
{
    senha = Console.ReadLine();
    if (senha == "2002")
    {
        Console.WriteLine("Acesso permitido!");
        break;
    }
    else
    {
        Console.WriteLine("Tente novamente!");
    }
}
*/


//2
double x, y;
string[] aux;

while (true)
{
    aux = Console.ReadLine().Split();

    x = double.Parse(aux[0]);
    y = double.Parse(aux[1]);

    if (x > 0)
    {
        if (y > 0)
        {
            Console.WriteLine("primeiro");
        }
        else if (y < 0)
        {
            Console.WriteLine("quarto");
        }
        else if (y == 0)
        {
            break;
        }
    }

    if (x < 0)
    {
        if (y > 0)
        {
            Console.WriteLine("segundo");
        }
        else if (y < 0)
        {
            Console.WriteLine("terceiro");
        }
        else if (y == 0)
        {
            break;
        }
    }

    if (x == 0)
    {
        break;
    }
}
*/


//3
int alcool = 0, gasolina = 0, diesel = 0;
int codigo;

while (true)
{
    codigo = int.Parse(Console.ReadLine());

    if (codigo == 1)
    {
        alcool++;
    }
    else if (codigo == 2)
    {
        gasolina++;
    }
    else if (codigo == 3)
    {
        diesel++;
    }
    else if (codigo == 4)
    {
        break;
    }
    else
    {
        Console.WriteLine("Insira um codigo valido!");
    }
}

Console.WriteLine("MUITO OBRIGADO!");
Console.WriteLine("Alcool: " + alcool);
Console.WriteLine("Gasolina: " + gasolina);
Console.WriteLine("Diesel: " + diesel);
*/