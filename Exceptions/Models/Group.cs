
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Exceptions.Models
{
    internal class Group
    {

        public Group(string groupno, int studentlimit)
        {
            GroupNo = groupno;
            StudentLimit = studentlimit;
        }
        public string GroupNo { get; set; }
        private int _studentLimit;
        public int StudentLimit
        {
            get
            { return _studentLimit; }
            set
            {
                if (value < 5 || value > 18)
                {
                    throw new ArgumentOutOfRangeException("Student limit must be between 5 and 18.");
                }
                _studentLimit = value;
            }
        }
        private Student[] _students;
        public Student[] Students
        {
            get { return _students; }
        }

        public bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length != 5)
                return false;
            if (!char.IsUpper(groupNo[0]) || !char.IsUpper(groupNo[1]))
                return false;
            if (!char.IsDigit(groupNo[2]) || !char.IsDigit(groupNo[3]) || !char.IsDigit(groupNo[4]))
                return false;

            return true;
        }

        public void AddStudent(Student student)
        {
            if (_students.Length >= _studentLimit)
                throw new InvalidOperationException("Student limit exceeded.");



            Array.Resize(ref _students, _students.Length + 1);
            _students[_students.Length - 1] = student;
        }


        public Student GetStudent(int? id)
        {
            if (id == null)
                return null;
            foreach (var student in _students)
            {
                if (student.Id == id)
                    return student;
            } 
            return null;
        }

        public Student[] GetAllStudents()
        {
            return _students;
        }
    }
}
