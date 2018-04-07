using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CofeeShopRating.Models
{
    public class Cofee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public CofeeRating Rating { get; set; }
        public string Review { get; set; }
    }
}
