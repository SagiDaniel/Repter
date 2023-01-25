using Microsoft.AspNetCore.Mvc;
using RepterAPI.Infrastructure;
using RepterAPI.Infrastructure.Model;

namespace RepterAPI.Controllers
{
    [ApiController]
    [Route("city")]
    public class VarosokController : Controller
    {
        private DBContext _context;
        public VarosokController(DBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Varos> GetCities()
        {
            return _context.Varosok.ToList();
        }

        [HttpGet("{id}")]
        public Varos GetCityById(int id)
        {
            return _context.Varosok.Where(x => x.Id == id).FirstOrDefault();
        }

        [HttpPost]
        public int AddNewCity(Varos body)
        {
            _context.Varosok.AddRange(body);
            return _context.SaveChanges(); ;
        }

        [HttpPut("{id}")]
        public int UpdateCity(Varos body, int id)
        {
            _context.Varosok.Update(body);
            return _context.SaveChanges();
        }

        [HttpDelete("{id}")]
        public int DeleteCity(int id)
        {
            _context.Varosok.Remove(_context.Varosok.Where(x => x.Id == id).FirstOrDefault());
            return _context.SaveChanges();
        }
    }
}
