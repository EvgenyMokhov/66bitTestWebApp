using BusinessLogic;
using Data.Entities;
using WebApplicationMEI.Models;

namespace WebApplicationMEI.Services
{
    public class TeamService
    {
        private readonly DataManager dataManager;
        public TeamService(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public void CreateTeam(TeamViewModel vm) 
        {
            Team newTeam = new();
            newTeam.TeamName = vm.TeamName;
            dataManager.Teams.UpdateTeam(newTeam);
        }

        public List<TeamViewModel> GetAllVMTeams()
        {
            List<TeamViewModel> result = new();
            foreach (Team team in dataManager.Teams.GetAllTeams())
                result.Add(new() { TeamName = team.TeamName, id = team.TeamId.ToString() });
            return result;
        }
    }
}
