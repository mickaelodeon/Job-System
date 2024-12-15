using Microsoft.AspNetCore.Mvc;
using JobPortal.Models;

namespace JobPortal.Controllers
{
    public class DashboardController : Controller
    {
        //private readonly JobPortalContext _context;

        //public DashboardController(JobPortalContext context)
        //{
        //    _context = context;
        //}

        public IActionResult CandidateHome()
        {
            // In a real app, get jobs from database
            var jobs = new List<Job>
            {
                new Job
                {
                    Id = 1,
                    Title = "Senior .NET Developer",
                    Company = "Tech Corp",
                    Location = "New York, NY",
                    Type = "Full-time",
                    Salary = "$120k - $150k",
                    Description = "Looking for an experienced .NET developer...",
                    PostedDate = DateTime.Now.AddDays(-2)
                },
                // Add more sample jobs
            };

            return View(jobs);
        }

        public IActionResult CompanyHome()
        {
            // In a real app, get company's jobs from database
            var companyJobs = new List<Job>
            {
                new Job
                {
                    Id = 1,
                    Title = "Senior .NET Developer",
                    Location = "New York, NY",
                    Type = "Full-time",
                    //Status = "Active",
                    //Applications = 15,
                    //Views = 245,
                    PostedDate = DateTime.Now.AddDays(-2)
                },
                // Add more sample jobs
            };

            return View(companyJobs);
        }

        [HttpPost]
        public IActionResult DeleteJob(int id)
        {
            // Delete job logic here
            return RedirectToAction("CompanyHome");
        }
    }
}