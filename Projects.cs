using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static Freelancer_Sume_Sikazwe_ADI.FreelancerManager;
using static Freelancer_Sume_Sikazwe_ADI.MainForm;

namespace Freelancer_Sume_Sikazwe_ADI
{
    public partial class Projects : Form
    {
        private string _username;
        private string _email;
        private string _phoneNumber;
        private string _userType;
        private List<Project> projectList;

        private List<Freelancer> freelancers = new List<Freelancer>();

        public Projects(string username, string email, string phoneNumber, string userType)
        {
            InitializeComponent();
            projectList = new List<Project>();

            // Store the received user details
            _username = username;
            _email = email;
            _phoneNumber = phoneNumber;
            _userType = userType;
        }

        public class Project
        {
            public string ProjectName { get; set; }
            public string Description { get; set; }
            public int TimeLine { get; set; }
            public float Budget { get; set; }
            public List<Proposal> Proposals { get; set; }

            public Project(string projectName, string description, int timeLine, float budget)//string title, int duration, float budget, string description)
            {
                ProjectName = projectName;
                Description = description;
                TimeLine = timeLine;
                Budget = budget;
                Proposals = new List<Proposal>();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to return ?, Any unsaved changes will be deleted", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                new MainForm(_username, _email, _phoneNumber, _userType).Show();
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            // Get the input values
            string title = TitleTxt.Text.Trim();
            if (!int.TryParse(DurationTxt.Text.Trim(), out int duration))
            {
                MessageBox.Show("Please enter a valid duration in days.");
                return;
            }
            if (!float.TryParse(BudgetTxt.Text.Trim(), out float budget))
            {
                MessageBox.Show("Please enter a valid budget.");
                return;
            }
            string description = DescriptionTxt.Text.Trim();

            Project newProject = new Project(title, description, duration, budget);

            projectList.Add(newProject);
            SaveProjectsToFile();
        }

        private void SaveProjectsToFile()
        {
            string filePath = Path.Combine("projects.txt");

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                foreach (var project in projectList)
                {
                    string projectLine = $"{project.ProjectName},{project.Description},{project.TimeLine},{project.Budget}";
                    writer.WriteLine(projectLine);
                }
            }

            MessageBox.Show("Project successfully saved.");

            TitleTxt.Clear();
            DurationTxt.Clear();
            BudgetTxt.Clear();
            DescriptionTxt.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Review reviewForm = new Review(freelancers);
           reviewForm.Show();
        }
    }
}
