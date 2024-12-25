using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freelancer_Sume_Sikazwe_ADI
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent(); 
        }

        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string UserType { get; set; }
            
           
            public User(string username, string password, string email, string phoneNumber, string userType)
            {
                Username = username;
                Password = password;
                Email = email;
                PhoneNumber = phoneNumber;
                UserType = userType;
            }

            // save details in comma separated text file 
            public void SaveProfile(string filePath)
            {
                string userProfile = $"{Username},{Password},{Email},{PhoneNumber},{UserType}";

                File.AppendAllText(filePath, userProfile + Environment.NewLine);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = UsernameSign.Text;
            string password = PasswordSign.Text;
            string email = EmailSign.Text;
            string phoneNumber = PhoneNumberSign.Text;
            string userType = Freelancer.Checked ? "Freelancer" : "Client";


            // Validate password
            if (!IsValidPassword(password))
            {
                MessageBox.Show("Password must be exactly 12 characters long and contain at least one uppercase and one lowercase letter.");
                return;
            }

            User newUser = new User(username, password, email, phoneNumber, userType);

            string filePath = "user_profiles.txt";
            newUser.SaveProfile(filePath);

            MessageBox.Show("Profile saved!");

            UsernameSign.Text = string.Empty;
            PasswordSign.Text = string.Empty;
            EmailSign.Text = string.Empty;
            PhoneNumberSign.Text = string.Empty;

            //reset the radio buttons to a default
            Freelancer.Checked = false;
            Client.Checked = false;
        }

        private bool IsValidPassword(string password)
        {
            if (password.Length < 12) return false;

            bool hasUpper = password.Any(char.IsUpper);
            bool hasLower = password.Any(char.IsLower);

            return hasUpper && hasLower;
        }

        private void loginTwo_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Show();
        }
    }
}
