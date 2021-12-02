using System;
using System.Data;
using System.Data.SqlClient;


/*
*
*   
* 
*
*/

namespace Connected_SQL
{
    class SqlDAL
    {
        public SqlDataReader GetDepartment()
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=DepartmentDB;Trusted_Connection=true";

                con.Open();

                SqlCommand cmd = new SqlCommand("GetDeptData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();
            }
            catch (SqlException se)
            {
                Console.WriteLine("Exception from GetDepartment -- "+se.Message);
            }

            return reader;
        }

        public int InsertDepartment(int deptno, string dname, string location)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=DepartmentDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("InsertDepartment", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("DeptNo", deptno);
                SqlParameter p2 = new SqlParameter("DeptName", dname);
                SqlParameter p3 = new SqlParameter("DeptLocation", location);
               
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);

                no = cmd.ExecuteNonQuery();
                con.Close();

            }

            catch (SqlException ex)
            {
                Console.WriteLine("Exception for InsertDeptment" + ex.Message);
            }
            return no;
        }

        public int UpdateDepartment(int deptno, string dname, string location)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=DepartmentDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("UpdateDepartment", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("DeptNo", deptno);
                SqlParameter p2 = new SqlParameter("DeptName", dname);
                SqlParameter p3 = new SqlParameter("DeptLocation", location);

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);

                no = cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception from UpdateDepartment --- " + ex.Message);
            }
            return no;
        }

        public int DeleteDepartment(int deptno)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=DepartmentDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("DeleteDepartment", con);
                //CTA = P("1234");
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.AddWithValue("DeptNo", deptno);
                no = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception  from DeleteDepartment -- " + ex.Message);
            }
            return no;
        }


        public SqlDataReader GetEmployee()
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=DepartmentDB;Trusted_Connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("GetEmpData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();
            }
            catch (SqlException se)
            {
                Console.WriteLine("Exception from EmpDepartment -- " + se.Message);
            }

            return reader;
        }

        public int InsertEmployee(int EmpNo, string EmpName, string Designation, decimal Salary, int DeptNo)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=DepartmentDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("InsertEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("EmpNo", EmpNo);
                SqlParameter p2 = new SqlParameter("EmpName", EmpName);
                SqlParameter p3 = new SqlParameter("Designation", Designation);
                SqlParameter p4 = new SqlParameter("Salary", Salary);
                SqlParameter p5 = new SqlParameter("DeptNo", DeptNo);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                no = cmd.ExecuteNonQuery();
                con.Close();

            }

            catch (SqlException ex)
            {
                Console.WriteLine("Exception for InsertEmployee" + ex.Message);
            }
            return no;
        }

        public int UpdateEmployee(int EmpNo, string EmpName, string Designation,decimal Salary, int DeptNo)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=DepartmentDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("UpdateDepartment", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("EmpNo", EmpNo);
                SqlParameter p2 = new SqlParameter("EmpName", EmpName);
                SqlParameter p3 = new SqlParameter("Designation", Designation);
                SqlParameter p4 = new SqlParameter("Salary", Salary);
                SqlParameter p5 = new SqlParameter("DeptNo", DeptNo);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);

                no = cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception from UpdateEmployee --- " + ex.Message);
            }
            return no;
        }

        public int DeleteEmployee(int EmpNo)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=DepartmentDB;trusted_connection=true";
                // CTA;
                con.Open();

                SqlCommand cmd = new SqlCommand("DeleteEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("EmpNo", EmpNo);
                no = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception  from DeleteEmployee -- " + ex.Message);
            }
            return no;
        }



























    }





















    class Department
    {
        SqlDAL dal = new SqlDAL();
        public int DeptNo{get;set;}

        public string DeptName{get;set;}

        public string DeptLocation{get;set;}
        public int EmpNo { get;  set; }
        public string EmpName { get;  set; }
        public string Designation { get;  set; }
        public object Salary { get;  set; }

        public void DisplayDepartmentData()
        {
            SqlDataReader reader = dal.GetDepartment();
          
            while (reader.Read())
            {
                Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2]+"\t");
            }
        }

     

        public void InsertDepartment()
        {
            int no = dal.InsertDepartment(DeptNo, DeptName, DeptLocation);
            if (no > 0)
            {
                Console.WriteLine("Dept Inserted Successfully");
            }
        }
        public void UpdateDepartment()
        {
            int no = dal.UpdateDepartment(DeptNo, DeptName, DeptLocation);
            if (no > 0)
            {
                Console.WriteLine("Data Updated Successfully");
            }
        }

        public void DeleteDepartment()
        {
            int no = dal.DeleteDepartment(DeptNo);
            if (no > 0)
            {
                Console.WriteLine("Data Deleted Successfully");
            }
        }

        public void DisplayEmployeeData()
        {
            SqlDataReader reader = dal.GetEmployee();

            while (reader.Read())
            {
                Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2] + "\t" + reader[3] + "\t" + reader[4]);
            }
        }



        public void InsertEmployee()
        {
            int no = dal.InsertEmployee(EmpNo, EmpName, Designation, (decimal)Salary, DeptNo);
            if (no > 0)
            {
                Console.WriteLine("Dept Inserted Successfully");
            }
        }
        public void UpdateEmployee()
        {
            int no = dal.UpdateEmployee(EmpNo, EmpName, Designation, (decimal)Salary,DeptNo);
            if (no > 0)
            {
                Console.WriteLine("Data Updated Successfully");
            }
        }

        public void DeleteEmployee()
        {
            int no = dal.DeleteEmployee(EmpNo);
            if (no > 0)
            {
                Console.WriteLine("Data Deleted Successfully");
            }
        }





    }









    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            char ch;

            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine(" 1. Show Departments ");
                Console.WriteLine(" 2. Insert Department ");
                Console.WriteLine(" 3. Update Department ");
                Console.WriteLine(" 4. Delete Department ");
                Console.WriteLine(" 5. Show Employee ");
                Console.WriteLine(" 6. Insert Emplyoee ");
                Console.WriteLine(" 7. Update Employee ");
                Console.WriteLine(" 8. Delete Employee ");
                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Department d = new Department();
                        d.DisplayDepartmentData();
                        break;
  
                    case 2:
                        Department d2 = new Department();
                        Console.WriteLine("Enter Department Details to Enter DeptNo,DeptName,DeptLocation");
                        d2.DeptNo = Convert.ToInt32(Console.ReadLine());
                        d2.DeptName = Console.ReadLine();
                        d2.DeptLocation = Console.ReadLine();
                        d2.InsertDepartment();
                        break;

                    case 3:
                        Department d3 = new Department();
                        Console.WriteLine("Enter Department Details to Update Deptno,DeptName,DeptLocation");
                        d3.DeptNo = Convert.ToInt32(Console.ReadLine());
                        d3.DeptName = Console.ReadLine();
                        d3.DeptLocation = Console.ReadLine();
                        d3.UpdateDepartment();
                        break;

                    case 4:
                        Department d4 = new Department();
                        Console.WriteLine("Enter Department no to delete");
                        d4.DeptNo = Convert.ToInt32(Console.ReadLine());
                        d4.DeleteDepartment();
                        break;

                    case 5:
                        Department d5 = new Department();
                        d5.DisplayEmployeeData();
                        break;

                    case 6:
                        Department d6 = new Department();
                        Console.WriteLine("Enter employee Details to Enter emp no,name ,designation,sal, dept no");
                        d6.EmpNo = Convert.ToInt32(Console.ReadLine());
                        d6.EmpName = Console.ReadLine();
                        d6.Designation = Console.ReadLine();
                        d6.Salary = Convert.ToDecimal(Console.ReadLine());
                        d6.DeptNo = Convert.ToInt32(Console.ReadLine());
                      
                        d6.InsertEmployee();
                        break;

                    case 7:
                        Department d7 = new Department();
                        Console.WriteLine("Enter Emp Details to Update emp no,Name,Designation, sal, dept no");
                        d7.EmpNo = Convert.ToInt32(Console.ReadLine());
                        d7.EmpName = Console.ReadLine();
                        d7.Designation = Console.ReadLine();
                        d7.Salary = Convert.ToDecimal(Console.ReadLine());
                        d7.DeptNo = Convert.ToInt32(Console.ReadLine());

                        d7.UpdateEmployee();
                        break;

                    case 8:
                        Department d8 = new Department();
                        Console.WriteLine("Enter Emp no to delete");
                        d8.EmpNo = Convert.ToInt32(Console.ReadLine());
                        d8.DeleteEmployee();
                        break;

                    default:
                        Console.WriteLine("Invalid Case");
                        break;
                }

                Console.WriteLine("press Y to continue");
                ch = Convert.ToChar(Console.ReadLine());

            }
            while (ch == 'Y' || ch == 'y');
            Console.ReadLine();
        }
    }
}
