namespace _2025
{
    [Solution(Day = "2.1", Description = "Gift Shop")]
    class DayxPart1 : ISolution
    {
        public void Run(List<string> input)
        {
            Console.WriteLine($"{input.Count} Input Lines Parsed,");
            string[] ranges = input[0].Split(',');
            Int64 totalInvalidIDs = 0;
			for (int i = 0; i < ranges.Length; i++)
            {
                string[] range = ranges[i].Split('-');
                List<string> ids = GetIDS(range[0], range[1]);
				// invalid:
				// * sequence of digits repeated twice eg: 55 6464 123123
				// * leading zeros eg: 0101
				for (i = 0; i < ids.Count; i++)
                {
                    // work out how to filter....
				}

			}
			// Find all the invalid ID's and sum them

			Console.WriteLine("The Answer is ....");

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

            Console.WriteLine("The Answer is ....");
        }
    }
}
