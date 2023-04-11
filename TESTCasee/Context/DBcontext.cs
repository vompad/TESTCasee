using MySqlConnector;
using System.Data;
using System.Data.Common;

namespace TESTCasee.Context
{
    public class DBcontext
    {
        public IDbConnection connection { get; set; }
        
        public DBcontext(IConfiguration configuration)
        {
            connection = new MySqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connection.Open();
        }
    }

}
