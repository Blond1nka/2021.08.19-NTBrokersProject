using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTBrokersProject.Services
{
    public class MainDBService
    {
        public readonly ApartmentDBService _apartmentDBService;
        public readonly CompanyDBService _companyDBService;
        public readonly BrokerDBService _brokerDBService;

        public MainDBService(ApartmentDBService apartmentDBService,
                                         CompanyDBService companyDBService,
                                         BrokerDBService brokerDBService)
        {
            _apartmentDBService = apartmentDBService;
            _companyDBService = companyDBService;
            _brokerDBService = brokerDBService;
        }
    }
}
