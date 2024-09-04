using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VueSchool_Test_BusinessLayer.ServiceModel.DTO;
using VueSchool_Test_BusinessLayer.Services.Interface;
using VueSchool_Test_DataAccessLayer.DataModel.DTO;
using VueSchool_Test_DataAccessLayer.Providers.Interface;
using static VueSchool_Test_BusinessLayer.ServiceModel.DTO.Destination_DTOModel;

namespace VueSchool_Test_BusinessLayer.Services.Implement
{
    public class VusSchool_Data_Service : IVusSchool_Data_Service
    {
        private readonly IVusSchool_Rootobject_Provider _rootobject_Provider;
        private readonly IVusSchool_Experience_Provider _experience_Provider;

        public VusSchool_Data_Service(IVusSchool_Rootobject_Provider rootobject_Providerprovider, IVusSchool_Experience_Provider experience_Provider)
        {
            _rootobject_Provider = rootobject_Providerprovider;
            _experience_Provider = experience_Provider;
        }

        public IEnumerable<Destination_DTOModel> GetTravelData()
        {
            var destinationDict = new Dictionary<int, Destination_DTOModel>();
            var destinationList = new List<Destination_DTOModel>();

            dynamic result = null;

            try
            {
                // 獲取根物件資料
                var rootObjectList = _rootobject_Provider.GetVusSchoolRootobjectList();

                // 獲取經驗資料
                var experienceList = _experience_Provider.GetVusSchoolExperienceList();

                foreach (var rootObject in rootObjectList)
                {
                    // 如果這個目的地已經存在於字典中，則不再新增，直接使用現有的項目
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

                    // 將該目的地的相關經驗加入
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
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }

            result = destinationDict.Values;

            return result;
        }
    }
}

