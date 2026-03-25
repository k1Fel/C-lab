using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starodubov_PD21
{
    public class FileLogger
    {
        public string logFilePath = "C:/Users/mrbod/source/repos/Starodubov_PD21/Starodubov_PD21/logPD21.txt";
        public FileLogger(MessagePublisher publisher)
        {
            publisher.MessagePublished += Log;
        }
        public void Log(string message)
        {
            string entry = $"[{DateTime.Now:HH:mm:ss}] {message}";
            File.AppendAllText(logFilePath, entry + Environment.NewLine);
            Console.WriteLine($"Logged: {entry}");
        }

    }
}
