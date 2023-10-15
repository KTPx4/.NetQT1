using System;
using System.Collections.Generic;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform.Connections
{
    public class Connection
    {
        public  string GetConnectionString()
        {
            
            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();
            sqlBuilder.DataSource = @"PX4\SQLEXPRESS";
            sqlBuilder.InitialCatalog = "QT1";
            sqlBuilder.MultipleActiveResultSets = true;
            sqlBuilder.IntegratedSecurity = true;
            sqlBuilder.ApplicationName = "EntityFramework";
            EntityConnectionStringBuilder efBuilder = new EntityConnectionStringBuilder();
            efBuilder.Metadata = "res://*/Model.csdl|res://*/Model.ssdl|res://*/Model.msl";
            efBuilder.Provider = "System.Data.SqlClient";
            efBuilder.ProviderConnectionString = sqlBuilder.ConnectionString;
            return efBuilder.ConnectionString;
        }
    }
}
