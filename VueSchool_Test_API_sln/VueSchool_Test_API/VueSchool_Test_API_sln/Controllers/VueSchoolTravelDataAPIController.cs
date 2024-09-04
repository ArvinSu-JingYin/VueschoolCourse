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

        [HttpGet(Name = "GetTravelData")]
        public IEnumerable<Destination_DTOModel> GetTravelData()
        {
            var getTravelData =  _iVusSchool_Data_Service.GetTravelData();

            return getTravelData;
        }
    }
}
