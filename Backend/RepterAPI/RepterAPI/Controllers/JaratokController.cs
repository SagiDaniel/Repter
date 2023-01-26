using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepterAPI.Infrastructure;
using RepterAPI.Infrastructure.Model;

namespace RepterAPI.Controllers
{
    
    [ApiController]
    [Route("flight")]
    public class JaratokController : Controller
    {
        private DBContext _context;
        public JaratokController(DBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Jarat> GetFlights()
        {
            return _context.Jaratok.Include(x => x.KiinduloVaros).Include(x => x.CelVaros).Include(x => x.Legitarsasag).ToList();
        }

        [HttpGet("{id}")]
        public Jarat GetFlightById(int id)
        {
            return _context.Jaratok.Include(x => x.KiinduloVaros).Include(x => x.CelVaros).Include(x => x.Legitarsasag).Where(x => x.Id == id).FirstOrDefault();
        }

        [HttpPost]
        public int AddNewFlight(Jarat body)
        {
            _context.Jaratok.AddRange(body);
            return _context.SaveChanges(); ;
        }

        [HttpPut("{id}")]
        public int UpdateFlight(Jarat body, int id)
        {
            _context.Jaratok.Update(body);
            return _context.SaveChanges();
        }

        [HttpDelete("{id}")]
        public int DeleteFlight(int id)
        {
            _context.Jaratok.Remove(_context.Jaratok.Where(x => x.Id == id).FirstOrDefault());
            return _context.SaveChanges();
        }
    }
}
