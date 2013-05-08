using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LUJR.Helpers;
using System.Data.SqlClient;

namespace LUJR.Models
{
    [TableName("Employee.Employee")]
    [PrimaryKey("ID")]
    public class Employee: EntityWithDatabase
    {
        public Employee() : base() { }

        public int ID { get; set; }
        public int PersonID { get; set; }
    }

    public class EmployeeDAL : PetaPocoDAL<Employee> {
        public static bool UsernameExists(string pUsername) {
            DatabaseAccess tDA = new DatabaseAccess("Employee.Employee_SelectByUsername");
            tDA.AddParam("@Username", pUsername);
            SqlDataReader r = tDA.GetReader();
            if (r.Read() && (string)r["Username"] == pUsername)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        public static int Authenticate(string pUsername, string pPassword)
        {
            DatabaseAccess tDA = new DatabaseAccess("Employee.Employee_Authenticate");
            tDA.AddParam("@Username", pUsername);
            tDA.AddParam("@Password", pPassword);
            SqlDataReader r = tDA.GetReader();
            if (r.Read() && (string)r["Username"] == pUsername)
            {
                return (int)r["ID"];
            }
            else
            {
                return 0;
            }
        }
        public static string GetUsernameByID(int pID)
        {
            Employee e = Current.DB.FirstOrDefault<Employee>("WHERE ID=@0", pID);
            int personID = e.PersonID;

            Person p = PersonDAL.Current.DB.FirstOrDefault<Person>("WHERE ID=@0", personID);
            return p.FirstName + " " + p.LastName; 
        }
    }
}
