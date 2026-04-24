using System;
using System.Windows.Forms;

namespace FormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        //    MessageBox.Show("Form is actually opening");
        }

        // ADD LANGUAGE
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string language = txtLanguage.Text.Trim();

            // Prevent empty input
            if (string.IsNullOrWhiteSpace(language))
            {
                MessageBox.Show("Please enter a programming language.");
                return;
            }

            // Prevent duplicates
            if (lstLanguages.Items.Contains(language))
            {
                MessageBox.Show("This language already exists in the list.");
                return;
            }

            // Add to list
            lstLanguages.Items.Add(language);

            // Display date and time
            lblDateTime.Text = "Added on: " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            // Clear textbox
            txtLanguage.Clear();
        }

        // REMOVE LANGUAGE
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstLanguages.SelectedItem != null)
            {
                lstLanguages.Items.Remove(lstLanguages.SelectedItem);

                lblDateTime.Text = "Removed on: " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }
    }
}