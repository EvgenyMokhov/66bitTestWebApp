using BusinessLogic.Interfaces;
using Data;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class Teams : ITeams
    {
        private EFDBContext Context { get; init; }
        public Teams(EFDBContext context)
        {
            Context = context;
        }
        public void UpdateTeam(Team team)
        {
            if (team.TeamId == 0)
                Context.Teams.Add(team);
            Context.SaveChanges();
        }

        public void DeleteTeam(Team team)
        {
            Context.Teams.Remove(team);
            Context.SaveChanges();
        }

        public IEnumerable<Team> GetAllTeams()
        {
            return Context.Teams;
        }

        public Team GetTeamById(int id)
        {
            return Context.Teams.FirstOrDefault(x => x.TeamId == id);
        }
        public Team GetTeamByName(string name) 
        {
            return Context.Teams.FirstOrDefault(x => x.TeamName == name);
        }
    }
}
