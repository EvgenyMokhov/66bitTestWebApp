using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class DataManager
    {
        public ITeams Teams { get; set; }
        public IFootballers Footballers { get; set; }
        public DataManager(ITeams teams, IFootballers footballers) 
        {
            Teams = teams;
            Footballers = footballers;
        }
    }
}
