using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Starodubov_PD21.TextOperator;

namespace Starodubov_PD21
{
    public class FileOperator
    {
        public static void ProcessFile(string inputPath, string outputPath, TextOperation operation)
        {
            string[] lines = File.ReadAllLines(inputPath);

            using StreamWriter writer = new StreamWriter(outputPath, append: true);
            writer.WriteLine("\nРезультат операції:");

            int counter = 1;
            foreach (string line in lines)
            {
                string result = operation(line);
                writer.WriteLine($"{result} у рядку {counter}");
                counter++;
            }
        }
    }
}
