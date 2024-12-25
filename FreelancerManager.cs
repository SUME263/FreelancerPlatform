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

namespace Freelancer_Sume_Sikazwe_ADI
{
    public partial class FreelancerManager : Form
    {
        public List<Freelancer> freelancers = new List<Freelancer>();

        public class Freelancer
        {
            public string FreelancerID { get; private set; }
            public string Skills { get; set; }
            public string Portfolio { get; set; }
            public string WorkExperience { get; set; }
            public List<Review> Reviews { get; private set; }

            // Static variable to keep track of the last assigned ID
            private static int lastAssignedId = 0;

            public Freelancer(string skills, string portfolio, string workExperience)
            {
                FreelancerID = GenerateFreelancerId();
                Skills = skills;
                Portfolio = portfolio;
                WorkExperience = workExperience;
                Reviews = new List<Review>();
            }

            private string GenerateFreelancerId()
            {
                lastAssignedId++;
                return $"F{lastAssignedId:0000}"; // Formats the ID as F0001, F0002, etc.
            }

            public void AddReview(FreelancerReview review)
            {
                if (review != null)
                {
                    //Reviews.Add(review);
                }
                else
                {
                    throw new ArgumentNullException(nameof(review), "Review cannot be null.");
                }
            }
        }

        public FreelancerManager()
        {
            InitializeComponent();
        }

        private void FreelancerManager_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string skills = SkillTxt.Text.Trim();
            string portfolio = PortfolioTxt.Text.Trim();
            string workExperience = WorkTxt.Text.Trim();

            Freelancer newFreelancer = new Freelancer(skills, portfolio, workExperience);
            freelancers.Add(newFreelancer);

            SaveFreelancersToFile();

            SkillTxt.Clear();
            PortfolioTxt.Clear();
            WorkTxt.Clear();

            MessageBox.Show("Freelancer details added successfully");
        }

        private void SaveFreelancersToFile()
        {
            string filePath = Path.Combine("freelancers.txt");

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                foreach (var freelancer in freelancers)
                {
                    string line = $"{freelancer.FreelancerID},{freelancer.Skills},{freelancer.Portfolio},{freelancer.WorkExperience}";
                    writer.WriteLine(line);
                }
            }

            freelancers.Clear();
        }

        private void OpenReviewForm_Click(object sender, EventArgs e)
        {
            Review reviewForm = new Review(freelancers); // Pass the freelancers list
            reviewForm.Show();
        }

        private void WorkTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void PortfolioTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
