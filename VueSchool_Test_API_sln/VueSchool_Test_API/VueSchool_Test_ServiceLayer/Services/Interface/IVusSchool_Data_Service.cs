using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VueSchool_Test_BusinessLayer.ServiceModel.DTO;

namespace VueSchool_Test_BusinessLayer.Services.Interface
{
    public interface IVusSchool_Data_Service
    {
        public IEnumerable<Destination_DTOModel> GetTravelData();
    }
}
