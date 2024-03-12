using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface ITeams
    {
        public IEnumerable<Team> GetAllTeams();
        public Team GetTeamById(int id);
        public Team GetTeamByName(string name);
        public void UpdateTeam(Team team);
        public void DeleteTeam(Team team);
    }
}
