using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace OpenWhen
{
    public partial class CategoryForm : Form
    {
        private readonly string category;
        private readonly string message;
        private readonly List<Entry> entries;

        public CategoryForm(string category, string message, List<Entry> entries)
        {
            InitializeComponent();
            this.category = category;
            this.message = message;
            this.entries = entries;

            this.Text = "Category_Form";
            this.BackColor = Color.PeachPuff;
            label.Text = "Feel free to write it down how you feel.";
            textBoxMessage.Text = message; 
            txtBeforeReading.Text = "Before Reading";
            txtAfterReading.Text = "After Reading";
        }

        private void SaveEntry()
        {
            if (string.IsNullOrWhiteSpace(txtBeforeReading.Text) || string.IsNullOrWhiteSpace(txtAfterReading.Text))
            {
                MessageBox.Show("Please enter text in both fields before saving.");
                return;
            }

            Entry entry = new Entry(category, txtBeforeReading.Text);
            entry.AfterReading = txtAfterReading.Text;
            entries.Add(entry);

           
            MessageBox.Show("Entry saved successfully!");
            this.Close();
        }

        
    }
}