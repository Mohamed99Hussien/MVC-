using Microsoft.AspNetCore.Mvc;
using MVC_DB.Models;

namespace MVC_DB.Controllers
{

    public class InsController : Controller
    {
        private readonly SchoolContext _context;
        public InsController(SchoolContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            var ins = _context.Instructors.ToList();
            return View(ins);
        }
    }
}
