using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RainbowSchoolPage_3
{
    public class RainbowSchool
    {
        public static List<Student> StuList = new List<Student>()
        {
            new Student("John","10","B"),new Student("Moses","10","A"),
            new Student("Sam","10","C"),new Student("Harry","9","A"),
            new Student("Jones","8","B"),new Student("Paul","9","B")
        };
        public static List<Teacher> TeachList = new List<Teacher>()
        {
            new Teacher("Saul","9","A"),new Teacher("Sarah","10","C"),
            new Teacher("David","8","B"),new Teacher("Brock","9","A")
        };
        public static List<Subject> SubjectList = new List<Subject>()
        {
            new Subject("English","101","David"),new Subject("Maths","102","Sarah"),
            new Subject("Science","103","Saul"),new Subject("Social","104","Brock")
        };
        public static void StudentsInClass()
        {
            Console.WriteLine("Enter Class :");
            var className = Console.ReadLine();
            var studentinclass = StuList.FindAll(s => s.Class == className).ToList();
            if (studentinclass.Count != 0)
            {
                Console.WriteLine("Students in class {0}", className);
                foreach (var student in studentinclass)
                {
                    Console.WriteLine("Student_Name : {0}, Class : {1}, Section : {2}", student.Name, student.Class, student.Section);
                }
            }
            else
            {
                Console.WriteLine("No students in class {0}", className);
                return;
            }
        }
        public static void SubjectTaughtByTeacher()
        {
            Console.WriteLine("Enter Teacher name :");
            var teacherName = Console.ReadLine();
            var subjecttaughtbyteacher = SubjectList.Where(s => s.Teacher == teacherName).ToList();
            if (subjecttaughtbyteacher.Count != 0)
            {
                Console.WriteLine("Subject taught by Teacher {0}", teacherName);
                foreach (var subject in subjecttaughtbyteacher)
                {
                    Console.WriteLine("Subject_Name : {0}, Subect_Code : {1}, Teacher_Name : {2}", subject.Name, subject.Subjectcode, subject.Teacher);
                }
            }
            else { Console.WriteLine("No Subjects taught by {0}", teacherName); }
            return;
        }
        static void Main(string[] args)
        {
            RainbowSchool.StudentsInClass();
            RainbowSchool.SubjectTaughtByTeacher();
        }
    }
}
