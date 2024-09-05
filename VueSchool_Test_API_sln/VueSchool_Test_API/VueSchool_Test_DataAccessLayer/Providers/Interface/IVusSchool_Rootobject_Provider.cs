using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VueSchool_Test_DataAccessLayer.DataModel.DTO;

namespace VueSchool_Test_DataAccessLayer.Providers.Interface
{
    public interface IVusSchool_Rootobject_Provider
    {
        /// <summary>
        /// Get a list of root objects from the VusSchool_Rootobject table
        /// </summary>
        /// <returns>Returns a collection of VusSchool_Rootobject_DTOModel</returns>
        /// <remarks>
        /// This method retrieves data from the VusSchool_Rootobject table using Dapper
        /// and maps it to a collection of VusSchool_Rootobject_DTOModel.
        /// </remarks>
        public IEnumerable<VusSchool_Rootobject_DTOModel> GetVusSchoolRootobjectList(string num);
    }
}
