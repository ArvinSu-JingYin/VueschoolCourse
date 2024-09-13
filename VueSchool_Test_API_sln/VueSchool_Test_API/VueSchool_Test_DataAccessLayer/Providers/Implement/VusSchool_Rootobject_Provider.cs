using System.Text;
using VueSchool_Test_DataAccessLayer.DataModel.DTO;
using System.Data.SqlClient;
using Dapper;
using VueSchool_Test_DataAccessLayer.Providers.Interface;
using VueSchool_Test_DataAccessLayer.DataModel;
using System.Text.RegularExpressions;
using System.Xml.Linq;

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
        public IEnumerable<VusSchool_Rootobject_DTOModel> GetVusSchoolRootobjectList(APISearchDataDto dto)
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
                sql.Append("    AND slug = @slug" + Environment.NewLine);

                return conn.Query<VusSchool_Rootobject_DTOModel>(sql.ToString(),
                                                                 new { Id = dto.id, slug = dto.slug });
            }
        }

        public Dictionary<int, string?> VusSchoolNav()
        {
            using (var conn = new SqlConnection(_connectString)) {
            
                StringBuilder sql = new StringBuilder();

                sql.Append("SELECT" + Environment.NewLine);
                sql.Append("    Id," + Environment.NewLine);
                sql.Append("    name" + Environment.NewLine);
                sql.Append("FROM VusSchool_Rootobject" + Environment.NewLine);
                sql.Append("GROUP BY" + Environment.NewLine);
                sql.Append("    Id," + Environment.NewLine);
                sql.Append("    name" + Environment.NewLine);

                return conn.Query<VusSchool_Rootobject_DTOModel>(sql.ToString()).ToDictionary(k => k.Id, v => v.name);
            }
        }
    }
}
