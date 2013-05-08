using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LUJR.Helpers;

namespace LUJR.Models
{
    [TableName("Baboubine.Language")]
    [PrimaryKey("ID")]
    public class Language : EntityWithDatabase
    {
        public Language() : base() { }

        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class LanguageDAL : PetaPocoDAL<Language> { }
}
