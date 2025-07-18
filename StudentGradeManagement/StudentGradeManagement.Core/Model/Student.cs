
namespace StudentGradeManagement.Core.Model
{
    public class Student
    {
        private string _name = string.Empty;
        private int _age;
        private string _email = string.Empty;
        private Score _score;
        public string Name { get { return _name; } set { _name = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public Score Score { get { return _score; } set { _score = value; } }
        public int StudentID { get; set; }
    }
}
