using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPatterns
{
    public class Journal
    {
        private readonly List<string> entries = new List<string>();

        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text} ");
            return count;
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public void Save(String fileName)
        {
            File.WriteAllText(fileName, ToString());
        }

        public override string ToString()
        {
            return String.Join(Environment.NewLine, entries);
        }
    }

    public class Persitence
    {
        public void SaveToFile(Journal journal, string Filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(Filename))
            {
                File.WriteAllText(Filename, journal.ToString());
            }
        }
    }
}
