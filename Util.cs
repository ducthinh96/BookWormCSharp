using System.IO;

namespace BookWorm
{
    public static class Util
    {
        public static string[] ReadTextFile(string filePath)
        {
            return File.ReadAllLines(filePath);
        }
    }
}
