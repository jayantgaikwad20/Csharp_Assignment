using System;

namespace SecondDay_Assignment2_EmpArray
{
    class Employee
    {
    int empNo1;
    string empName1;
    string designation1;
    int salary1;

    public Employee()
    {
        Console.WriteLine("Enter emp no");
        empNo1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter emp name");
        empName1 = Console.ReadLine();

        Console.WriteLine("Enter emp desg");
        designation1 = Console.ReadLine();

        Console.WriteLine("Enter emp salary");
        salary1 = Convert.ToInt32(Console.ReadLine());
    }

    public static void Main(string[] args)
    {
            Employee[] emp = new Employee[2];
        for (int i = 0; i < emp.Length; i++)
        {
            emp[i] = new Employee();
        }

        foreach (Employee e in emp)
        {
            Console.WriteLine("EmpNo:" + e.empNo1 + " EmpName:" + e.empName1 + " Desg:" + e.designation1 + " Salary:Rs." + e.salary1);
        }
    }

}
}
