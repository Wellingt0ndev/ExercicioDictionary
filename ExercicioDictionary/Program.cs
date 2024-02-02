Console.Write("Enter file full path: ");
string path = Console.ReadLine();

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        Dictionary<string, int> candidates = new Dictionary<string, int>();
        while (!sr.EndOfStream)
        {
            string [] line = sr.ReadLine().Split(",");
            string name = line[0];
            int numberOfVotes = int.Parse(line[1]);
            
            if (candidates.ContainsKey(name))
            {
                candidates[name] += numberOfVotes;
            }
            else
            {
                candidates[name] = numberOfVotes;
            }            
        } 
        foreach(var candidate in candidates)
        {
            Console.WriteLine(candidate.Key + ": " + candidate.Value);
        }
    }
    
}catch(IOException e)
{
    Console.WriteLine(e.Message);
}

