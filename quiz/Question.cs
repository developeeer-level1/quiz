using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace quiz
{
    internal class Question
    {
        public string Title { get; set; }
        public List<string> Option { get; set; }
        public List<int> CorrectOptions { get; set; }
        public Question(string text, List<string> options, List<int> correctAnswers)
        {
            Title = text;
            Option = options;
            CorrectOptions = correctAnswers;
        }
    }
}
