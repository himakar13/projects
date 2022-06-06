using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace miniproject
{
    class DBConfigration
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        static SqlConnection getConnection()
        {
            con = new SqlConnection("data source = POOLW42SLPC6983\\SQLEXPRESS; Initial Catalog=StudentManagement; user id=sa; password=Temp1234");
            con.Open();
            return con;
        }
        public void introduce(Course course)
        {
            Console.WriteLine(course.Id + " " + course.Name + " " + course.duration + " " + "days," + " " + course.fees);
        }


        public void studentregisteration_Info(Student student)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                con = getConnection();

                cmd = new SqlCommand("insert into tblStudents values(@StudentId,@StudentName,@studentDOB)", con);
                cmd.Parameters.AddWithValue("@StudentId", student.Id);
                cmd.Parameters.AddWithValue("@StudentName", student.Name);
                cmd.Parameters.AddWithValue("studentDOB", student.DOB);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    Console.WriteLine("Data inserted successfully");
                else
                    Console.WriteLine("!! failed Not inserted ");


            }
            catch (SqlException e)
            {
                Console.WriteLine(e); //instead throw user defined exception
            }
            finally
            {

                con.Close();
            }
        }

        internal void Updatecourse()
        {
            throw new NotImplementedException();
        }


        public void AllStudent_Info()
        {
            try
            {
                con = getConnection();
                cmd = new SqlCommand("Select * from tblStudents", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Student Id : " + dr[0] + " " + "Student Name : " + dr[1] + " " + "Student DOB : " + dr[2]);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }


        public void Update_Student_Info()
        {
            try
            {
                Console.WriteLine(" Please Enter the Student id :");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter the Student Name :");
                string name = Console.ReadLine();
                Console.WriteLine("Please Enter the Student DOB :");
                string dob = Console.ReadLine();
                con = getConnection();
                cmd = new SqlCommand("update tblStudents set StudentName=@studentname,StudentDOB=@studentdob where StudentId=@studentId", con);
                cmd.Parameters.AddWithValue("@studentId", id);
                cmd.Parameters.AddWithValue("@studentname", name);
                cmd.Parameters.AddWithValue("@studentdob", dob);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Data Updated successfully");
                }
                else
                {
                    Console.WriteLine("Data Not Updated");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void DeleteS_tudent_Info()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("Data Enter The student Id :");
                int id = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("delete tblStudents where StudentId=@studentid", con);
                cmd.Parameters.AddWithValue("@studentid", id);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    Console.WriteLine("Data Delete Successfully");
                else
                    Console.WriteLine("Data Not Deleted");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void Particular_Student_Info()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("Data Enter The Student Id :");
                int id = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("select * from tblStudents where StudentId =@studentid", con);
                cmd.Parameters.AddWithValue("@studentid", id);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Student Id : " + dr[0] + " " + "Student Name : " + dr[1] + " " + "Student DOB : " + dr[2]);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }
        public void AllCourses_Lists()
        {
            try
            {
                con = getConnection();
                cmd = new SqlCommand("select * from tblCourses", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Course Id : " + dr[0] + " Course Name : " + dr[1] + " Course Duration : " + dr[2] + " " + "days," + " Course Fees : " + dr[3]);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void Particular_Course_Info()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("Data Enter The Course Id ");
                int id = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("select * from tblCourses where CourseId=@Courseid", con);
                cmd.Parameters.AddWithValue("@Courseid", id);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Course Id : " + dr[0] + " Course Name : " + dr[1] + " Course Duration : " + dr[2] + " Course Fees : " + dr[3]);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }


        public void updatestudent_Course_Info()
        {
            try
            {
                Console.WriteLine("Data Enter the Course id :");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Data Enter The Course Name :");
                string name = Console.ReadLine();
                Console.WriteLine("Data Enter the Course Duration :");
                int duration = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Data Enter the Course Fees :");
                float fee = Convert.ToSingle(Console.ReadLine());
                con = getConnection();
                cmd = new SqlCommand("update tblCourses set Courseduration=@Courseduration,coursename=@coursename,Coursefees=@Coursefees where CourseId=@Courseid", con);
                cmd.Parameters.AddWithValue("@Courseid", id);
                cmd.Parameters.AddWithValue("@Coursename", name);
                cmd.Parameters.AddWithValue("@Courseduration", duration);
                cmd.Parameters.AddWithValue("@Coursefees", fee);
                int res1 = cmd.ExecuteNonQuery();
                if (res1 > 0)
                {
                    Console.WriteLine("Data Updated successfully");
                }
                else
                {
                    Console.WriteLine("Data Not Updated");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void Deletestudent_Course_Info()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("Data Enter The Course Id :");
                int id = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("delete tblCourses where CourseId=@courseid", con);
                cmd.Parameters.AddWithValue("@courseid", id);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    Console.WriteLine("Data Delete Successfully");
                else
                    Console.WriteLine("Data Not Deleted");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void InsetStudent_Course_Info()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("Data Enter The Course Id :");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Data Enter The Course Name :");
                string name = Console.ReadLine();
                Console.WriteLine("Data Data Enter the Course Duration : ");
                int dur = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Data Enter The Couration Fees : ");
                float fee = Convert.ToSingle(Console.ReadLine());
                cmd = new SqlCommand("insert into tblCourses values(@CourseId,@CourseName,@Courseduration,@Coursefees)", con);
                cmd.Parameters.AddWithValue("@CourseId", id);
                cmd.Parameters.AddWithValue("CourseName", name);
                cmd.Parameters.AddWithValue("@Courseduration", dur);
                cmd.Parameters.AddWithValue("@Coursefees", fee);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Data Inserted successfully");
                }
                else
                {
                    Console.WriteLine("Data Not Inserted");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void Enrollstudent_Info()
        {
            try
            {
                con = getConnection();

                Console.WriteLine("Data Enter the Course id :");
                int Id1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Data Enter the Student Id :");
                int Id = Convert.ToInt32(Console.ReadLine());
                DateTime Enrolldate = DateTime.UtcNow;
                cmd = new SqlCommand("insert into tblEnrollDetails values(@Courseid,@StudentId,@EnrollDate)", con);
                cmd.Parameters.AddWithValue("@Courseid", Id1);
                cmd.Parameters.AddWithValue("@StudentId", Id);
                cmd.Parameters.AddWithValue("@EnrollDate", Enrolldate);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Data Inserted Successfully");
                }
                else
                {
                    Console.WriteLine("Data Not Inserted ");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }
    }
}