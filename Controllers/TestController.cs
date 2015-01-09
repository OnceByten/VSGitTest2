using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VSGitTest2.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/
        // new comment [moss] edit..
        // edit in moss branch
        // edit in locla branch after remote merge occured.

        public ActionResult Index()
        {
            return View();
        }

    }
}
