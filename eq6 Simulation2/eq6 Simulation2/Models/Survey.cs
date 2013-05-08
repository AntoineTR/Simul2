using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LUJR.Helpers;

namespace LUJR.Models
{
    [TableName("Survey.Survey")]
    [PrimaryKey("ID")]
    public class Survey : EntityWithDatabase
    {
        public Survey() : base() { }

        public int ID { get; set; }
        public int CompanyID { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }

    public class SurveyDAL : PetaPocoDAL<Survey> { }
}
