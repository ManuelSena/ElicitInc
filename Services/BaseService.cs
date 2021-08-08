using DbAccess.DbAdapter;
using LinqToDB.DataProvider;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ElicitInc.Services
{
    public class BaseService
    {

        public IDataProvider DataProvider { get; set; }

        public DbAdapter Adapter
        {
            get
            {
                return new DbAdapter(new SqlCommand(),
                    new SqlConnection("Server=localhost\\SQLEXPRESS;" + "Initial Catalog = Project;" + "Integrated Security = True;"));

            }
        }

    }
}