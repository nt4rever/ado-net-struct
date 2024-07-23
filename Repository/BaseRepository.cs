using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public abstract class BaseRepository<TEntity> where TEntity : class
    {
        private static SqlConnection _connection;
        public virtual string TableName { get; set; }

        public BaseRepository()
        {
            _connection = new SqlConnection("Server=.; Database=ShopEF; Integrated Security=True; TrustServerCertificate=True;");
        }

        public virtual TEntity PopulateRecord(SqlDataReader reader)
        {
            return null;
        }

        protected IEnumerable<TEntity> GetRecords(SqlCommand command)
        {
            var list = new List<TEntity>();
            command.Connection = _connection;
            _connection.Open();
            try
            {
                var reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                        list.Add(PopulateRecord(reader));
                }
                finally
                {
                    reader.Close();
                }
            }
            finally
            {
                _connection.Close();
            }
            return list;
        }

        public IEnumerable<TEntity> GetAll()
        {
            using var command = new SqlCommand($"SELECT * FROM [{TableName}]");

            return GetRecords(command);
        }
    }
}
