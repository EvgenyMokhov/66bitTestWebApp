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
    public class Footballers : IFootballers
    {
        private EFDBContext Context { get; init; }
        public Footballers(EFDBContext context) 
        {
            Context = context;
        }
        public void UpdateFootballer(Footballer footballer)
        {
            if(footballer.FootballerID == 0)
                Context.Footballers.Add(footballer);
            else 
                Context.Entry(footballer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Context.SaveChanges();
        }

        public void DeleteFootballer(Footballer footballer)
        {
            Context.Footballers.Remove(footballer);
            Context.SaveChanges();
        }

        public IEnumerable<Footballer> GetAllFootballers()
        {
            return Context.Footballers;
        }

        public Footballer GetFootballerById(int id)
        {
            return Context.Footballers.FirstOrDefault(x => x.FootballerID == id);
        }
    }
}
