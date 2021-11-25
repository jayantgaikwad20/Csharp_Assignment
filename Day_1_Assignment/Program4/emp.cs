using System;

namespace EmployeeArray
{
    class emp
    {
        int empNo1;
        string empName1;
        string designation1;
        int salary1;

        public emp()
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
        static void Main(string[] args)
        {
            emp[] e = new emp[1];
            for (int i = 0; i < e.Length; i++)
            {
                e[i] = new emp();
            }

            foreach (emp k in e)
            {
                Console.WriteLine("EmpNo:" + k.empNo1 + " EmpName:" + k.empName1 + " Desg:" + k.designation1 + " Salary:Rs." + k.salary1);
            }
        }
    }
}
