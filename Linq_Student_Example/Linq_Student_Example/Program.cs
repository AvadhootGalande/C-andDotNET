using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    int stu_id;
    string stu_dept;
    string stu_name;
    int stu_semester;


    static void Main(string[] args)
    {

        
        List<Student> stu = new List<Student>()
    {
          
        new Student{ stu_id = 101, stu_name = "bobby",
                     stu_dept = "CSE", stu_semester = 2 },
        new Student{ stu_id = 102, stu_name = "sravan",
                     stu_dept = "ECE", stu_semester = 1 },
        new Student{ stu_id = 103, stu_name = "deepu",
                     stu_dept = "EEE", stu_semester = 4},
    };

        
        IEnumerable<Student> Query = from student in stu
                                     where student.stu_id > 102
                                     select student;

        foreach (Student e in Query)
        {
            Console.WriteLine(e.ToString());
        }
    }
}