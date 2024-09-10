using DraftTaskOne.Areas.Identity.Data;
using DraftTaskOne.Models;
using Microsoft.AspNetCore.Mvc;

namespace DraftTaskOne.Controllers
{
    public class ClaimsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ClaimsController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        [HttpGet]

        public IActionResult Claims()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SubmitClaim(Claims claims)
        {
            if(ModelState.IsValid)
            {
                //do the calcs
                claims.TotalAmount = claims.HoursWorked * claims.RatePerHour;
                _context.Add(claims);
                await _context.SaveChangesAsync();  
                return RedirectToAction(nameof(Claims));
            }
            return View(claims);
        }
        //for the submit button to work
        public IActionResult ClaimSubmitted()
        {
            return View();
        }
    }
}
