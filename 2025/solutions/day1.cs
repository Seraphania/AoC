namespace _2025
{
    [Solution(Day = "1.1", Description = "Secret Entrance")]
    class Day1Part1 : ISolution
    {
        public void Run(List<string> input)
        {
            Console.WriteLine($"{input.Count} Input Lines Parsed,");
            int answer = 0;
            int position = 50;

            for (int i = 0; i < input.Count; i++)
            {
                string line = input[i].Trim();
                string direction = line[0].ToString();
                int inputClicks = Convert.ToInt32(line[1..]);
                if (inputClicks > 100) 
                    inputClicks = inputClicks % 100;

                rotate(direction, inputClicks);
                if (position == 0)
                    answer++;
                continue;
            }

            void rotate(string dir, int clicks)
            {
                if (dir.ToUpper() == "L")
                {
                    if ((position - clicks) < 0)
                        position = 100 - Math.Abs(clicks - position);
                    else
                        position = position - clicks;
                }
                else if (dir.ToUpper() == "R") 
                {
                    if ((position + clicks) > 99)
                        position = 0 + Math.Abs(clicks + position - 100);
                    else
                        position = position + clicks;
                }
            }

            Console.WriteLine($"The Answer is {answer}");            
        }
    }

    [Solution(Day = "1.2",  Description = "Secret Entrance Part 2")]
    class Day1Part2 : ISolution
    {
        public void Run(List<string> input)
        {
            Console.WriteLine($"{input.Count} Input Lines Parsed,");
            int answer = 0;
            int position = 50;

            for (int i = 0; i < input.Count; i++)
            {
                string line = input[i].Trim();
                string direction = line[0].ToString();
                int inputClicks = Convert.ToInt32(line[1..]);
                if (inputClicks > 100)
                {
                    int hits = Math.DivRem(inputClicks, 100, out inputClicks);
                    answer = answer + hits;
                }

                //Console.Write($"Input No. {i+1}\t Line: {line} \tPosition: {position} \tDir: {direction} \tCount: {inputClicks}\t");
                rotate(direction, inputClicks);
                if (position == 0)
                    answer++;

                //Console.WriteLine($"Current Answer: {answer}");
                continue;
            }

            void rotate(string dir, int clicks)
            {
                if (dir.ToUpper() == "L")
                {
                    if ((position - clicks) < 0)
                    {
                        if (position != 0)
                            answer++;

                        position = 100 - Math.Abs(clicks - position);   
                    }
                    else
                        position = position - clicks;
                }
                else if (dir.ToUpper() == "R")
                {
                    if ((position + clicks) > 99)
                    {
                        if ((position + clicks) > 100)
                            answer++;

                        position = 0 + Math.Abs(clicks + position - 100);
                    }
                else
                        position = position + clicks;
                }
                //Console.Write($"New Pos: {position}\t");
            }

            Console.WriteLine($"The Answer is {answer}");
        }
    }
}
