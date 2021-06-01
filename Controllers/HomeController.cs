using DeepOWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Web;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DeepOWebApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello World, this is ASP.Net MVC Tutorials";
        }
    }
}
