using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HostsFileManager
{
    public class Entry
    {
        public string Destination { get; set; }
        public string Redirecting { get; set; }
        public bool Enabled { get; set; }

        public Entry()
        {
            this.Destination = "";
            this.Redirecting = "";
            this.Enabled = false;
        }

        public Entry(string destination, string redirecting, bool enabled)
        {
            this.Destination = destination;
            this.Redirecting = redirecting;
            this.Enabled = enabled;
        }

        public override string ToString() {
            string s = this.Enabled ? "" : "#";
            s += "" + this.Destination + " " + this.Redirecting;
            s += "\n";
            return s;
        }

        public bool EqualToEntry(Entry compare)
        {
            return ((compare.Destination == this.Destination) && (compare.Redirecting == this.Redirecting));
        }
    }
}
