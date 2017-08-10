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
        //Details
        public IActionResult Details(int id)
        {
            var thisGummi = db.Gummis.FirstOrDefault(gummis => gummis.GummiId == id);
            return View(thisGummi);
        }
        //Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Gummi gummi)
        {
            db.Gummis.Add(gummi);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //Edit
        public IActionResult Edit(int id)
        {
            var thisGummi = db.Gummis.FirstOrDefault(gummis => gummis.GummiId == id);
            return View(thisGummi);
        }

        [HttpPost]
        public IActionResult Edit(Gummi gummi)
        {
            db.Entry(gummi).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //Delete
        public IActionResult Delete(int id)
        {
            var thisGummi = db.Gummis.FirstOrDefault(gummis => gummis.GummiId == id);
            return View(thisGummi);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisGummi = db.Gummis.FirstOrDefault(gummis => gummis.GummiId == id);
            db.Gummis.Remove(thisGummi);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
