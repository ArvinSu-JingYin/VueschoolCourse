using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VueSchool_Test_DataAccessLayer.DataModel.DTO;

namespace VueSchool_Test_BusinessLayer.ServiceModel.DTO
{
    public class Destination_DTOModel
    {
            public int Id { get; set; }
            public string? name { get; set; }
            public string? slug { get; set; }
            public string? image { get; set; }
            public string? description { get; set; }

            public List<Experiences>? experiences { get; set; }

        public class Experiences
        {
            public int Id { get; set; }
            public string? name { get; set; }
            public string? slug { get; set; }
            public string? image { get; set; }
            public string? description { get; set; }
        }
    }
}
