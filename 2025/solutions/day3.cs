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
			}

            Console.WriteLine($"The Answer is {totalMaxJoltage}");
        }
    }

    [Solution(Day = "3.2", Description = "Lobby 2")]
    class Day3Part2 : ISolution
    {
        public void Run(List<string> input)
        {
            int totalMaxJoltage = 0;
            foreach (var line in input)
            {
                List<int> bank = line.Select(l => int.Parse(l.ToString())).ToList<int>();
                List<int> jolt = new List<int>(); //maybe???
                int first = bank[0..^12].Max(); // still true
                for (int i = first;  i < bank.Count; i++)
                int firstIndex = bank.FindIndex(c => c == first) + 1; ...
                /* start at n-i(max), then get n-i(max) for everytrhing after...? 
                 * add each 'find' to a list/string (jolt) aand at the end convert to an int to add to total.
                 */

                int last = bank[firstIndex..].Max();
                totalMaxJoltage += (last);
                Console.WriteLine($"Line: {line}, First Index: {firstIndex}\tFirst: {first}\tLast: {last}\tJoltage: {totalMaxJoltage} ");
            }

            Console.WriteLine($"The Answer is ....");
        }
    }
}
