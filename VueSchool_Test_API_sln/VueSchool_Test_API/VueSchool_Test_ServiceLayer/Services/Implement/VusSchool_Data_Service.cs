using VueSchool_Test_BusinessLayer.ServiceModel.DTO;
using VueSchool_Test_BusinessLayer.Services.Interface;
using VueSchool_Test_DataAccessLayer.Providers.Interface;
using static VueSchool_Test_BusinessLayer.ServiceModel.DTO.Destination_DTOModel;
using Microsoft.Extensions.Logging;
using VueSchool_Test_BusinessLayer.ServiceModel;
using VueSchool_Test_DataAccessLayer.DataModel;

namespace VueSchool_Test_BusinessLayer.Services.Implement
{
    public class VusSchool_Data_Service : IVusSchool_Data_Service
    {
        private readonly IVusSchool_Rootobject_Provider _rootobject_Provider;
        private readonly IVusSchool_Experience_Provider _experience_Provider;
        private readonly ILogger<VusSchool_Data_Service> _logger;


        public VusSchool_Data_Service(
            IVusSchool_Rootobject_Provider rootobject_Providerprovider
            , IVusSchool_Experience_Provider experience_Provider
            , ILogger<VusSchool_Data_Service> logger
        )
        {
            _rootobject_Provider = rootobject_Providerprovider;
            _experience_Provider = experience_Provider;
            _logger = logger;
            _logger.LogInformation("VusSchool_Data_Service 初始化完成");
        }

        /// <summary>
        /// Get travel data
        /// </summary>
        /// <param name="num">The number of travel data</param>
        /// <returns>Returns a collection of travel data containing destinations and related experiences</returns>
        /// <remarks>
        /// This method retrieves data from the root object provider and experience provider
        /// , and combines them into a collection containing destinations and related experiences.
        /// </remarks>
        public IEnumerable<Destination_DTOModel> GetTravelData(APISearchDataModel apiSearchModel)
        {
            var destinationDict = new Dictionary<int, Destination_DTOModel>();
            var destinationList = new List<Destination_DTOModel>();

            try
            {
                var searchDto = new APISearchDataDto
                {
                    num = apiSearchModel.num,
                    slug = apiSearchModel.slug
                };

                var rootObjectList = _rootobject_Provider.GetVusSchoolRootobjectList(searchDto);

                var experienceList = _experience_Provider.GetVusSchoolExperienceList(searchDto);

                foreach (var rootObject in rootObjectList)
                {
                    if (!destinationDict.ContainsKey(rootObject.Id))
                    {
                        destinationDict[rootObject.Id] = new Destination_DTOModel
                        {
                            Id = rootObject.Id,
                            name = rootObject.name,
                            slug = rootObject.slug,
                            image = rootObject.image,
                            description = rootObject.description,
                            experience = new List<Experience>()
                        };
                    }

                    var destination = destinationDict[rootObject.Id];

                    var relatedExperiences = experienceList.Where(x => x.Id == rootObject.Id).ToList();
                    foreach (var experience in relatedExperiences)
                    {
                        destination.experience.Add(new Experience
                        {
                            Id = experience.Id,
                            name = experience.name,
                            slug = experience.slug,
                            image = experience.image,
                            description = experience.description
                        });
                    }
                }

                _logger.LogInformation("GetTravelData 成功");
            }
            catch (Exception ex)
            {
                _logger.LogError($"[ Exception ] GetTravelData : {ex}");
                _logger.LogInformation("GetTravelData 失敗");
            }

            return destinationDict.Values;
        }
    }
}

