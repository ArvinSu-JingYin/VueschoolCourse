using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VueSchool_Test_DataAccessLayer.DataModel;
using VueSchool_Test_DataAccessLayer.DataModel.DTO;
using VueSchool_Test_DataAccessLayer.Providers.Interface;

namespace VueSchool_Test_DataAccessLayer.Providers.Implement
{
    public class VusSchool_Experience_Provider : IVusSchool_Experience_Provider
    {
        private readonly string _connectString;

        public VusSchool_Experience_Provider(DataBaseSetting_Provider connectString)
        {
            _connectString = connectString.ConnectionString;
        }

        /// <summary>
        /// Get a list of experiences from the VusSchool_Experience table
        /// </summary>
        /// <returns>Returns a collection of VusSchool_Experience_DTOModel</returns>
        /// <remarks>
        /// This method retrieves data from the VusSchool_Experience table using Dapper
        /// and maps it to a collection of VusSchool_Experience_DTOModel.
        /// </remarks>
        public IEnumerable<VusSchool_Experience_DTOModel> GetVusSchoolExperienceList(APISearchDataDto dto)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("SELECT" + Environment.NewLine);
            sql.Append("    Id" + Environment.NewLine);
            sql.Append("    ,name" + Environment.NewLine);
            sql.Append("    ,slug" + Environment.NewLine);
            sql.Append("    ,image" + Environment.NewLine);
            sql.Append("    ,description" + Environment.NewLine);
            sql.Append("FROM VusSchool_Experience" + Environment.NewLine);
            sql.Append("WHERE 1 = 1" + Environment.NewLine);
            sql.Append("    AND Id = @Id" + Environment.NewLine);
            sql.Append("    AND slug = @slug" + Environment.NewLine);

            using (var conn = new SqlConnection(_connectString))
            {
                return conn.Query<VusSchool_Experience_DTOModel>(sql.ToString(),
                                                                 new { Id = dto.num, slug = dto.slug });
            }
        }
    }
}
