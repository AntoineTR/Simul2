using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LUJR.Helpers; 

namespace eq6_Simulation2.Models
{
    [TableName("Baboubine.Person")]
    [PrimaryKey("ID")]
    public class Person : EntityWithDatabase
    {
        public Person() : base() { }

        public int ID { get; set; }
        public string FirstName {get; set;}
        public string LastName { get; set; }
        public string Phone { get; set; }
        public int LanguageID { get; set; }
    }

    public class PersonDAL : PetaPocoDAL<Person> { }
}
