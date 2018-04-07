using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CofeeShopRating.Models;

namespace CofeeShopRating.Services
{
    public interface ICofeeData
    {
        IEnumerable<Cofee> GetAll();
        Cofee Get(int id);
        Cofee Add(Cofee restaurant);
    }
}
