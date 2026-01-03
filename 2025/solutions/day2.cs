namespace _2025
{
    [Solution(Day = "2.1", Description = "Gift Shop")]
    class DayxPart1 : ISolution
    {
        public void Run(List<string> input)
        {
            Console.WriteLine($"{input.Count} Input Lines Parsed,");
            string[] ranges = input[0].Split(',');
            Int64 totalOfInvalidIDs = 0;
			
            for (int i = 0; i < ranges.Length; i++)
            {
                string[] range = ranges[i].Split('-');
                List<string> ids = GetIDS(range[0], range[1]);

                for (int j = 0; j < ids.Count; j++)
                {
                    string id = ids[j];
                    int mid = id.Length / 2;
                    if (id[0..mid] == id[mid..])
                    {
                        totalOfInvalidIDs = totalOfInvalidIDs + Int64.Parse(id);
                        continue;
                    }
                }
            }
            Console.WriteLine($"The Answer is {totalOfInvalidIDs}");

			List<string> GetIDS(string start, string end)
            {
                var ids = new List<string>();
                for (long i = Int64.Parse(start); i <= Int64.Parse(end); i++)
                {
                    string id = i.ToString();
					ids.Add(id);
                }
                return ids;
            }
        }
    }

    [Solution(Day = "2.2", Description = "Gift Shop Part 2")]
    class DayxPart2 : ISolution
    {
        public void Run(List<string> input)
        {
            // Solution Here

            Console.WriteLine($"The Answer is ....");
        }
    }
}
