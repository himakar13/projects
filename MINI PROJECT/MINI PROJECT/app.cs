using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static miniproject.Displayinfo;

namespace miniproject
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }

        public Student(int id, string name, string dob)
        {
            Id = id;
            Name = name;
            DOB = dob;
        }

    }

    public class Course
    {
        public int Id;
        public string Name;
        public int duration;
        public float fees;


        public Course(int id, string name, int dura, float fee)
        {
            this.Id = id;
            this.Name = name;
            this.duration = dura;
            this.fees = fee;
        }

    }
    class App
    {
        Displayinfo info = new Displayinfo();
        public void Scenerio1()
        {
            Student student = new Student(111, "Sam", "21/09/1998");
            Student student1 = new Student(112, "Bhaskar", "11/07/1996");
            Student student2 = new Student(113, "Kumar", "27/08/1999");

            info.display_Student_Info(student);
            
        }

        public void Scenerio2()
        {
            Student[] students = new Student[2];
            students[0] = new Student(1001, "shaik", "20/03/1996");
            students[1] = new Student(1002, "Irfankhan", "22/06/1999");
            students[2] = new Student(1003, "suman", "11/10/1997");
            for (int i = 0; i < students.Length; i++)
            {
                info.display_Student_Info(students[i]);

            }
        }

        public void Scenerio3()
        {
            Console.WriteLine(" Please Enter the no.of students you want");
            int n = Convert.ToInt32(Console.ReadLine());
            Student[] student = new Student[n];
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine("Please  Enter Student Id,Name and Date of Birth");
                student[i] = new Student(Convert.ToInt32(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());
            }
            for (int i = 0; i < student.Length; i++)
            {
                info.display_Student_Info(student[i]);
            }



        }
        static void Main(string[] args)
        {
            App app = new App();

            //AppEngine engine = new AppEngine();

            //new UserInterFace().showFirstScreen();

            Console.Read();
        }
    }
}