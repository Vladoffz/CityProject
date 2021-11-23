using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.BL.Abstract;

namespace Web.Controllers
{
    public class ResidentsController : Controller
    {

        private readonly IResidentService _ResidentService;
        private readonly IPopulationService _PopulationService;
        public ResidentsController(IResidentService ResidentService, IPopulationService PopulationService)
        {
            _ResidentService = ResidentService;
            _PopulationService = PopulationService;
        }

        public IActionResult Index(string FullName, string DateOfBirth, int NumberOfApartments)
        {

            if (!String.IsNullOrEmpty(FullName))
            {
                return View(_ResidentService.FindByFullName(FullName));
            }
            else if (!String.IsNullOrEmpty(DateOfBirth))
            {
                return View(_ResidentService.FindByDateOfBirth(Convert.ToDateTime(DateOfBirth)));
            }
            else if (NumberOfApartments!=0)
            {
                return View(_PopulationService.FindResidentsByNumberOfApartments(NumberOfApartments));
            }
            else
            {
                return View(_ResidentService.List());
            }

        }
    }
}
