using Fantasy.BackEnd.Data;
using Fantasy.Common.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fantasy.BackEnd.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController : Controller
    {
        private readonly DataContext _context;

        public CountriesController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Country country)
        {
            await _context.AddAsync(country);
            await _context.SaveChangesAsync();
            return Ok(country);
            
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.Countries.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var country = await _context.Countries.FindAsync(id);
            if (country == null) return NotFound();
            return Ok(country);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync(Country country)
        {
            var countryCurrent = await _context.Countries.FindAsync(country.Id);
            if (countryCurrent == null) return NotFound();

            countryCurrent.Name = country.Name;
            _context.Update(countryCurrent);
            await _context.SaveChangesAsync();

            return Ok(countryCurrent);

        }
    }
}
