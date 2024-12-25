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

namespace Freelancer_Sume_Sikazwe_ADI
{
    public partial class Review : Form
    {
        private List<Freelancer> freelancers;

        public Review(List<FreelancerManager.Freelancer> freelancers)
        {
            InitializeComponent();
            this.freelancers = freelancers;

            foreach (var freelancer in freelancers)
            {
                FreeLancerBox.Items.Add(freelancer.FreelancerID);
            }
        }

       

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string selectedFreelancerId = FreeLancerBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedFreelancerId))
            {
                MessageBox.Show("Please select a freelancer.");
                return;
            }

            // Validate rating input
            if (!int.TryParse(Rating.Text, out int rating) || rating < 1 || rating > 5)
            {
                MessageBox.Show("Please enter a valid rating between 1 and 5.");
                return;
            }

            string comments = CommentTxt.Text.Trim();
            var freelancer = freelancers.FirstOrDefault(f => f.FreelancerID == selectedFreelancerId);
           
            if (freelancer != null)
            {
                var review = new FreelancerReview("Username", freelancer.FreelancerID, rating, comments);
               
                freelancer.AddReview(review);

                MessageBox.Show("Review submitted successfully!");

                Rating.Clear();
                CommentTxt.Clear();
            }
            else
            {
                MessageBox.Show("Freelancer not found.");
            }

            Rating.Clear();
            CommentTxt.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class FreelancerReview
    {
        public string Reviewer { get; set; }
        public string Freelancer { get; set; }
        public int Rating { get; set; }
        public string Comments { get; set; }

        public FreelancerReview(string reviewer, string freelancer, int rating, string comments)
        {
            Reviewer = reviewer;
            Freelancer = freelancer;
            Rating = rating;
            Comments = comments;
        }
    }
}
