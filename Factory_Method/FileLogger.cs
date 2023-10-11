using System.IO;

namespace Factory_Method
{
    public class FileLogger : ILogger
    {
        private string filePath;

        public FileLogger(string filePath)
        { 
            this.filePath = filePath;
        }

        public void Log(string message)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"{DateTime.Now}: {message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to log file: {ex.Message}");
            }
        }
    }
}