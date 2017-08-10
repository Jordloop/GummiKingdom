using System.Linq;
using Microsoft.AspNetCore.Mvc;
using GummiBearKing.Models;
using Microsoft.EntityFrameworkCore;

namespace GummiBearKing.Controllers
{
    public class GummiController : Controller
    {
        private GummiDbContext db = new GummiDbContext();
        //View All
        public IActionResult Index()
        {
            return View(db.Gummis.ToList());
        }

        public IActionResult Details(int id)
        {
            var thisGummi = db.Gummis.FirstOrDefault(gummis => gummis.GummiId == id);
            return View(thisGummi);
        }
    }
}
