using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LUJR.Helpers; 

namespace eq6_Simulation2.Models
{
    [TableName("Employee.Employee")]
    [PrimaryKey("ID")]
    public class Employee: EntityWithDatabase
    {
        public Employee() : base() { }

        public int ID { get; set; }
        public int PersonID { get; set; }
    }

    public class EmployeeDAL : PetaPocoDAL<Employee> { }
}
