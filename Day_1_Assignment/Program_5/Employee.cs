using System;

namespace Employee
{
    class Employee
    {
        int empno;
        String ename;
        String des;

        public Employee(int empno,String ename,String des)
        {
            this.empno = empno;
            this.ename = ename;
            this.des = des;
        }
        public void display()
        {
            Console.WriteLine("employee no is  " + empno);
            Console.WriteLine("employee name is  " + ename);
            Console.WriteLine("employee designation is" + des);        
        }
        static void Main(string[] args)
        {
            Employee e = new Employee(1,"jayant","developer");
            e.display();


        }
    }
}
