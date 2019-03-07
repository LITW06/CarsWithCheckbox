using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication16.Models
{
    public class HomePageViewModel
    {
        public IEnumerable<Car> Cars { get; set; }
        public bool SortAsc { get; set; }
    }
}