using System;
//Rushikesh Patil
namespace ThirdDay_Assignment3_Program3_Interface
{


   /*   Rushikesh Patil 
    *   
    *   Program 3 -->
    *   
    *   Create interface with name IPrintable and print method.implement
        interface in Account and employee class. 
        Verify in main class and check working.*/

    interface IPrintable
    {
        void print();
    }

    class Account : IPrintable
    {
        string acc_Type="Saving";
         public void print()
        {
            Console.WriteLine("Account class Print method");
         //   Console.WriteLine(acc_Type);
        }
    }


    class Employee : IPrintable
    {
        string Emp_Type = "Permanent";
        public void print()
        {
            Console.WriteLine("Employee class Print method");
          //  Console.WriteLine(Emp_Type);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new Account().print();

            new Employee().print();

            Console.ReadKey();
        }
    }
}
