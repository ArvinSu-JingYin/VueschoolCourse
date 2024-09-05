using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VueSchool_Test_DataAccessLayer.DataModel.DTO;

namespace VueSchool_Test_DataAccessLayer.Providers.Interface
{
    public interface IVusSchool_Experience_Provider
    {
        /// <summary>
        /// Get a list of experiences from the VusSchool_Experience table
        /// </summary>
        /// <returns>Returns a collection of VusSchool_Experience_DTOModel</returns>
        /// <remarks>
        /// This method retrieves data from the VusSchool_Experience table using Dapper
        /// and maps it to a collection of VusSchool_Experience_DTOModel.
        /// </remarks>
        public IEnumerable<VusSchool_Experience_DTOModel> GetVusSchoolExperienceList(string num);
    }
}
