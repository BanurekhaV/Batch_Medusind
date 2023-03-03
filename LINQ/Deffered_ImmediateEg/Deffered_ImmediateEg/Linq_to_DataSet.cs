using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Deffered_ImmediateEg
{
    class Linq_to_DataSet
    {
        static void Main()
        {
            SqlConnection con = new SqlConnection("Data Source=Laptop-TJJ7D977;Initial Catalog=MedusindDB;" +
                "Integrated Security=true;");
            string sqlstatment = "select * from Department;" + "select * from Employee;";

            //create a data adapter
            SqlDataAdapter da = new SqlDataAdapter(sqlstatment, con);

            //create table mappings for the relationship
            da.TableMappings.Add("Table", "Department");
            da.TableMappings.Add("Table1", "Employee");

            //create and fill the dataset
            DataSet ds = new DataSet();
            da.Fill(ds);

            //set the relationship
            DataRelation relation = ds.Relations.Add(
                ds.Tables["Department"].Columns[0],
                ds.Tables["Employee"].Columns[4]);

            //create datatable objects
            DataTable dep = ds.Tables["Department"];
            DataTable emp = ds.Tables["Employee"];

            //Linq Query Construction
            var queryres = from d in dep.AsEnumerable()
                           join e in emp.AsEnumerable()
                           on d.Field<int>("Deptid") equals
                           e.Field<int>("Deptid")
                           select new
                           {
                               EmployeeID=e.Field<int>("Empid"),
                               EmployeeName=e.Field<string>("Empname"),
                               DepartmentId=d.Field<int>("Deptid"),
                               DepartmentName=d.Field<string>("Deptname")
                           };
            foreach(var item in queryres)
            {
                Console.WriteLine("Id={0},\t Name={1},\t Dept ={2} and \t DeptName={3}",item.EmployeeID,
                    item.EmployeeName,item.DepartmentId,item.DepartmentName);
            }
            Console.Read();
        }
    }
}
