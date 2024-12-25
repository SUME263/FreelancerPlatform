using System.ComponentModel.DataAnnotations;

namespace Freelancer_Sume_Sikazwe_ADI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Sign_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Signup().Show();
        }

        private void Log_Click(object sender, EventArgs e)
        {
            string enteredUsername = UsernameTxt.Text.Trim();
            string enteredPassword = PasswordTxt.Text.Trim();
            string enteredEmail = EmailTxt.Text.Trim();

            //checks the text file 
            string filePath = Path.Combine("user_profiles.txt");

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] userDetails = line.Split(',');

                    if (userDetails.Length >= 5)
                    {
                        string username = userDetails[0].Trim();
                        string password = userDetails[1].Trim();
                        string email = userDetails[2].Trim();
                        string phoneNumber = userDetails[3].Trim();
                        string userType = userDetails[4].Trim();

                        if (enteredUsername == username && enteredPassword == password && enteredEmail == email)
                        {
                            MessageBox.Show("Login successful!");

                            MainForm mainForm = new MainForm(username, email, phoneNumber, userType);
                            mainForm.DisplayUserDetails(username, email, phoneNumber, userType);
                            mainForm.Show();

                            this.Hide();
                            return;
                        }
                    }
                }
                MessageBox.Show("Invalid details. Please try again.");
            }
            else
            {
                MessageBox.Show("User profile file not found.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ask user if they are sure they want to exit the app
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application ?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
