using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tracking.Data;
using tracking.Models;

namespace tracking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssueController : ControllerBase
    {
        private readonly IssueDbContext _context;

        public IssueController(IssueDbContext context)
        {
            _context = context;
        }
        [HttpGet]

        public async Task<IEnumerable<Issue>> Get()
            => await _context.Issues.ToListAsync();

        [HttpGet("id")]
        public async Task<IActionResult>  GetById(int id)
        {
            var issues = await _context.Issues.FindAsync(id);
            return issues == null? NotFound() : Ok(issues); 
        }
       

        //[HttpGet]

        //public async Task<IEnumerable<Issue>> Get()
        //    => await _context.Issue.ToListAsync();
    }
}
