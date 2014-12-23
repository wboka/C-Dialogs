using System;
using System.Windows.Forms;

namespace DialogTest
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnShowInputDialog_Click(object sender, EventArgs e)
        {
            // Set a string to store input from dialog
            string s = "";

            // Store the dialog result as well as pass the variable to store the user input
            DialogResult dialogReturned = InputDialog.Show(ref s);

            if (dialogReturned == DialogResult.OK && s.Length > 0)
            {
                // Show the input if the user entered text and clicked the confirm button
                MessageBox.Show(s);
            }
        }
    }
}
