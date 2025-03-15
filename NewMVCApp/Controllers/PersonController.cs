using Microsoft.AspNetCore.Mvc;
using NewMVCApp.Data;
using NewMVCApp.Models;
using System.Linq;

namespace NewMVCApp.Controllers
{
    public class PersonController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PersonController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Hiển thị danh sách Person
        public IActionResult Index()
        {
            var people = _context.Person.ToList();
            return View(people);
        }

        // Hiển thị form thêm Person
        public IActionResult Create()
        {
            return View();
        }

        // Xử lý thêm Person
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                _context.Person.Add(person);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(person);
        }

        // Hiển thị form sửa Person
        public IActionResult Edit(int id)
        {
            var person = _context.Person.Find(id);
            if (person == null)
                return NotFound();

            return View(person);
        }

        // Xử lý sửa Person
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Person person)
        {
            if (ModelState.IsValid)
            {
                _context.Person.Update(person);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(person);
        }

        // Xác nhận xóa Person
        public IActionResult Delete(int id)
        {
            var person = _context.Person.Find(id);
            if (person == null)
                return NotFound();

            return View(person);
        }

        // Xử lý xóa Person
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var person = _context.Person.Find(id);
            if (person != null)
            {
                _context.Person.Remove(person);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
