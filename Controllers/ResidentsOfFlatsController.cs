using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.BL.Abstract;
using Web.Entities;
using Web.Models;

namespace Web.Controllers
{
    public class ResidentsOfFlatsController : Controller
    {
        private readonly IResidentOfFlatService _ResidentOfFlatService;
        private readonly IValidationService _ValidationService;
        public ResidentsOfFlatsController(IResidentOfFlatService ResidentOfFlatService, IValidationService ValidationService)
        {
            _ResidentOfFlatService = ResidentOfFlatService;
            _ValidationService = ValidationService;
        }
        public IActionResult Index()
        {
           return View(_ResidentOfFlatService.List());

        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Delete(int ID)
        {
            return View(_ResidentOfFlatService.Get(ID));
        }

        public IActionResult Update(int ID)
        {
            return View(_ResidentOfFlatService.Get(ID));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("ResidentID,FlatID")] ResidentOfFlatDTO _ResidentOfFlat)
        {
            if (ModelState.IsValid && _ValidationService.VerifyPossibilityOfSettlement(_ResidentOfFlat.FlatID))
            {
                _ResidentOfFlatService.Insert(_ResidentOfFlat);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(_ResidentOfFlat);
            }
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmation(int ID)
        {
            _ResidentOfFlatService.DeleteEntity(ID);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost, ActionName("Update")]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateConfirmation([Bind("ID,ResidentID,FlatID")] ResidentOfFlatDTO _ResidentOfFlat)
        {
            _ResidentOfFlatService.Update(_ResidentOfFlat);
            return RedirectToAction(nameof(Index));
        }
    }
}