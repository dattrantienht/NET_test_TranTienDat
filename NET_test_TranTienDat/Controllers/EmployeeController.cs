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

        public IActionResult Add()
        {
            return View();
        }
    }
}
