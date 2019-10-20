using HavaDurumu.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace HavaDurumu.Api.ContextLayer
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
    }
}
