using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LUJR.Helpers
{

    public class EntityWithDatabase
    {
        protected Database DB;

        public EntityWithDatabase()
        {
            DB = new Database("Default");
        }
    }

}