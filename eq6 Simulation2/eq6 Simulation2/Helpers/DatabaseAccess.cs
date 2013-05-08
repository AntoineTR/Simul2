using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LUJR.Helpers
{
    public class DatabaseAccess
    {
        #region Attributs

        protected string mConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["defaut"].ConnectionString;
        protected SqlConnection mConnection;
        protected SqlCommand mCommand;

        #endregion Attributs
        #region Propriétées

        public string ConnectionString
        {
            get { return mConnectionString; }
            set { mConnectionString = value; }
        }
        public SqlConnection Connection
        {
            get 
            {
                return mConnection;    
            }
        }
        public SqlCommand Command
        {
            get
            {
                return mCommand;
            }
        }

        #endregion Propriétées
        #region Constructeurs

        public DatabaseAccess() : this("", null) { }
        public DatabaseAccess(string pCommandText) : this(pCommandText, null) {}
        public DatabaseAccess(string pCommandText, SqlConnection pConnextion)
        {
            if (pConnextion == null)
                mConnection = new SqlConnection(ConnectionString);
            else
                mConnection = pConnextion;
            mCommand = new SqlCommand(pCommandText, mConnection);
            mCommand.CommandType = CommandType.StoredProcedure;
        }

        #endregion Constructeurs
        #region Méthodes
        #region Generic

        public void AddParam(string pParamName, object pParamValue) 
        { 
            AddParam(new SqlParameter(pParamName, pParamValue)); 
        }
        public void AddParam(string pParamName, object pParamValue, DbType pDataType) 
        {
            SqlParameter tmpP = new SqlParameter(pParamName, pDataType);
            tmpP.Value = pParamValue;
            AddParam(tmpP);
        }
        public void AddParam(string pParamName, object pParamValue, SqlDbType pDataType, byte pPrecision, byte pScale)
        {
            SqlParameter tmpP = new SqlParameter(pParamName, pDataType);
            tmpP.Precision = pPrecision;
            tmpP.Scale = pScale;
            tmpP.Value = pParamValue;
            AddParam(tmpP);
        }
        public void AddParam(SqlParameter pParam) 
        {
            if (mCommand == null)
                throw new Exceptions.DatabaseAccessException("Cannot add param when Command is null.");
            mCommand.Parameters.Add(pParam);
        }
        public void Dispose()
        {
            mCommand.Dispose();
            mCommand = null;
            if (mConnection.State != ConnectionState.Closed)
                mConnection.Close();
            mConnection.Dispose();
            mConnection = null;
        }

        #endregion Generic
        #region Get

        /// <summary>
        /// Execute command using ExecuteReader
        /// </summary>
        /// <returns>SqlDataReader Object Filled with command result</returns>
        public SqlDataReader GetReader()
        {
            SqlDataReader tReader;
            /*try
            {*/
                mConnection.Open();
                tReader = mCommand.ExecuteReader();
            /*}
            catch (ApplicationException ex)
            {
                Dispose();
                throw new Exceptions.DatabaseAccessException(ex.Message);
            }
            finally
            {
                //Dispose();
            }*/
            return tReader;
        }

        #endregion
        #region Others

        /// <summary>
        /// Executes the command by calling ExecuteNonQuery not returning anything
        /// </summary>
        public void Execute() 
        {
            /*try
            {*/
                mConnection.Open();
                mCommand.ExecuteNonQuery();
            /*}
            catch (ApplicationException ex)
            {
                throw new Exceptions.DatabaseAccessException(ex.Message);
            }
            finally
            {
                Dispose();
            }*/
        }
        public void DoDelete() 
        {
            // TODO : Add logging
            try
            {
                mConnection.Open();
                mCommand.ExecuteNonQuery();
            }
            catch (ApplicationException ex)
            {
                throw new Exceptions.DatabaseAccessException(ex.Message);
            }
            finally
            {
                mConnection.Close();
            }
        }
        public void DoSave()
        {
            // TODO : Add logging
            try
            {
                mConnection.Open();
                mCommand.ExecuteNonQuery();
            }
            catch (ApplicationException ex)
            {
                throw new Exceptions.DatabaseAccessException(ex.Message);
            }
            finally
            {
                mConnection.Close();
            }
        }
        public int DoAdd()
        {
            // TODO : Add logging
            int tResult;
            try
            {
                mConnection.Open();
                string tmpDBG = mCommand.ExecuteScalar().ToString();
                if (!int.TryParse(tmpDBG, out tResult))
                    throw new ApplicationException("Command returned invalid scalar when inserting.");
            }
            catch (ApplicationException ex)
            {
                throw new Exceptions.DatabaseAccessException(ex.Message);
            }
            finally
            {
                mConnection.Close();
            }
            return tResult;
        }

        #endregion
        #endregion Méthodes
    }
}
