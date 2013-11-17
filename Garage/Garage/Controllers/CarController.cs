using Garage.Models;
using Garage.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcContrib;

namespace Garage.Controllers
{
    public class CarController : Controller
    {
        CarContext _context = new CarContext();
        
        public ActionResult Index()
        {
            var cars = _context.Cars;
            return View(cars);
        }

        public ActionResult Create()
        {
            CreateCarViewModel addCarViewModel = new CreateCarViewModel(_context);
            

            return View(addCarViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Car car)
        {
            if (ModelState.IsValid)
            {
                _context.Cars.Add(car);
                _context.SaveChanges();
                return this.RedirectToAction<CarController>(cc => cc.Index());
            }
            else
            {
                CreateCarViewModel addCarViewModel = new CreateCarViewModel(_context);

                return View(addCarViewModel);
            }
        }

    }
}
