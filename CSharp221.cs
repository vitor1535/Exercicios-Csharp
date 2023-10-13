using csharp;


int n;

HashSet<int> hash = new HashSet<int>();

Console.Write("How many students for course A?");
n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
hash.Add(int.Parse(Console.ReadLine()));
}

Console.Write("How many students for course B?");
n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
hash.Add(int.Parse(Console.ReadLine()));
}

Console.Write("How many students for course C?");
n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
hash.Add(int.Parse(Console.ReadLine()));
}

Console.WriteLine("Total students: " + hash.Count);
foreach(int x in hash)
{
    Console.WriteLine(x);
}
