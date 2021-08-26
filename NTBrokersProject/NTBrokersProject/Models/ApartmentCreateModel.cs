using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTBrokersProject.Models
{
    public class ApartmentCreateModel
    {
        public ApartmentModel Apartments { get; set; } = new ApartmentModel();
        public List<CompanyModel> Companies { get; set; } = new List<CompanyModel>();
        public List <BrokerModel> Brokers { get; set; }

    }
}
