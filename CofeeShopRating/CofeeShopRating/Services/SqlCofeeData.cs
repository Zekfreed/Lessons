using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CofeeShopRating.Data;
using CofeeShopRating.Models;

namespace CofeeShopRating.Services
{
    public class SqlCofeeData : ICofeeData
    {
        private CofeeRatingDbContext _dbContext;

        public SqlCofeeData(CofeeRatingDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Cofee Add(Cofee cofee)
        {
            _dbContext.Cofees.Add(cofee);
            _dbContext.SaveChanges();
            return cofee;
        }

        public Cofee Get(int id)
        {
            return _dbContext.Cofees.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Cofee> GetAll()
        {
            return _dbContext.Cofees.OrderBy(r => r.Name);
        }
    }
}
