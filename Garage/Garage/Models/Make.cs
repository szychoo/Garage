using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage.Models
{
    public class Make
    {
        public int MakeID { get; set; }
        public string MakeName { get; set; }
        public virtual ICollection<CarModel> Models { get; set; }
    }
}