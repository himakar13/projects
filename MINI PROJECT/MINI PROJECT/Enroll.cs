using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using miniproject;

namespace miniprojects
{
    public class EnrollData
    {
        private Student student;
        private Course course;
        private DateTime enrollmentDate;

        public Student _student
        {
            get { return student; }
            set { student = value; }
        }
        public Course _course
        {
            get { return course; }
            set { course = value; }
        }
        public DateTime _dateTime
        {
            get { return enrollmentDate; }
            set { enrollmentDate = value; }
        }

        public EnrollData(Student student, Course course, DateTime enrollDate)
        {
            this.student = student;
            this.course = course;
            this.enrollmentDate = enrollDate;

        }
    }
}