using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using Lethu_Gift_of_Givers.Models;

namespace Lethu_Gift_of_Givers.Controllers
{
    [Authorize]
    public class ReportController : Controller
    {
        private readonly Lethu_Gift_of_GiversDbContext _context;

        public ReportController(Lethu_Gift_of_GiversDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var Reports = await _context.IncidentReports
                .Include(i => i.User)
                .OrderByDescending(i => i.ReportedAt)
                .ToListAsync();

            return View(Reports);
        }

        [HttpGet]
        public IActionResult Report()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Report(IncidentReportViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

                    // Create new IncidentReport from ViewModel
                    var Report = new IncidentReport
                    {
                        Title = model.Title,
                        Description = model.Description,
                        Location = model.Location,
                        IncidentDate = model.ReportDate,
                        DisasterType = model.DisasterType,
                        AffectedAreas = model.AffectedAreas,
                        UrgencyLevel = model.UrgencyLevel,
                        UserId = userId,
                        ReportedAt = DateTime.UtcNow,
                        Status = "Pending"
                    };

                    _context.IncidentReports.Add(Report);
                    await _context.SaveChangesAsync();

                    TempData["SuccessMessage"] = "Report report submitted successfully!";
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    // Log the actual error for debugging
                    Console.WriteLine($"Error saving Report: {ex.Message}");
                    if (ex.InnerException != null)
                    {
                        Console.WriteLine($"Inner exception: {ex.InnerException.Message}");
                    }

                    ModelState.AddModelError("", "An error occurred while saving the Report report. Please try again.");
                }
            }

            // If we got this far, something failed; redisplay form
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var Report = await _context.IncidentReports
                .Include(i => i.User)
                .FirstOrDefaultAsync(i => i.IncidentId == id);

            if (Report == null)
            {
                return NotFound();
            }

            return View(Report);
        }
    }
}