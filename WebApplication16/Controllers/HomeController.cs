using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication16.Models;

namespace WebApplication16.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string sort)
        {
            CarTwistDb db = new CarTwistDb(Properties.Settings.Default.ConStr);
            IEnumerable<Car> cars = db.GetCars();
            if (sort == "asc")
            {
                cars = cars.OrderBy(c => c.Year);
            }
            else if (sort == "desc")
            {
                cars = cars.OrderByDescending(c => c.Year);
            }
            HomePageViewModel vm = new HomePageViewModel();
            vm.Cars = cars;
            vm.SortAsc = sort == "asc";
            return View(vm);
        }

        public ActionResult ShowAddForm()
        {
            return View();
        }


        public ActionResult AddCar(Car car)
        {
            CarTwistDb db = new CarTwistDb(Properties.Settings.Default.ConStr);
            db.AddCar(car);
            return Redirect("/");
        }
    }
}