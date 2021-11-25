using System;

namespace SecondDay_Assignment2_Inheritance
{


    class Employee
    {
        int empno;
        string ename;
        public Employee(int empno, string ename)
        {
            this.empno = empno;
            this.ename = ename;
            
        }
        public void empDetails()
        {
            Console.WriteLine(empno + " " + ename);
        }
    }
    class PEmp : Employee    
    {
        double basicSal,hra,da;


        public PEmp(int empno, string ename, double basicSal) : base(empno, ename) { 
            this.basicSal = basicSal;
        }
        public void displayPEmp()
        {
            base.empDetails();
            Console.WriteLine(basicSal);
            hra = basicSal * 0.5;
            da = basicSal * 0.2;
            Console.WriteLine(hra + " " +da );
            double total = hra + da + basicSal;
            Console.WriteLine("total sal - " +total);
        }

    }


    class WEmp : Employee 
    {
        double hours, amt;
      
        public WEmp(int empno, string ename,double hours, double amt) : base(empno, ename)                          //Parent class obejct is also created automatically
        {
            this.hours = hours;
            this.amt = amt;
        }
        public void WEmpDetails()
        {
            base.empDetails();
            double total = hours * amt; 
            Console.WriteLine("hours {0} * amt per hr. {1} = {2} rs",hours,amt,total);
   

        }

    }


    class Program
        {
            static void Main(string[] args)
            {
            PEmp p = new PEmp(1,"emp_1",20000);
            p.displayPEmp();


            WEmp w = new WEmp(2,"emp_2",2,400);
            w.WEmpDetails();

            Console.ReadKey();
            }
        }
    }