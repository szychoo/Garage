using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Garage.Models;
using System.Web.Mvc;

namespace Garage.ViewModels
{
    public class CreateCarViewModel
    {
        private CarContext _context;

        public CreateCarViewModel(CarContext _context)
        {
            this._context = _context;

            Car = new Car();
            //CarModels = _context.CarModels;
            Makes = new SelectList(_context.Makes, "MakeID", "MakeName");

        }
        public Car Car { get; set; }
        //public IEnumerable<CarModel> CarModels { get; set; }
        public SelectList Makes { get; set; }
    }
}