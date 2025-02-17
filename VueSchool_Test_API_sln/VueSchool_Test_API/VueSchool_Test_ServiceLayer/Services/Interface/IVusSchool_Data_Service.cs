﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VueSchool_Test_BusinessLayer.ServiceModel;
using VueSchool_Test_BusinessLayer.ServiceModel.DTO;

namespace VueSchool_Test_BusinessLayer.Services.Interface
{
    public interface IVusSchool_Data_Service
    {
        /// <summary>
        /// Get travel data
        /// </summary>
        /// <param name="id">The number of travel data</param>
        /// <returns>Returns a collection of travel data containing destinations and related experiences</returns>
        /// <remarks>
        /// This method retrieves data from the root object provider and experiences provider
        /// , and combines them into a collection containing destinations and related experiences.
        /// </remarks>
        public IEnumerable<Destination_DTOModel> GetTravelData(APISearchDataModel apiSearchModel);

        public Dictionary<int, string?> GetTravelDataNavList();
    }
}
