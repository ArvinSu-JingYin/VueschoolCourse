using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VueSchool_Test_DataAccessLayer.Providers.Implement
{
    public class DataBaseSetting_Provider
    {
        public string ConnectionString { get; set; }

        /// <summary>
        /// Initializes a new instance of the DataBaseSetting_Provider class.
        /// </summary>
        /// <param name="connectionString">The connection string to the database.</param>
        public DataBaseSetting_Provider(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
