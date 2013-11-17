using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage.Models
{
    public class Car
    {
        public int CarID { get; set; }
        public string Colour { get; set; }
        //public virtual CarModel CarModel { get; set; }
        //public int CarModelID { get; set; }
        public virtual Make Make { get; set; }
        public int MakeID { get; set; }
    }
}