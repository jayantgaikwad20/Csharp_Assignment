using System;
using System.Data.SqlClient;
using System.Data;


namespace Program_1_Disconnected_SQL
{
    class Program
    {
        static void Main(string[] args)
        {
          
            try
            {
                SqlConnection con = new SqlConnection("Server=.;Database=CourseDB;trusted_connection=true");
                SqlCommand cmd = new SqlCommand("Select * from CourseTable", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable tab = ds.Tables[0];



             

                int choice;
                char ch;
                do
                {
                    Console.WriteLine(" 1. Show course ");
                    Console.WriteLine(" 2. Insert course ");
                    Console.WriteLine(" 3. UPdate course ");
                    Console.WriteLine(" 4. Delete course ");
                    Console.WriteLine("EnteR your choice");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {

                        case 1 :
                        

                            foreach (DataRow rp in tab.Rows)
                            {
                                Console.WriteLine(rp[0] + "\t" + rp[1]);
                            }
                            break;

                        case 2:
                            Console.WriteLine("Enter Id");
                            int id_2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Course Name");
                            string name_2 = Console.ReadLine();
                     
                            DataRow  row = tab.NewRow();
                            row["id"] = id_2;
                            row["name"] = name_2;
                            tab.Rows.Add(row);
                            adapter.Update(tab);
                            Console.WriteLine("Record inserted");
                            break;

                        case 3:

                            Console.WriteLine("Enter Id");
                            int id_3 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Course Name");
                            string name_3 = Console.ReadLine();
                            DataRow[] r_3 = tab.Select("id=" + id_3);
                            DataRow rowup = r_3[0];
                            rowup["name"] = name_3;
                            adapter.Update(tab);
                            Console.WriteLine("Record updated ");
                            break;


                        case 4:
                            Console.WriteLine("Enter Id");
                            int id_4 = Convert.ToInt32(Console.ReadLine());
                         
                            DataRow[] r_4 = tab.Select("id=" + id_4);
                            DataRow row_del = r_4[0];
                            //tab.Rows.Remove(row_del) ;
                            //adapter.Update(tab);
                            Console.WriteLine("Record updated ");
                                row_del.Delete();
                            adapter.Update(tab);
                            break;

                        default:
                            Console.WriteLine("Invalid Case");
                            break;
                    }

                    Console.WriteLine("Y / y to continue.rp");
                    ch = Convert.ToChar(Console.ReadLine());

                }
                while (ch == 'Y' || ch == 'y');
                Console.ReadLine();
            }

           
            catch(SqlException e)
            {
                Console.WriteLine("Catch block Sql Excepti.on.rp.  --" +e.Message);
            }

            Console.ReadKey();
        }
    }
}
