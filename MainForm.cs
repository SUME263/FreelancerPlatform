using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Freelancer_Sume_Sikazwe_ADI.FreelancerManager;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Freelancer_Sume_Sikazwe_ADI
{
    public partial class MainForm : Form
    {
        private string _username;
        private string _email;
        private string _phoneNumber;
        private string _userType;

        private List<Project> projectList;

        public MainForm(string username, string email, string phoneNumber, string userType)
        {
            InitializeComponent();
            projectList = new List<Project>();
            LoadProjectsFromFile();
            BindDataToDataGridView();

            _username = username;
            _email = email;
            _phoneNumber = phoneNumber;
            _userType = userType;

            DisplayUserDetails(username, email, phoneNumber, userType);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        public class Proposal
        {
            public string ProposalName { get; set; }
            public string Details { get; set; }
        }

        public class Project
        {
            public string ProjectName { get; set; }
            public string Description { get; set; }
            public int TimeLine { get; set; }
            public float Budget { get; set; }
            public List<Proposal> Proposals { get; private set; }

            public Project(string projectName, string description, int timeLine, float budget)
            {
                ProjectName = projectName;
                Description = description;
                TimeLine = timeLine;
                Budget = budget;
                Proposals = new List<Proposal>();
            }

            public void AddProposal(Proposal proposal)
            {
                if (proposal != null)
                {
                    Proposals.Add(proposal);
                }
                else
                {
                    throw new ArgumentNullException(nameof(proposal), "Proposal cannot be null.");
                }
            }
        }

        private void LoadProjectsFromFile()
        {
            string filePath = Path.Combine("projects.txt");

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var data = line.Split(',');
                    if (data.Length == 4 &&
                        int.TryParse(data[2], out int timeLine) &&
                        float.TryParse(data[3], out float budget))
                    {
                        var project = new Project(data[0], data[1], timeLine, budget);
                        projectList.Add(project);
                    }
                }
            }
        }

        private void BindDataToDataGridView()
        {
            var dataSource = projectList.Select(p => new
            {
                ProjectName = p.ProjectName,
                TimeLine = p.TimeLine,
                Budget = p.Budget,
                Description = p.Description
            }).ToList();

            projectsDataGridView.DataSource = dataSource;
        }

        //display the user's details 
        public void DisplayUserDetails(string username, string email, string phoneNumber, string userType)
        {
            lblUsername.Text = $"{username}";
            lblEmail.Text = $"{email}";
            lblPhoneNumber.Text = $"{phoneNumber}";
            lblUserType.Text = $"{userType}";
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                new Login().Show();
            }
        }

        //buttons validate the current user to allow access to specific tasks
        private void button2_Click(object sender, EventArgs e)
        {
            if (lblUserType.Text == "Client") 
            {
                new Projects(_username, _email, _phoneNumber, _userType).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Only clients can view this section.", "Access Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_userType == "Freelancer")
            {
                FreelancerManager freelancerManager = new FreelancerManager();
                freelancerManager.Show();
            }
            else
            {
                
                MessageBox.Show("Only freelancers can access this section.", "Access Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //comment out, giving errors
        /*Reviews System 
        //private void SubmitReviewButton_Click(object sender, EventArgs e)
        //{
        //    int rating = int.Parse(RatingTextBox.Text);
        //    string comments = CommentsTextBox.Text;
        //    string freelancerUsername = SelectedFreelancerUsername; 
        //    string reviewerUsername = _username; 

        //    Review newReview = new Review(reviewerUsername, freelancerUsername, rating, comments);
        //    selectedFreelancer.AddReview(newReview); 

        //    MessageBox.Show("Review submitted successfully!");
        */
    }
}
