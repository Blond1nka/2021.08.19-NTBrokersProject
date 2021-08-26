using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTBrokersProject.Models
{
    public class RealEstateModel
    {
      
        public ApartmentCreateModel ApartmentCreateModel { get; set; }

        public CompanyModel Company { get; set; }
        public CompanyCreateModel CompanyCreateModel { get; set; }

       
        public List<BrokerModel> Brokers { get; set; }
    }
}
