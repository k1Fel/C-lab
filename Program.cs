using static Starodubov_PD21.TextOperator;
using static Starodubov_PD21.FileOperator;

namespace Starodubov_PD21
{
    public class Program
    {
        public string InputPath = "C:/Users/mrbod/source/repos/Starodubov_PD21/Starodubov_PD21/textPD21.txt";
        public string OutputPath = "C:/Users/mrbod/source/repos/Starodubov_PD21/Starodubov_PD21/resultPD21.txt";

        public void Main(string[] args)
        {
            Console.WriteLine("TASK1");
            File.WriteAllText(OutputPath, string.Empty);

            ProcessFile(InputPath, OutputPath, ToUpperCase);
            ProcessFile(InputPath, OutputPath, CountChars);
            ProcessFile(InputPath, OutputPath, WordCount);

            Console.WriteLine("Операції виконано. Результати записані у файл resultPD21.txt");

            Console.WriteLine("\nTASK2");
            MessagePublisher publisher = new MessagePublisher();
            FileLogger logger = new FileLogger(publisher);

            for (int i = 1; i <= 4; i++)
            {
                Console.Write($"Enter message {i}: ");
                string input = Console.ReadLine() ?? string.Empty;
                publisher.PublishMessage(input);
            }
        }
    }
}