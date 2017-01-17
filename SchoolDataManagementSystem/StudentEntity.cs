using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;
using System.Data;

namespace SchoolDataManagementSystem
{
    class StudentEntity : IEntity
    {
        private List<NpgsqlParameter> insertParams;
        private List<NpgsqlParameter> deleteParams;
        private List<NpgsqlParameter> updateParams;
        public Dictionary<string, string> Parameters { get; set; }

        public StudentEntity()
        {
            insertParams = new List<NpgsqlParameter>();
            insertParams.Add(new NpgsqlParameter("@id", NpgsqlDbType.Bigint, 11, "id"));
            insertParams.Add(new NpgsqlParameter("@guardian1", NpgsqlDbType.Bigint, 11, "guardian1"));
            insertParams.Add(new NpgsqlParameter("@guardian2", NpgsqlDbType.Bigint, 11, "guardian2"));
            insertParams.Add(new NpgsqlParameter("@name", NpgsqlDbType.Varchar, 40, "name"));
            insertParams.Add(new NpgsqlParameter("@surname", NpgsqlDbType.Varchar, 40, "surname"));
            insertParams.Add(new NpgsqlParameter("@phone", NpgsqlDbType.Varchar, 12, "phone"));

            deleteParams = new List<NpgsqlParameter>();
            deleteParams.Add(new NpgsqlParameter("@id", NpgsqlDbType.Bigint, 11, "id"));
            deleteParams[0].SourceVersion = DataRowVersion.Original;

            updateParams = new List<NpgsqlParameter>();
            updateParams.Add(new NpgsqlParameter("@name", NpgsqlDbType.Varchar, 40, "name"));
            updateParams.Add(new NpgsqlParameter("@surname", NpgsqlDbType.Varchar, 40, "surname"));
            updateParams.Add(new NpgsqlParameter("@phone", NpgsqlDbType.Varchar, 12, "phone"));
            updateParams.Add(new NpgsqlParameter("@id", NpgsqlDbType.Bigint, 11, "id"));

            Parameters = new Dictionary<string, string>();
            Parameters.Add("id", string.Empty);
            Parameters.Add("guardian1", string.Empty);
            Parameters.Add("guardian2", string.Empty);
            Parameters.Add("name", string.Empty);
            Parameters.Add("surname", string.Empty);
            Parameters.Add("phone", string.Empty);
        }

        public DataRow FillNewRow(Dictionary<string, string> param, DataRow rowToFill)
        {
            rowToFill["ID"] = param["id"];
            rowToFill["guardian1"] = param["guardian1"];
            rowToFill["guardian2"] = param["guardian2"];
            rowToFill["name"] = param["name"];
            rowToFill["surname"] = param["surname"];
            rowToFill["phone"] = param["phone"];
            return rowToFill;
        }
        
        public void UpdateRow(Dictionary<string, string> param, DataRow rowToUpdate)
        {
            if (param["name"] != "" && param["name"] != string.Empty)
                rowToUpdate["name"] = param["name"];
            if (param["surname"] != "" && param["surname"] != string.Empty)
                rowToUpdate["surname"] = param["surname"];
            if (param["phone"] != "" && param["phone"] != string.Empty)
                rowToUpdate["phone"] = param["phone"];
        }

        public DataRow GetRowDefinedByKey(Dictionary<string, string> param, DataTable tableToSearch)
        {
            if (tableToSearch.PrimaryKey.Length == 0)
                tableToSearch.PrimaryKey = new DataColumn[] { tableToSearch.Columns["id"]};
            return tableToSearch.Rows.Find(param["id"]);
        }

        public string Delete
        {
            get
            {
                return "DELETE FROM pozv1904.Student WHERE id = @id";
            }
        }

        public string Insert
        {
            get
            {
                return "INSERT INTO pozv1904.Student VALUES (@id, @guardian1, @guardian2, @name, @surname, @phone)";
            }
        }

        public string Select
        {
            get
            {
                return "SELECT * FROM pozv1904.Student";
            }
        }

        public string Update
        {
            get
            {
                return "UPDATE pozv1904.Student SET name = @name, surname = @surname, phone = @phone WHERE id = @id";
            }
        }

        public List<NpgsqlParameter> InsertParameters
        {
            get
            {
                return insertParams;
            }
        }

        public List<NpgsqlParameter> UpdateParameters
        {
            get
            {
                return updateParams;
            }
        }

        public List<NpgsqlParameter> DeleteParameters
        {
            get
            {
                return deleteParams;
            }
        }

        public string TableName
        {
            get
            {
                return Entities.Student.ToString();
            }
        }
    }
}
