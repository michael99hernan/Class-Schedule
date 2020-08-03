using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Schedule.Models;
using SchedulePicker.Data;
using SchedulePicker.ViewModels;
using Microsoft.AspNet.Identity;
namespace SchedulePicker.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly Microsoft.AspNetCore.Identity.UserManager<Student> _userManager;
        public StudentController(ApplicationDbContext context, Microsoft.AspNetCore.Identity.UserManager<Student> userManager)
        {
            
            
            
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AddCourse()
        {
            var courses = await _context.Courses.ToListAsync();
            var userId = User.Identity.GetUserId();
            var user = await _userManager.FindByIdAsync(userId);
            return View(new AddCourseViewModel(user, courses));
        }
    }
}
