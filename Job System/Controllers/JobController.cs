using Microsoft.AspNetCore.Mvc;
using JobPortal.Models;
using System.Linq;

public class JobController : Controller
{
    private readonly JobDbContext _context;

    public JobController(JobDbContext context)
    {
        _context = context;
    }

    public IActionResult Index(string keywords, string location, string category, string company)
    {
        var jobs = from j in _context.Jobs
                   select j;

        if (!string.IsNullOrEmpty(keywords))
        {
            jobs = jobs.Where(j => j.Title.Contains(keywords) || j.Description.Contains(keywords));
        }

        if (!string.IsNullOrEmpty(location))
        {
            jobs = jobs.Where(j => j.Location == location);
        }

        if (!string.IsNullOrEmpty(category))
        {
            jobs = jobs.Where(j => j.Category == category);
        }

        if (!string.IsNullOrEmpty(company))
        {
            jobs = jobs.Where(j => j.Company == company);
        }

        return View(jobs.ToList());
    }
}
