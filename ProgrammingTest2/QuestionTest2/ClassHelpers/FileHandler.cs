using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Question2.Helpers
{
    public static class FileHandler
    {
        /// Reads a file from a path and returns each line in a list of string.
        public static List<string> readFile(this string filePath)
        {
            if (File.Exists(filePath))
                return File.ReadAllLines(filePath).ToList();
            else
                return new List<string>();
        }
    }
}
