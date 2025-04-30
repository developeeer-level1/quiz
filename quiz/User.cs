using System;
using System.Text;
using System.Text.Json;

namespace quiz
{
    [Serializable]
    class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string BirthDate { get; set; }
    }
}
