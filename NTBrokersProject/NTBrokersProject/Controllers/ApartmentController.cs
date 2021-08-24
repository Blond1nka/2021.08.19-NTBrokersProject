using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NTBrokersProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTBrokersProject.Controllers
{
    public class ApartmentController : Controller
    {
        private readonly ApartmentDBService _apartmentDBService;
        private readonly RealEstateDBService _realEstateDBService;

        public ApartmentController(ApartmentDBService apartmentDBService, RealEstateDBService realEstateDBService)
        {
            _apartmentDBService = apartmentDBService;
            _realEstateDBService = realEstateDBService;
        }


        // GET: ApartmentController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ApartmentController/Details/5
        //public ActionResult Submit(RealEstateDBService model)
        //{
        //    _apartmentDBService.Create(model);
        //    RealEstateDBService data = new();
        //    data.Apartments = _apartmentDBService.Read();
        //    return View("Index", data);
        //}
    }

        // GET: ApartmentController/Create
        //public ActionResult Create()
        //{
        //    RealEstateDBService data = _realEstateDBService.GetGeneralDBData();
        //    return View(data);
        //}



        
    
}
