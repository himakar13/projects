using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniproject
{
    public class Displayinfo
    {
        public void display_Student_Info(Student student)
        {
            Console.WriteLine($"The student Info is student id {student.Id}, student name {student.Name}, student dob {student.DOB}");

        }

        public void display_Course_Info(Course course)
        {
            Console.WriteLine($"the course id {course.Id}, course name {course.Name}, couse duration is {course.duration}, corse fee is {course.fees}");
        }

        public void display_Enroll_details_(Enrollment enroll)
        {
            //display(enroll._student);
            //display(enroll._course);
            Console.WriteLine(Enrollment.dateTime);
        }
    }
}