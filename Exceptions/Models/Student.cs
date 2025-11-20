

namespace Exceptions.Models
{
    internal class Student
    {
        private int _id;
        public int Id
        { 
        get {return _id;}
        }
        public string FullName { get; set; }
        public  double Point { get; set; }
        public static int idCounter = 0;
        public Student(string fullname,double point)
        {
            idCounter++;
            _id = idCounter;
            FullName = fullname;
            Point = point;

        }

        public  void StudentInfo()
        {
            Console.WriteLine($"Student id is {Id}, FullName is {FullName}, Point is {Point}");
        }
    
    }
}
