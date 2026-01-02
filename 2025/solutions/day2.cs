namespace _2025
{
    [Solution(Day = "2.1", Description = "Gift Shop")]
    class DayxPart1 : ISolution
    {
        public void Run(List<string> input)
        {
            Console.WriteLine($"{input.Count} Input Lines Parsed,");
            string[] ranges = input[0].Split(',');
            for (int i = 0; i < ranges.Length; i++)
            {
                Console.Write($"Input: {ranges[i]}\t\t\t");
                int[] range = { Convert.ToInt32(ranges[i].Split("-")) };
                

                Console.WriteLine($"Start: {range[0]}\t\t\t\tEnd: {range[1]}");
            }

            Console.WriteLine("The Answer is ....");
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
