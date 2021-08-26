using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NTBrokersProject.Models;
using NTBrokersProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTBrokersProject.Controllers
{
    public class BrokerController : Controller
    {
        private readonly BrokerDBService _brokerDBService;

        public BrokerController(BrokerDBService brokerDBService)
        {
            _brokerDBService = brokerDBService;
        }
        
        public IActionResult Index()
        {
            return View(_brokerDBService.GetAll());
        }

        //public IActionResult Index()
        //{
        //    List<BrokerModel> data = _brokerDBService.GetAll();
        //    return View(data);
        //}

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Submit(BrokerModel model)
        {
            _brokerDBService.AddBroker(model);
            return View("Index", _brokerDBService.GetAll());
        }
        //public IActionResult Submit(BrokerModel model)
        //{
        //    _brokerDBService.AddBroker(model);
        //    List<BrokerModel> data = _brokerDBService.GetAll();
        //    return View("Index", data);
        //}



    }
}
