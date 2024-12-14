using System;
using System.Windows.Forms;

namespace UserInfoApp
{
    public class MainForm : Form
    {
        private Label nameLabel;
        private TextBox nameTextBox;
        private Label ageLabel;
        private TextBox ageTextBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Button submitButton;

        public MainForm()
        {
            // Initialize components
            nameLabel = new Label { Text = "Name", Location = new System.Drawing.Point(10, 10), AutoSize = true };
            nameTextBox = new TextBox { Location = new System.Drawing.Point(100, 10), Width = 200 };

            ageLabel = new Label { Text = "Age", Location = new System.Drawing.Point(10, 50), AutoSize = true };
            ageTextBox = new TextBox { Location = new System.Drawing.Point(100, 50), Width = 200 };

            emailLabel = new Label { Text = "Email", Location = new System.Drawing.Point(10, 90), AutoSize = true };
            emailTextBox = new TextBox { Location = new System.Drawing.Point(100, 90), Width = 200 };

            submitButton = new Button { Text = "Submit", Location = new System.Drawing.Point(100, 130), Width = 100 };
            submitButton.Click += SubmitButton_Click;

            // Add components to the form
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(ageLabel);
            Controls.Add(ageTextBox);
            Controls.Add(emailLabel);
            Controls.Add(emailTextBox);
            Controls.Add(submitButton);

            // Set form properties
            Text = "User Information Form";
            Size = new System.Drawing.Size(350, 220);
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string age = ageTextBox.Text;
            string email = emailTextBox.Text;

            MessageBox.Show($"Name: {name}\nAge: {age}\nEmail: {email}", "User Information");
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}