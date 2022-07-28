using Microsoft.AspNetCore.Mvc;
using NET_test_TranTienDat.Data;
using NET_test_TranTienDat.Models;

namespace NET_test_TranTienDat.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _db;
        [FromForm]
        public Employee newEmployee { get; set; }


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
        public IActionResult Add(Employee obj)
        {
            _db.Employees.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
