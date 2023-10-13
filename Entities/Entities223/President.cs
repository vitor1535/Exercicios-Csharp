
class President
{
    public string Name { get; set; }
    public int Votes { get; set; }

    public President(string name, int votes)
    {
        Name = name;
        Votes = votes;
    }

    public void AddVotes(int votes)
    {
        Votes += votes;
    }
}
