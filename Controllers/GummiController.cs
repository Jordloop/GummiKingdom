using System.Linq;
using Microsoft.AspNetCore.Mvc;
using GummiBearKing.Models;
using Microsoft.EntityFrameworkCore;

namespace GummiBearKing.Controllers
{
    public class GummiController : Controller
    {
        private GummiDbContext db = new GummiDbContext();

        public IActionResult Index()
        {
            return View(db.Gummis.ToList());
        }
    }
}
