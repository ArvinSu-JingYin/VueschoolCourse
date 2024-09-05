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

        /// <summary>
        /// Get a list of root objects from the VusSchool_Rootobject table
        /// </summary>
        /// <returns>Returns a collection of VusSchool_Rootobject_DTOModel</returns>
        /// <remarks>
        /// This method retrieves data from the VusSchool_Rootobject table using Dapper
        /// and maps it to a collection of VusSchool_Rootobject_DTOModel.
        /// </remarks>
        public IEnumerable<VusSchool_Rootobject_DTOModel> GetVusSchoolRootobjectList(string num)
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
                sql.Append("WHERE 1 = 1" + Environment.NewLine);
                sql.Append("    AND Id = @Id" + Environment.NewLine);

                return conn.Query<VusSchool_Rootobject_DTOModel>(sql.ToString(), new { Id = num });
            }
        }
    }
}
