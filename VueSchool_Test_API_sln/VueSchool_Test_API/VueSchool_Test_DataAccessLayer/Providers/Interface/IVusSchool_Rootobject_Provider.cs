﻿using VueSchool_Test_DataAccessLayer.DataModel;
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
        public IEnumerable<VusSchool_Rootobject_DTOModel> GetVusSchoolRootobjectList(APISearchDataDto apiSearchDataDto);


        public Dictionary<int, string?> VusSchoolNav();
    }
}
