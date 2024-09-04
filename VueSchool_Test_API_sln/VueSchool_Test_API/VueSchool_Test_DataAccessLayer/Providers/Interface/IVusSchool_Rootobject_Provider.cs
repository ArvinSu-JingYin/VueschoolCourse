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
        public IEnumerable<VusSchool_Rootobject_DTOModel> GetVusSchoolRootobjectList();
    }
}
