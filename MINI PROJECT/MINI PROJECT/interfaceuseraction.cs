using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniproject
{
    interface UserInterface
    {
        void showMainScreen();
        void showStudentScreen();
        void showAdminScreen();
        void showAllStudentsScreen();
        void showStudentRegistrationScreen(); // Execute the register method of AppEngine class
        void introduceNewCourseScreen();
        void showAllCoursesScreen();
    }
}