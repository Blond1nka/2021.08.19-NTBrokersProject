using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTBrokersProject.Models
{
    public class ApartmentModel
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Address { get; set; }
        public int FlatFloor { get; set; }
        public int BuildingFloors { get; set; }
        public decimal Area { get; set; }
        public int CompanyId { get; set; }
        public int BrokerId { get; set; }
    }
}
