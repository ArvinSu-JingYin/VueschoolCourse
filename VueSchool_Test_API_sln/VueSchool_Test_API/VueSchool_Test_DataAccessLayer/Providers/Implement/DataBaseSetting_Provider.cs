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

        public DataBaseSetting_Provider(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
