using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CofeeShopRating.Models;

namespace CofeeShopRating.Services
{
    public interface ICofeeManager
    {
        IEnumerable<Cofee> GetAll();
        Cofee Get(int id);
        Cofee Create(Cofee restaurant);
    }
}
