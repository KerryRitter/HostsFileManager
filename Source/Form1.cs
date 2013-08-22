using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HostsFileManager
{
    public partial class HostsFileManager : Form
    {
        public FileIO fileIO = new FileIO();

        public HostsFileManager()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.fileIO.ReadFileToEntries();
            this.UpdateLists();
            this.SetDefaultInput();
        }

        private void UpdateLists()
        {
            this.enabled.Items.Clear();
            this.disabled.Items.Clear();

            foreach (Entry entry in this.fileIO.Entries)
            {
                if (entry.Enabled)
                {
                    this.enabled.Items.Add(entry);
                }
                else
                {
                    this.disabled.Items.Add(entry);
                }
            }
        }

        private void disable_Click(object sender, EventArgs e)
        {
            this.SetEnabledOrDisabled(this.enabled.SelectedItems, false);
        }

        private void enable_Click(object sender, EventArgs e)
        {
            this.SetEnabledOrDisabled(this.disabled.SelectedItems, true);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            this.Delete(this.enabled.SelectedItems, this.disabled.SelectedItems);
        }

        private void add_Click(object sender, EventArgs e)
        {
            this.Add();
        }

        private void SetEnabledOrDisabled(ListBox.SelectedObjectCollection searchItems, bool enabledValue)
        {
            foreach (Entry searchEntry in searchItems)
            {
                foreach (Entry entry in this.fileIO.Entries)
                {
                    if (entry.EqualToEntry(searchEntry))
                    {
                        entry.Enabled = enabledValue;
                    }
                }
            }

            this.fileIO.WriteEntriesToFile();
            this.UpdateLists();
        }

        private void Delete(ListBox.SelectedObjectCollection enabled, ListBox.SelectedObjectCollection disabled)
        {
            foreach (Entry searchEntry in enabled)
            {
                this.DeleteFromList(enabled, searchEntry);
            }

            foreach (Entry searchEntry in disabled)
            {
                this.DeleteFromList(disabled, searchEntry);
            }

            this.fileIO.WriteEntriesToFile();
            this.UpdateLists();
        }

        private void DeleteFromList(ListBox.SelectedObjectCollection searchItems, Entry searchEntry) 
        {
            for (int i = 0; i < searchItems.Count; i++)
            {
                var entry = (Entry) searchItems[i];
                if (entry.EqualToEntry(searchEntry))
                {
                    this.fileIO.Entries.Remove(entry);
                    return;
                }
            }
        }

        private void Add()
        {
            var newEntry = new Entry(destinationText.Text, redirectingText.Text, true);

            this.SetDefaultInput();
            this.fileIO.Entries.Add(newEntry);
            this.fileIO.WriteEntriesToFile();
            this.UpdateLists();
        }

        public void SetDefaultInput()
        {
            destinationText.Text = "127.0.0.1";
            redirectingText.Text = "";
        }
    }
}
