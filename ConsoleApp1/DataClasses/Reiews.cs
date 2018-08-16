using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Reiews : Other
    {
        public string UserName { get; set; }
        public double Rating { get; set; }
        public string Text { get; set; }
        public string FeedbackEmail { get; set; }

        protected Reiews()
        {

        }

        public Reiews(int id, string userName, double rating, string text, string feedbackEmail) : base(id)
        {
            UserName = userName;
            Rating = rating;
            Text = text;
            FeedbackEmail = feedbackEmail;
        }
    }
}
