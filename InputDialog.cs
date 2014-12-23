using System.Windows.Forms;

namespace DialogTest
{
    class InputDialog
    {
        public static DialogResult Show(ref string input, string prompt = "", string confirmText = "&OK", string cancelText = "&Cancel", int w = 200, int h = 70)
        {
            // Create the form
            Form inputBox = new Form();

            // Set the form border style
            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Set size of the form
            System.Drawing.Size size = new System.Drawing.Size(w, h);
            inputBox.ClientSize = size;
            // Set the prompt
            inputBox.Text = prompt;
            // Set the form's starting position
            inputBox.StartPosition = FormStartPosition.CenterParent;

            // Create an input box
            TextBox textBox = new TextBox();
            // Set the input's size
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            // Set the input's location
            textBox.Location = new System.Drawing.Point(5, 5);
            // Set the text to the string passed in as input
            textBox.Text = input;
            // Add the input to the form
            inputBox.Controls.Add(textBox);

            // Create a confirm button
            Button confirmButton = new Button();
            // Set the dialog result to OK
            confirmButton.DialogResult = DialogResult.OK;
            // Set the confirm button's name
            confirmButton.Name = "confirmButton";
            // Set the confirm button's size
            confirmButton.Size = new System.Drawing.Size(75, 23);
            // Set the confirm button's text
            confirmButton.Text = confirmText;
            // Set the confirm button's location
            confirmButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            // Add the confirm button to the form
            inputBox.Controls.Add(confirmButton);

            // Create a cancel button
            Button cancelButton = new Button();
            // Set the dialog result to Cancel
            cancelButton.DialogResult = DialogResult.Cancel;
            // Set the cancel button's name
            cancelButton.Name = "cancelButton";
            // Set the cancel button's size
            cancelButton.Size = new System.Drawing.Size(75, 23);
            // Set the cancel button's text
            cancelButton.Text = cancelText;
            // Set the cancel button's location
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            // Add the cancel button to the form
            inputBox.Controls.Add(cancelButton);

            // Set the accept button to the confirm button
            inputBox.AcceptButton = confirmButton;
            // Set the cancel button to the cancel button
            inputBox.CancelButton = cancelButton;

            // Get the dialog result from the form
            DialogResult result = inputBox.ShowDialog();

            // Set the input to the text input's text if the user click the confirm button otherwise set it to null
            input = result == DialogResult.OK ? textBox.Text : null;

            // Return the dialog result
            return result;
        }
    }
}
