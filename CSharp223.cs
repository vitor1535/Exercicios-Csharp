using csharp;

Dictionary<string, int> dict = new Dictionary<string, int>();
int i = 0;

Console.WriteLine("Enter file full path: ");
string path = Console.ReadLine();

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while(!sr.EndOfStream)
        {
            string[] aux = sr.ReadLine().Split(',');
            string name = aux[0];
            int votes = int.Parse(aux[1]);
            
            if (!(dict.ContainsKey(name)))
            {
                dict[name] = votes;
            }
            else
            {   
                dict[name] += votes;
            }
        }
    }
}
catch (Exception E)
{
    Console.WriteLine("ERROR!" + E.Message);
}

foreach(var item in dict)
{
    Console.WriteLine(item.Key + ": " + item.Value);
}
