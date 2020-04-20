using MickKonradProjectBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.ObjectPool;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.ComTypes;

namespace MickKonradProjectBackend.Controllers
{
    [ApiController]
    [Route("api")]
    public class DueTimeController : ControllerBase
    {
        private static readonly HttpClient client = new HttpClient();
        private readonly DueTimeContext _context;

        public DueTimeController(DueTimeContext context)
        {
            _context = context;

            if (!_context.dueTime.Any())
            {
                _context.dueTime.Add(new DueTime
                { Id = 1, StopId = 2335, TimeDue = 10, Route = "27" });
                _context.dueTime.Add(new DueTime
                { Id = 2, StopId = 2336, TimeDue = 15, Route = "77A" });
                _context.dueTime.Add(new DueTime
                { Id = 3, StopId = 2335, TimeDue = 18, Route = "27" });
                _context.dueTime.Add(new DueTime
                { Id = 4, StopId = 251, TimeDue = 3, Route = "9" });
                _context.dueTime.Add(new DueTime
                { Id = 5, StopId = 251, TimeDue = 5, Route = "41" });
                _context.dueTime.Add(new DueTime
                { Id = 6, StopId = 251, TimeDue = 16, Route = "150" });
                _context.dueTime.Add(new DueTime
                { Id = 7, StopId = 251, TimeDue = 21, Route = "9" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        [Route("stop/{stopId}")]
        [Produces("application/json")]
        public IQueryable GetByStop(int stopId)
        {
            return _context.dueTime.Where<DueTime>(record => record.StopId == stopId);
        }
    }
}