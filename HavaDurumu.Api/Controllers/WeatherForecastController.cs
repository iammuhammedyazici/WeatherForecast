using HavaDurumu.Api.ContextLayer;
using HavaDurumu.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HavaDurumu.Api.Controllers
{
    [Route("api/weatherforecast")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public WeatherForecastController(DatabaseContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<List<WeatherForecast>>> Get()
        {
            List<WeatherForecast> listOb = await _context.WeatherForecasts.ToListAsync();
            return Ok(listOb);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WeatherForecast>> Get(int id)
        {
            try
            {
                WeatherForecast weatherOb = await _context.WeatherForecasts.FindAsync(id);
                if (weatherOb == null)
                    return BadRequest();
                return Ok(weatherOb);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetByCity/{city}")]
        public async Task<ActionResult<List<WeatherForecast>>> Get(string city)
        {
            try
            {
                List<WeatherForecast> listOb = await _context.WeatherForecasts.Where(x => x.City == city).ToListAsync();
                return Ok(listOb);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
