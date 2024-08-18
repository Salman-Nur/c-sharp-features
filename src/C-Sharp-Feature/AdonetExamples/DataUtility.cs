using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdonetExamples
{
    public class DataUtility
    {

        private readonly string _connectionString;
        public DataUtility(string connectionString)
        {
            _connectionString = connectionString;
        }





        /// For Insert, Update , Delete 
        public void ExecuteCommand(string command, IList<(string key, object value)> parameters)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            using SqlCommand Command =  connection.CreateCommand();
            Command.CommandText = command;


            if (parameters != null && parameters.Count > 0)
            {
                foreach (var item in parameters)
                {
                    Command.Parameters.Add(new SqlParameter(item.key, item.value));
                }
            }

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            Command.ExecuteNonQuery();
        }




        
        /// For  read data
        public IList<Dictionary<string, object>> ReadData(string command, IList<(string key, object value)> parameters)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            using SqlCommand Command = connection.CreateCommand();
            Command.CommandText = command;


            if (parameters != null && parameters.Count > 0)
            {
                foreach (var item in parameters)
                {
                    Command.Parameters.Add(new SqlParameter(item.key, item.value));
                }
            }


            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }


            SqlDataReader reader = Command.ExecuteReader();

            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();

            while (reader.Read())
            {
                Dictionary<string, object> columns = new Dictionary<string, object>();
                foreach (var column in reader.GetColumnSchema())
                {
                    columns.Add(column.ColumnName, reader[column.ColumnName]);
                }
                rows.Add(columns);
            }
            return rows;
        }


    }
}

