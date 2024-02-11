using Events.API.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace Events.API.Controllers
{
    [Route("api/dev-events")]
    [ApiController]
    public class DevEventsController : ControllerBase
    {
        private readonly DevEventDbContext _context;

        public DevEventsController(DevEventDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var devEvents = _context.DevEvents.Where(d => !d.IsDeleted).ToList();

            return Ok(devEvents);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var devEvent = _context.DevEvents.SingleOrDefault(d => d.Id == id);

            if(devEvent == null)
            {
                return NotFound();
            }

            return Ok(devEvent);
        }


    }
}
