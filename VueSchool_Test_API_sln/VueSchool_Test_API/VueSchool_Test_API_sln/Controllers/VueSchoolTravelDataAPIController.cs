using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using VueSchool_Test_BusinessLayer.ServiceModel;
using VueSchool_Test_BusinessLayer.ServiceModel.DTO;
using VueSchool_Test_BusinessLayer.Services.Interface;

namespace VueSchool_Test_API_sln.Controllers
{
    [EnableCors("allowCors")]
    [ApiController]
    [Route("[controller]")]
    public class VueSchoolTravelDataAPIController : ControllerBase
    {
        private readonly IVusSchool_Data_Service _iVusSchool_Data_Service;

        public VueSchoolTravelDataAPIController(IVusSchool_Data_Service iVusSchool_Data_Service)
        {
            _iVusSchool_Data_Service = iVusSchool_Data_Service;
        }


        [HttpGet("/GetTravelData", Name = "GetTravelDataDto")]
        public IEnumerable<Destination_DTOModel> GetTravelData(string id, string slug)
        {
            var tran = new APISearchDataModel()
            {
                id = id,
                slug = slug
            };

            return GetTravelData(tran);
        }

        /// <summary>
        /// Get a list of destinations from the VusSchool_TravelData table
        /// </summary>
        /// <returns>Returns a collection of Destination_DTOModel</returns>
        /// <remarks>
        /// This method retrieves data from the VusSchool_TravelData table using the service layer
        /// and maps it to a collection of Destination_DTOModel.
        /// </remarks>
        [HttpPost("/GetTravelData", Name = "GetTravelData")]
        public IEnumerable<Destination_DTOModel> GetTravelData(APISearchDataModel apiSearchModel)
        {
            var getTravelData = _iVusSchool_Data_Service.GetTravelData(apiSearchModel);

            return getTravelData;
        }

        [HttpGet("/GetTravelDataNav", Name = "GetTravelDataNav")]
        public IEnumerable<object> GetTravelDataNav()
        {
            var models = _iVusSchool_Data_Service.GetTravelDataNavList();
            var result = models.Select(x => new
            {
                id = x.Key,
                name = x.Value
            });

            return result;
        }

    }
}
