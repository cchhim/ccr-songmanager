using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SongManager.Data.DataAccess;
using SongManager.Web.Models;
using SongManager.Core.Domain;

namespace SongManager.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var model = new AlbumModel
            {
           
            };
            return View(model);
        }
        public ActionResult LeftMenu() 
        {
            SongTypeDao songTypes  = new SongTypeDao();          
            var model = new MenuLeft
            {
                Productions= new ProductionDao().GetAll().OrderBy(x => x.ProductionName).ToList(),
                SongTypes = songTypes.GetAll()
            };            
            return View(model);
        }

    }
}
