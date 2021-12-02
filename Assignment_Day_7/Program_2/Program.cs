using System;
using System.Data;
using System.Data.SqlClient;


namespace Program_2_Transcations
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.;Database=mvcDB;trusted_connection=true";
            con.Open();


            SqlTransaction tran = null;
            try
            {
                tran = con.BeginTransaction();
                SqlCommand cmd = new SqlCommand("Insert_Department", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = tran;
                cmd.Parameters.AddWithValue("empno", 101);
                cmd.Parameters.AddWithValue("empname", "emp_1");
                cmd.Parameters.AddWithValue("designation", "Mumbai");
                cmd.Parameters.AddWithValue("deptname", "ABC");

                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = new SqlCommand("InsertEmp", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Transaction = tran;
                cmd.Parameters.AddWithValue("empno", 102);
                cmd.Parameters.AddWithValue("empname", "emp_2");
                cmd.Parameters.AddWithValue("designation", "pune");
                cmd.Parameters.AddWithValue("deptname", "XYZ");

                cmd1.ExecuteNonQuery();
                tran.Commit();
                Console.WriteLine("Transaction completed successfully");
            }
            catch (SqlException ex)
            {
                tran.Rollback();
                Console.WriteLine("Transaction rolled back");
            }
            catch (Exception ex)
            {
                tran.Rollback();
                Console.WriteLine("Transaction rolled back");
            }
            finally
            {
                con.Close();
            }
            Console.ReadKey();
        }
    }
}
