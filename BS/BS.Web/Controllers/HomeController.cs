using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BS.Web.Models;
using Autofac;

namespace BS.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int pageNum=1,string searchText="")
        {
            HomeModel model = new HomeModel();
            var datas = model.GetPosts(pageNum, searchText);
            return View(datas);
        }
        public IActionResult GetList()
        {
            var model = Startup.AutofacContainer.Resolve<HomeModel>();
            var tableModel = new DataTableAjaxRequestModel(Request);
            var data = model.GetAll(tableModel);
            return Json(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
