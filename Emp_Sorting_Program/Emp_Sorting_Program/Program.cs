
using System;
using System.Linq;
using System.Collections.Generic;

class Geek
{

    int emp_id;
    string Emp_Name;
    int Emp_Salary;
    string Emp_Department;

    static void Main(string[] args)
    {

        List<Geek> Geeks = new List<Geek>()
    {
        new Geek{emp_id = 101, Emp_Name = "Amit",
                Emp_Salary = 50000,Emp_Department = "XYZ"},
        new Geek{emp_id = 102, Emp_Name = "Poonam",
                Emp_Salary = 65000,Emp_Department = "ABC"},
        new Geek{emp_id = 103, Emp_Name = "Priya",
                Emp_Salary = 45000,Emp_Department = "ABC"},
        new Geek{emp_id = 104, Emp_Name = "Sita",
                Emp_Salary = 20000,Emp_Department = "XYZ"},
        new Geek{emp_id = 105, Emp_Name = "kiran",
                Emp_Salary = 70000,Emp_Department = "ABC"},
        new Geek{emp_id = 106, Emp_Name = "Sohan",
                Emp_Salary = 40000,Emp_Department = "XYZ"},
    };

        
        var result_set = Geeks.Where(emp => emp.Emp_Department == "XYZ").OrderByDescending(
                                    sal => sal.Emp_Salary);

        
        foreach (Geek emp in result_set)
        {
            Console.WriteLine(emp.emp_id + " " +
                            emp.Emp_Name + " " +
                            emp.Emp_Salary + " " +
                            emp.Emp_Department);
        }
    }
}
