using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VueSchool_Test_DataAccessLayer.DataModel.DTO;
using System.Data.SqlClient;
using Dapper;
using VueSchool_Test_DataAccessLayer.Providers.Interface;

namespace VueSchool_Test_DataAccessLayer.Providers.Implement
{
    public class VusSchool_Rootobject_Provider : IVusSchool_Rootobject_Provider
    {
        private readonly string _connectString;

        public VusSchool_Rootobject_Provider(DataBaseSetting_Provider connectString)
        {
            _connectString = connectString.ConnectionString;
        }

        public IEnumerable<VusSchool_Rootobject_DTOModel> GetVusSchoolRootobjectList()
        {
            using (var conn = new SqlConnection(_connectString))
            {

                StringBuilder sql = new StringBuilder();

                sql.Append("SELECT" + Environment.NewLine);
                sql.Append("    Id" + Environment.NewLine);
                sql.Append("    ,name" + Environment.NewLine);
                sql.Append("    ,slug" + Environment.NewLine);
                sql.Append("    ,image" + Environment.NewLine);
                sql.Append("    ,description" + Environment.NewLine);
                sql.Append("FROM VusSchool_Rootobject" + Environment.NewLine);

                return conn.Query<VusSchool_Rootobject_DTOModel>(sql.ToString());
            }
        }
    }
}
