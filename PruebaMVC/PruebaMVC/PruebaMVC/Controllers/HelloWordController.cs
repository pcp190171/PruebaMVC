using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaMVC.Controllers
{
    public class HelloWordController : Controller
    {
        //
        // GET: /HelloWord/

        public string Index()
        {
            return "My default action ...";
        }

        public string Welcome()
        {
            return "Welcome action.";
        }

    }
}
