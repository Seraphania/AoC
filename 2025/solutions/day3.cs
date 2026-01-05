namespace _2025
{
    [Solution(Day = "3.1", Description = "Lobby")]
    class Day3Part1 : ISolution
    {
        public void Run(List<string> input)
        {
            int totalMaxJoltage = 0;
			foreach (var line in input)
            {
				List<int> bank = line.Select(l => int.Parse(l.ToString())).ToList<int>();
                int first = bank[0..^1].Max();
                totalMaxJoltage += (first*10);
				int firstIndex = bank.FindIndex(c => c == first)+1;
                int last = bank[firstIndex..].Max();
                totalMaxJoltage += (last);
                Console.WriteLine($"Line: {line}, First Index: {firstIndex}\tFirst: {first}\tLast: {last}\tJoltage: {totalMaxJoltage} ");
			}

            Console.WriteLine($"The Answer is {totalMaxJoltage}");
        }
    }

    [Solution(Day = "3.2", Description = "Lobby 2")]
    class Day3Part2 : ISolution
    {
        public void Run(List<string> input)
        {
            // Solution Here

            Console.WriteLine($"The Answer is ....");
        }
    }
}
