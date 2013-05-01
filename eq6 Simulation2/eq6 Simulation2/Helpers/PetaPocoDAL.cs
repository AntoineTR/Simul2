using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LUJR.Helpers
{

    public class PetaPocoDAL<T> where T:new()
    {
        #region Memb. Vars

        /// <summary>
        /// One time DB declaration
        /// </summary>
        private Database _DB;
        public Database DB { get { return _DB; } }

        /// <summary>
        /// Singleton
        /// </summary>
        private static PetaPocoDAL<T> _instance;
        public static PetaPocoDAL<T> Current { get {
            if (_instance == null)
                _instance = new PetaPocoDAL<T>();
            return _instance;
        } }

        #endregion
        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
	    public PetaPocoDAL()
	    {
            _DB = new Database("defaut");
	    }

        /// <summary>
        /// Constructor with altername connexion string
        /// </summary>
        public PetaPocoDAL(string pConnexionStringName)
        {
            _DB = new Database(pConnexionStringName);
        }
        
        #endregion
        #region Methods

        public T GetOne(int pId) 
        {
            return DB.SingleOrDefault<T>(pId);
        }

        public IEnumerable<T> GetAll()
        {
            return DB.Query<T>("");
        }

        public IEnumerable<T> Get(string pQuery, params object[] pParams)
        {
            return DB.Query<T>(pQuery, pParams);
        }

        public void Insert(T pObj)
        {
            DB.Insert(pObj);
        }

        public void Update(T pObj)
        {
            DB.Update(pObj);
        }

        public void Delete(T pObj)
        {
            DB.Delete(pObj);
        }

        #endregion
    }

}