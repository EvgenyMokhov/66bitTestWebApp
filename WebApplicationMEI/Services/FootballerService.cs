using BusinessLogic;
using Data.Entities;
using WebApplicationMEI.Models;

namespace WebApplicationMEI.Services
{
    public class FootballerService
    {
        private readonly DataManager dataManager;
        public FootballerService(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public List<FootballerViewModel> AllDBFootballersToView()
        {
            List<FootballerViewModel> result = new();
            foreach (Footballer item in dataManager.Footballers.GetAllFootballers())
                result.Add(DBFootballerToView(item));
            return result;
        }

        public FootballerViewModel DBFootballerToView(Footballer footballer)
        {
            FootballerViewModel result= new();
            result.Id = footballer.FootballerID;
            result.Name = footballer.Name;
            result.Surname = footballer.Surname;
            result.Sex = footballer.Sex ? "Male" : "Female";
            result.BornDate = footballer.BornDate.ToString();
            result.TeamName = dataManager.Teams.GetTeamById(footballer.TeamId).TeamName;
            result.Country = footballer.Country;
            return result;
        }

        public void SaveViewToDB(FootballerViewModel footballer)
        {
            Footballer result = new Footballer();
            if(footballer.Id != 0) 
                result = dataManager.Footballers.GetFootballerById(footballer.Id);
            result.Name = footballer.Name;
            result.Surname= footballer.Surname;
            result.Sex = footballer.Sex == "Male";
            result.BornDate = DateOnly.Parse(footballer.BornDate);
            result.TeamId = dataManager.Teams.GetTeamByName(footballer.TeamName).TeamId;
            result.Country = footballer.Country;
            dataManager.Footballers.UpdateFootballer(result);
        }

        public FootballerViewModel GetViewById(int id)
        {
            return DBFootballerToView(dataManager.Footballers.GetFootballerById(id));
        }
    }
}
