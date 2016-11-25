using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace week11.Controllers
{
    public class SongsController : Controller
    {
        // GET: Songs
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Browse()
        {
            //create array of song list

            var songs = new string[] { "You Shook Me", "King of Pain", "City of Blinding Lights" };

            ViewBag.songs = songs;
            return View();
        }
        //GET: /Store/Details
        public String Details(int id)
        {
            string message = "Song.Details, ID = " + id;
            return message;
        }
    }
}