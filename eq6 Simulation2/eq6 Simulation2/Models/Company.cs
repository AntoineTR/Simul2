using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LUJR.Helpers;

namespace LUJR.Models
{
    [TableName("Company.Company")]
    [PrimaryKey("ID")]
    public class Company : EntityWithDatabase
    {
        public Company() : base() { }

        public int ID { get; set; }
        public string Name { get; set; }
        public int ContactPersonID { get; set; }
        public int AddressID { get; set; }
    }

    public class CompanyDAL : PetaPocoDAL<Company> { }
}
