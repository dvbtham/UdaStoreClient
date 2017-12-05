using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using UdaStore.Client.Core;
using UdaStore.Client.Core.Repositories;
using UdaStore.Client.Core.ViewModels;

namespace UdaStore.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            ViewData["home"] = "home";
        }
        public IActionResult Index()
        {
            ViewData["home"] = "home";
            var model = new HomeViewModel
            {
                WidgetInstances = _unitOfWork.WidgetInstances.GetPublished().Select(x => new WidgetInstanceViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    ViewComponentName = x.Widget.ViewComponentName,
                    WidgetId = x.WidgetId,
                    WidgetZoneId = x.WidgetZoneId,
                    Data = x.Data,
                    HtmlData = x.HtmlData
                }).ToList()
            };


            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
