using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    internal class Quiz
    {
        public string Title { get; }
        public List<Question> Questions { get; }
        public Quiz(string title, List<Question> questions)
        {
            Title = title;
            Questions = questions;
        }
        public void Gameplay()
        {

        }
    }
}
