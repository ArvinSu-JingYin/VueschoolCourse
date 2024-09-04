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
        public IEnumerable<VusSchool_Experience_DTOModel> GetVusSchoolExperienceList();
    }
}
