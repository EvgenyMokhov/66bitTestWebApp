using BusinessLogic;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using WebApplicationMEI.Models;
using WebApplicationMEI.Services;

namespace WebApplicationMEI.Controllers
{
    public class FootballerController : Controller
    {
        private readonly ServicesManager servicesManager;
        public FootballerController(DataManager dataManager)
        {
            servicesManager = new(dataManager);
        }

        public IActionResult Edit(int id = 0)
        {
            FootballerViewModel model = new();
            if (id == 0)
                model = new();
            else
                model = servicesManager.FootballerService.GetViewById(id);
            ViewBag.teams = servicesManager.TeamService.GetAllVMTeams();
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(FootballerViewModel model)
        {
            DateOnly bd = new();
            if (!DateOnly.TryParse(model.BornDate, out bd))
                ModelState.AddModelError("BornDate", "Field Born date is uncorrect");
            if (ModelState.IsValid)
            {
                if (servicesManager.TeamService.GetAllVMTeams().Where(x => x.TeamName == model.TeamName).Count() == 0)
                    servicesManager.TeamService.CreateTeam(new() { TeamName = model.TeamName });
                servicesManager.FootballerService.SaveViewToDB(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", ""));
            }
            ViewBag.teams = servicesManager.TeamService.GetAllVMTeams();
            return View(model);
        }
    }
}
