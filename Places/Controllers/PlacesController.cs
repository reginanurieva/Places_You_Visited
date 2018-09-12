using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Places.Models;

namespace Places.Controllers
{
    public class Places : Controller
    {
        [HttpGet("/places")]
        public ActionResult Index()
        {
            List<Place> allPlaces = Place.GetAll();
            return View(allPlaces);
        }

        [HttpGet("/places/new")]
        public ActionResult Form()
        {
            return View();
        }

        [HttpPost("/places")]
        public ActionResult NewPlace()
        {
            Place newPlace = new Place(Request.Form["country"], Request.Form["city"], Request.Form["activity"]);
            // newPlace.SavePlace();
            List<Place> allPlaces = Place.GetAll();
            return View("Index", allPlaces);
        }
    }
}
