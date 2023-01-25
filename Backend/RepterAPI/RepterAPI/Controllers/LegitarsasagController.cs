using Microsoft.AspNetCore.Mvc;
using RepterAPI.Infrastructure;
using RepterAPI.Infrastructure.Model;

namespace RepterAPI.Controllers
{
    [ApiController]
    [Route("airline")]
    public class LegitarsasagController : Controller
    {
        private DBContext _context;
        public LegitarsasagController(DBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Legitarsasag> GetAirlines()
        {
            return _context.Legitarsasag.ToList();
        }

        [HttpGet("{id}")]
        public Legitarsasag GetAirlineById(int id)
        {
            return _context.Legitarsasag.Where(x => x.Id == id).FirstOrDefault();
        }

        [HttpPost]
        public int AddNewAirline(Legitarsasag body)
        {
            _context.Legitarsasag.AddRange(body);
            return _context.SaveChanges(); ;
        }

        [HttpPut("{id}")]
        public int UpdateAirline(Legitarsasag body, int id)
        {
            _context.Legitarsasag.Update(body);
            return _context.SaveChanges();
        }

        [HttpDelete("{id}")]
        public int DeleteAirline(int id)
        {
            _context.Legitarsasag.Remove(_context.Legitarsasag.Where(x => x.Id == id).FirstOrDefault());
            return _context.SaveChanges();
        }
    }
}
