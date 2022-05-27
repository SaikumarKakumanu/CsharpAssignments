using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class UserInterFace : Interface
    {
		public void showFirstScreen()
		{
			Console.WriteLine("Welcome to SMS(Student Mgmt. System) v1.0");
			Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin");
			Console.WriteLine("Enter your choice ( 1 or 2 ) : ");
			int op = Convert.ToInt32(Console.ReadLine());

			switch (op)
			{
				case 1:
					showStudentScreen();
					break;
				case 2:
					showAdminScreen();
					break;
			}
		}

		public void showStudentScreen()
        {

        }
		public void showAdminScreen()
        {

        }
		public void showAllStudentsScreen()
        {

        }
		public void showStudentRegistrationScreen() // Execute the register method of AppEngine class
		{

        }

		public void introduceNewCourseScreen()
        {

        }
		public void showAllCoursesScreen()
        {

        }
	}
}
