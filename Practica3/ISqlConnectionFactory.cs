using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    internal interface ISqlConnectionFactory
    {
        DbConnection GetDbConnection(); 
    }

    class SqlServerConnectionFactory: ISqlConnectionFactory
    {
        private readonly string _connectionString;

        public SqlServerConnectionFactory(string connectionString) 
        {
            this._connectionString = connectionString;
        }

        public DbConnection GetDbConnection()
        {
            return new SqlConnection(this._connectionString);
        }

    }
}
