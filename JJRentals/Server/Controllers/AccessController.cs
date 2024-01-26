using JJRentals.Server.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Security.Claims;

namespace JJRentals.Server.Controllers
{
    public class AccessController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;
        public AccessController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        [Authorize(Roles = "admin")]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "admin")]
        public IActionResult ClaimsDone()
        {
            return View();
        }
    }
}
