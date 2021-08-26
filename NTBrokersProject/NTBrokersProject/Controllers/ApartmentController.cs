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
    public class ApartmentController : Controller
    {
        private readonly MainDBService _mainDBService;

        public ApartmentController(MainDBService mainDBService)
        {
            _mainDBService = mainDBService;
        }


        // GET: ApartmentController
        public IActionResult Index()
        {
            return View(_mainDBService._apartmentDBService.GetAll());
        }

        public IActionResult Create()
        {
            return View(new ApartmentCreateModel { Apartments = new ApartmentModel() });
        }

        public IActionResult Submit(ApartmentModel model)
        {
            _mainDBService._apartmentDBService.Create(model);
            return View("Index", _mainDBService._apartmentDBService.GetAll());
        }


    }      
    
}
