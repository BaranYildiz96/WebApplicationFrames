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
     
        //List<Modals> modalList = new List<Modals>();
        //for (int i = 1; i <10; i++)
        //{
        //    var modal = new Modals
        //    {
        //        Title = "Title " + i,
        //        Text = " Some text in the  " + i +". Modal",                
        //        Sp = "sp" + i,
        //        MyModal = "myModal" + i,
        //        Images = "Hizliresim" + i + ".jpg",
        //        Btn = "btn" + i,
        //        Px = "px" +i
        //    };

        //    modalList.Add(modal);
        //}






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