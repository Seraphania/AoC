namespace _2025
{
    public class FileReader
    {
        string baseDir = AppContext.BaseDirectory;

        public List<string> LoadInput(string day)
        {
            string path = Path.Combine(
                baseDir,
                "inputs",
                $"{day}.txt"
                );

            if (!File.Exists(path))
                throw new FileNotFoundException($"There is no input for {day}.\nPlease place the input data in:\n{path}",path);

            return File.ReadAllLines(path).ToList();
      
        }
    }
}
