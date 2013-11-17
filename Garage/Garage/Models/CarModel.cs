using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage.Models
{
    public class CarModel
    {
        public int CarModelID { get; set; }
        public string CarModelName { get; set; }
        public virtual Make Make { get; set; }

    }
}