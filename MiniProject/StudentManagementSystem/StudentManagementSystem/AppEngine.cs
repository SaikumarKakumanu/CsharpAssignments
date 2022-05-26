using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class AppEngine
    {
        public void introduce(Course course)
        {
            Console.WriteLine(course.Id+" "+course.Name+" "+course.duration+" "+course.fees);
        }

        public void register(Student student)
        {
           
            Console.WriteLine(student.Id+" "+student.Name+" "+student.DOB);

        }

        public Student[] listOfStudents()
        {
            Student[] students = new Student[3]
            {
                new Student(1,"saikumar","28/05/2000"),
                new Student(2,"Saikrishna","23/06/1999"),
                new Student(3,"Venkat","25/08/1972")
            };

            return students;
        }

        public Course[] listOfCourses()
        {
            Course[] courses = new Course[3]
           {
                new Course(101,"Java",35,15000.00f),
                new Course(102,"DotNet",60,20000.00f),
                new Course(103,"Python",30,12000.00f)
           };
            return courses;
        }

        public void enroll(Student student, Course course)
        {
            Info info = new Info();
            info.display(student);
            info.display(course);
        }

        public Enroll[] listOfEnrollments()
        {
            Enroll[] enroll = new Enroll[3]
            {

              new Enroll(new Student(1, "saikumar", "28/05/2000"), new Course(101, "Java", 30, 15000.00f), Convert.ToDateTime(DateTime.Now)),
              new Enroll(new Student(2, "saikrishna", "23/06/1999"), new Course(102, "Dotnet", 60, 20000.00f), Convert.ToDateTime(DateTime.Now)),
              new Enroll(new Student(3, "venkat", "25/08/1972"), new Course(103, "Python", 30, 12000.00f), Convert.ToDateTime(DateTime.Now))
            };
            return enroll;
        }
    }
}
