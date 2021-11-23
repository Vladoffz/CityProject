using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Web.BL.Abstract;

namespace Web.Controllers
{
    public class CitiesController : Controller
    {
        private readonly ICityService _CityService;
        private readonly IPopulationService _PopulationService;

        public CitiesController(ICityService CityService, IPopulationService PopulationService)
        {
            _CityService = CityService;
            _PopulationService = PopulationService;

        }
        public IActionResult Index(string Name, int NumberOfResidents)
        {
            if (!String.IsNullOrEmpty(Name))
            {
                return View(_CityService.FindByName(Name));
            }
            else if (NumberOfResidents!=0)
            {
                return View(_PopulationService.FindCitiesByNumberOfResidents(NumberOfResidents));
            }
            
            else
            {
                return View(_CityService.List());
            }
        }
    }
}