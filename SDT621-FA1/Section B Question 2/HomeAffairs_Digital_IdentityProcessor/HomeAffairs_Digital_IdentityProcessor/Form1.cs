using System;
using System.Windows.Forms;

namespace HomeAffairsDigitalIdentityProcessor
{
    public partial class Form1 : Form
    {
        private CitizenProfile profile;

        public Form1()
        {
            InitializeComponent();
            btnGenerate.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCitizenship.Items.Clear();
            cmbCitizenship.Items.Add("South African");
            cmbCitizenship.Items.Add("Visitor");
            cmbCitizenship.SelectedIndex = 0;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            profile = new CitizenProfile(
                txtName.Text,
                txtID.Text,
                cmbCitizenship.Text
            );

            string result = profile.ValidateID();

            txtResults.Text = "VALIDATION RESULT:\r\n" + result;

            btnGenerate.Enabled = result.StartsWith("Valid");
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (profile == null)
            {
                MessageBox.Show("Please validate ID first!");
                return;
            }

            txtResults.Clear();

            txtResults.AppendText("=== DIGITAL CITIZEN SUMMARY ===\r\n");
            txtResults.AppendText("-----------------------------------------------------------------------------\r\n");
            txtResults.AppendText("Name: " + profile.FullName + "\r\n");
            txtResults.AppendText("ID Number: " + profile.IDNumber + "\r\n");
            txtResults.AppendText("Age: " + profile.Age + "\r\n");
            txtResults.AppendText("Citizenship: " + profile.CitizenshipStatus + "\r\n");
            txtResults.AppendText("Validation: " + profile.ValidateID() + "\r\n");
            txtResults.AppendText("-----------------------------------------------------------------------------\r\n");
            txtResults.AppendText("Processed at: Home Affairs Digital Desk\r\n");
            txtResults.AppendText("Timestamp: " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}