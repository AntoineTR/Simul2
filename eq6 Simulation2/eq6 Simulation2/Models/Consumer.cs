using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LUJR.Helpers;

namespace LUJR.Models
{
    [TableName("Survey.Consumer")]
    [PrimaryKey("ID")]
    public class Consumer : EntityWithDatabase
    {
        public Consumer() : base() { }

        public int ID { get; set; }
        public int PersonID { get; set; }
        public string ItemNameBought { get; set; }
        public int SurveyID { get; set; }
    }

    public class ConsumerDAL : PetaPocoDAL<Consumer> { }
}
