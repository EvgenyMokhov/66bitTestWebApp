using BusinessLogic;
using Microsoft.AspNetCore.Mvc;
using WebApplicationMEI.Models;
using WebApplicationMEI.Services;

namespace WebApplicationMEI.Controllers
{
    public class TeamController : Controller
    {
        private readonly ServicesManager servicesManager;
        public TeamController(DataManager dataManager) 
        {
            servicesManager = new(dataManager);
        }

        public IActionResult Create(TeamViewModel model)
        {
            servicesManager.TeamService.CreateTeam(model);
            return View();
        }
    }
}
