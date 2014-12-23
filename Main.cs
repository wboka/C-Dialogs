using System;
using System.Windows.Forms;

namespace DialogTest
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            new InputDialog();
        }

        private void btnShowInputDialog_Click(object sender, EventArgs e)
        {
            string s = "";

            DialogResult dialogReturned = InputDialog.Show(ref s, w: 350, h: 150);

            if (dialogReturned == DialogResult.OK)
            {
                MessageBox.Show(s);
            }
        }
    }
}
