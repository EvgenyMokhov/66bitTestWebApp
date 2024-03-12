using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;

namespace BusinessLogic.Interfaces
{
    public interface IFootballers
    {
        public IEnumerable<Footballer> GetAllFootballers();
        public Footballer GetFootballerById(int id);
        public void UpdateFootballer(Footballer footballer);
        public void DeleteFootballer(Footballer footballer);
    }
}
