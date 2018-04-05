using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    [Route("company/[controller]/[action]")]
    public class AboutController
    {
         
        public string Phone()
        {
            return "0+666+57+45+20";
        }
         
        public string Address()
        {
            return "MAROC";
        }
    }
}
