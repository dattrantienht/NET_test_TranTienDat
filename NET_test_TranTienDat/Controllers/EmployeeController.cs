using Microsoft.AspNetCore.Mvc;
using NET_test_TranTienDat.Data;
using NET_test_TranTienDat.Models;

namespace NET_test_TranTienDat.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _db;

        public EmployeeController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Employee> objEmployeeList = _db.Employees;
            return View(objEmployeeList);
        }

        [HttpPost]
        public IActionResult Add([FromForm] Employee obj)
        {
            if (ModelState.IsValid)
            {
                _db.Employees.Add(obj);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var employee = _db.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }

            _db.Employees.Remove(employee);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
