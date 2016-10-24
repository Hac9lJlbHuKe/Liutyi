using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Liutyi_1.Controllers
{

    public class HomeController : Controller
    {
        // GET: /Home/

        public ActionResult Index()
        {
            string user_IP = Request.UserHostAddress;
            string user_url = Request.Url.AbsoluteUri;
            string type = Request.HttpMethod;

            using (System.IO.StreamWriter file =
           new System.IO.StreamWriter("D:\\log.txt", true))
            {
                file.WriteLine("user IP = " + user_IP + ", url = " + user_url + ", request type = " + type);
            }

            return View();
        }

    }
}
