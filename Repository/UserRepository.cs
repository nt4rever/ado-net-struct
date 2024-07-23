using Domain.User.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserRepository : BaseRepository<User>
    {
        public override string TableName { get; set; } = "User";

        public override User PopulateRecord(SqlDataReader reader)
        {
            return new User
            {
                Id = reader.GetInt32(0),
                UserName = reader.GetString(1),
            };
        }
    }
}
