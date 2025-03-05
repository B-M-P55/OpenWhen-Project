using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OpenWhen
{
    public partial class EntriesForm : Form
    {
        public EntriesForm(List<Entry> entries)
        {
            InitializeComponent();
            if (entries.Count == 0)
            {
                txtEntries.Text = "No entries yet. Start by adding one!";
            }
            else
            {
                foreach (var entry in entries)
                {
                    txtEntries.Text += $"Date: {entry.Date}\r\n" +
                                      $"Feeling: Open when {entry.Category}\r\n" +
                                      $"Before Reading: {entry.BeforeReading}\r\n" +
                                      $"After Reading: {(entry.AfterReading.Length > 0 ? entry.AfterReading : "Not yet reflected")}\r\n" +
                                      new string('-', 40) + "\r\n";
                }
            }
        }

        private void txtEntries_TextChanged(object sender, EventArgs e)
        {

        }
    }
}