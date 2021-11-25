using System;
using System.Collections.Generic;
//rp
namespace Program_List_Employee
{

/*    Write a program in C# to accept list of employees and 
    print list of employees.
    (using generic collection)
*/

    class Emp
    {
       public int id;
     public   string name;
        public Emp(int id, string name)
        {
            this.id = id;
            this.name = name;

        }
    }


    class Program
    {
        static void Main(string[] args)
        {



        List<Emp> listEmp = new List<Emp>();

/*            listEmp.Add(new Emp(1,"Employee_1"));
            listEmp.Add(new Emp(2, "Employee_2"));
            listEmp.Add(new Emp(3, "Employee_3"));*/


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("enter roll_no and name --");
                int a = Convert.ToInt32(Console.ReadLine());
                string b = Console.ReadLine();
                Emp e = new Emp(a,b);
                listEmp.Add(e);
            }


            for (int i=0;i<listEmp.Count;i++)
            {
                Emp e = listEmp[i];
                Console.WriteLine(e.id+" - "+e.name);
                Console.WriteLine("\n-------------");
            }


            Console.ReadKey();
        }
    }
    //24
}
