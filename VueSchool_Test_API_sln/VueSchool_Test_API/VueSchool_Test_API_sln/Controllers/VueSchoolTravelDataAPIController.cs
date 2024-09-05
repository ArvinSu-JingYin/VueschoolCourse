using Microsoft.AspNetCore.Mvc;
using VueSchool_Test_BusinessLayer.ServiceModel.DTO;
using VueSchool_Test_BusinessLayer.Services.Implement;
using VueSchool_Test_BusinessLayer.Services.Interface;

namespace VueSchool_Test_API_sln.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VueSchoolTravelDataAPIController : ControllerBase
    {
        private readonly IVusSchool_Data_Service _iVusSchool_Data_Service;

        public VueSchoolTravelDataAPIController(IVusSchool_Data_Service iVusSchool_Data_Service) 
        {
            _iVusSchool_Data_Service = iVusSchool_Data_Service;
        }

        /// <summary>
        /// Get a list of destinations from the VusSchool_TravelData table
        /// </summary>
        /// <returns>Returns a collection of Destination_DTOModel</returns>
        /// <remarks>
        /// This method retrieves data from the VusSchool_TravelData table using the service layer
        /// and maps it to a collection of Destination_DTOModel.
        /// </remarks>
        [HttpPost(Name = "GetTravelData")]
        public IEnumerable<Destination_DTOModel> GetTravelData(string num)
        {
            var getTravelData =  _iVusSchool_Data_Service.GetTravelData(num);

            return getTravelData;
        }
    }
}
