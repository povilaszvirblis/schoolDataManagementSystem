using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace SchoolDataManagementSystem
{
    public interface IEntity
    {
        string TableName { get; }
        string Select { get; }
        string Update { get; }
        string Delete { get; }
        string Insert { get; }

        List<NpgsqlParameter> UpdateParameters { get; }
        List<NpgsqlParameter> InsertParameters { get; }
        List<NpgsqlParameter> DeleteParameters { get; }
        
        Dictionary<string, string> Parameters { get; }

        DataRow FillNewRow(Dictionary<string, string> param, DataRow rowToFill);
        void UpdateRow(Dictionary<string, string> param, DataRow rowToUpdate);
        DataRow GetRowDefinedByKey(Dictionary<string, string> param, DataTable tableToSearch);
    }
}
