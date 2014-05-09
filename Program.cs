using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicates
{
    class Program
    {
        static bool duplicatesFound=false;

        static List<string> OpenAndReadFile(string path)
        {
            List<string> lines = new List<string>();
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                lines.Add(line);
            }

            file.Close(); 
            return lines;
        }

        static List<string> RemoveDuplicates(List<string> lines)
        {
            List<string> uniqueLines = new List<string>();

            uniqueLines = lines.Distinct().ToList();

            if (lines.Count != uniqueLines.Count) duplicatesFound = true;
            return uniqueLines;
        }

    
        static void Main(string[] args)
        {
            
        }
    }
}
