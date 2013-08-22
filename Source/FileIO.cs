using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HostsFileManager
{
    public class FileIO
    {
        public List<Entry> Entries { get; set; }

        public FileIO() {
            this.Entries = new List<Entry>();
        }

        public FileIO(List<Entry> entries) {
            this.Entries = entries;
        }

        public void ReadFileToEntries()
        {
            string[] lines = null;
            try
            {
                lines = System.IO.File.ReadAllLines(@"C:\Windows\System32\drivers\etc\hosts");
            }
            catch (Exception)
            {
                MessageBox.Show("The hosts file could not be written to. Please check the file permissions.");
                Environment.Exit(0);
            }

            foreach (string line in lines)
            {
                if (line != "") { 
                    char[] delimiterChars = { ' ', '\t' };
                    string[] words = line.Split(delimiterChars);
                    bool enabled = true;

                    if ((words.Length == 2) && (words[1] != "space.")) // default hosts has a line that says "# space.", so ignore
                    {                       
                        if (words[0][0] == '#')
                        {
                            enabled = false;
                            words[0] = words[0].Substring(1);
                        }

                        this.Entries.Add(new Entry(words[0], words[1], enabled));
                    }
                }
            }
        }

        public void WriteEntriesToFile()
        {
            string output = "";
            foreach (Entry entry in this.Entries)
            {
                output += entry;
            }

            try
            {
                System.IO.File.WriteAllText(@"C:\Windows\System32\drivers\etc\hosts", output);
            }
            catch (Exception) 
            {
                MessageBox.Show("The hosts file could not be written to. Please check the file permissions.");
                Environment.Exit(0);
            }
        }
    }
}
