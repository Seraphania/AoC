using System.Security.Cryptography;

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
            Console.WriteLine($"{input.Count} Input Lines Parsed,");
            string[] ranges = input[0].Split(',');
            Int64 totalOfInvalidIDs = 0;

            for (int i = 0; i < ranges.Length; i++)
            {
                string[] range = ranges[i].Split('-');
                List<string> ids = GetIDS(range[0], range[1]);
                Console.WriteLine($"Range: {range[0]} - {range[1]} ");
                for (int j = 0; j < ids.Count; j++)
                {
                    PatternSearch(ids[j]);
                }
            }
            Console.WriteLine($"The Answer is {totalOfInvalidIDs}");

            void PatternSearch(string id)
            {
                for (int section = id.Length / 2; section > 0; section--)
                {
                    string val = id[0..section];
                    List<string> substrings = new List<string>();
                    for (int startIndex = 0; startIndex < id.Length - section+1; startIndex += section)
                        {
                            int end = startIndex + section;
                            substrings.Add(id[startIndex..end]);
                        }
                    int check = 0;
                    foreach (string substring in substrings)
                    {
                        if (substring != val)
                        {
                            break;
                        }
                        else
                        {
                            check++;
                            continue;
                        }
                    }
                    if (check == substrings.Count)
                    {
                        Console.WriteLine($"\t Invalid ID: {id}");
                        totalOfInvalidIDs += Int64.Parse(id);
                        break;
                    }
                }
            }

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
}
