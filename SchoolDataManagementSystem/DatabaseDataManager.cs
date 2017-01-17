using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace SchoolDataManagementSystem
{
    class DatabaseDataManager
    {
        private string connectionString = "Server = server; Database = database; Port = 5432; User Id= userid; Password = pass;";
        private NpgsqlConnection cn;
        private NpgsqlDataAdapter adapter;
        private DataSet ds;
        private IEntity entity;

        public Dictionary<string, string> ParameterDictionary { get; set; }

        public DatabaseDataManager(IEntity dbEntity)
        {
            cn = new NpgsqlConnection(connectionString);
            entity = dbEntity;
            adapter = new NpgsqlDataAdapter(dbEntity.Select, cn);
            adapter.UpdateCommand = new NpgsqlCommand(dbEntity.Update, cn);
            adapter.InsertCommand = new NpgsqlCommand(dbEntity.Insert, cn);
            adapter.DeleteCommand = new NpgsqlCommand(dbEntity.Delete, cn);
            foreach (NpgsqlParameter parameter in entity.UpdateParameters)
                adapter.UpdateCommand.Parameters.Add(parameter);
            foreach (NpgsqlParameter parameter in entity.InsertParameters)
                adapter.InsertCommand.Parameters.Add(parameter);
            foreach (NpgsqlParameter parameter in entity.DeleteParameters)
                adapter.DeleteCommand.Parameters.Add(parameter);
            ParameterDictionary = entity.Parameters;
        }

        public bool PerformDelete(Dictionary<string, string> values)
        {
            DataRow rowToDelete;
            if (ds == null)
                PerformSelect();
            else
                cn.Open();
            rowToDelete = entity.GetRowDefinedByKey(values, ds.Tables[0]);
            ds.Tables[0].Rows[ds.Tables[0].Rows.IndexOf(rowToDelete)].Delete();
            try
            {
                adapter.Update(ds.Tables[0]);
            }
            catch(Exception)
            {
                return false;
            }
            finally
            {
                cn.Close();
            }
            return true;
        }

        public DataSet PerformSelect()
        {
            if(cn.State != ConnectionState.Open)
                cn.Open();
            ds = new DataSet();
            adapter.Fill(ds, "pozv1904" + entity.TableName);
            cn.Close();
            return ds;
        }

        public bool PerformUpdate(Dictionary<string, string> values)
        {
            DataRow rowToUpdate;
            if (ds == null)
                PerformSelect();
            else
                cn.Open();
            rowToUpdate = entity.GetRowDefinedByKey(values, ds.Tables[0]);
            entity.UpdateRow(values, ds.Tables[0].Rows[ds.Tables[0].Rows.IndexOf(rowToUpdate)]);
            try
            {
                adapter.Update(ds.Tables[0]);
            }
            catch(Exception)
            {
                return false;
            }
            finally
            {
                cn.Close();
            }
            return true;
        }

        public bool PerformInsert(Dictionary<string, string> values)
        {
            DataRow newRow;
            if (ds == null)
                PerformSelect();
            else
                cn.Open();
            newRow = ds.Tables[0].NewRow();
            entity.FillNewRow(values, newRow);
            ds.Tables[0].Rows.Add(newRow);
            try
            {
                adapter.Update(ds.Tables[0]);
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                cn.Close();
            }
            return true;
        }
    }
}
