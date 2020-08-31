using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using WebApplicationFrames.Data;


namespace WebApplicationFrames.Controllers
{
    public class HomeController : Controller
    {
        SqlDataAdaptor db;


        public ActionResult Index()
        {


            try
            {
                db = new SqlDataAdaptor();
                var list = db.GetAll();
                return View(list);
                //code everything works fine
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new HttpStatusCodeResult(404, "Error in cloud - GetPLUInfo" + ex.Message);
            }

        }
        [HttpPost]
        public ActionResult Index(string img, string titleadd,string textadd)
        {

            Console.WriteLine("Hello");
            Console.WriteLine("WORLD");








            return null;
        }
 
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

      

    }
}