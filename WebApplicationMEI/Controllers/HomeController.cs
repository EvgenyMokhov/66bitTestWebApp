using BusinessLogic;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplicationMEI.Models;
using WebApplicationMEI.Services;

namespace WebApplicationMEI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ServicesManager servicesManager;
        public HomeController(DataManager dataManager)
        {
            servicesManager = new(dataManager);
        }

        public IActionResult Index()
        {
            List<FootballerViewModel> model = servicesManager.FootballerService.AllDBFootballersToView();
            return View(model);
        }
    }
}
