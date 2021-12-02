using System;
using System.IO;
using System.Xml.Serialization;

namespace xml_seralization
{
    [Serializable]
    public class Employee
    {
        public int empno;
        public string ename;
        public string designation;
        [NonSerialized]
        public double salary;
        public Employee()
        {
        }

        public Employee(int empno, string ename, string designation, double salary)
        {
            this.empno = empno;
            this.ename = ename;
            this.designation = designation;
            this.salary = salary;
        }
        public override string ToString()
        {
            return "Employee No " + empno + " Employee name " + ename + " Designation " + designation + " salary " + salary;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("D:\\C#_Programs\\File_Handling\\Emp.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Employee e = new Employee(101, "emp_1", "dev", 5000);
            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            serializer.Serialize(fs, e);
            Console.WriteLine("object is serialized");
            Employee obj = (Employee)serializer.Deserialize(fs);
            Console.WriteLine(obj);
            Console.ReadKey();
        }
    }
}
