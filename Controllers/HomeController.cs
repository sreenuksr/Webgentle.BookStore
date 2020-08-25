using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Webgentle.BookStore.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Using AddControllerWithViews Method....";
        }
    }
}
