using BusinessLogic;

namespace WebApplicationMEI.Services
{
    public class ServicesManager
    {
        public FootballerService FootballerService { get; init;}
        public TeamService TeamService { get; init;}
        public ServicesManager(DataManager dataManager)
        { 
            FootballerService = new(dataManager);
            TeamService = new(dataManager);
        }
    }
}
