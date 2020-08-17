using System.IO;

namespace BookWorm
{
    public class TextFileReader
    {
        public string[] Content { get; set; }

        public TextFileReader(string filePath)
        {
            this.Content = File.ReadAllLines(filePath);
        }
    }
}
