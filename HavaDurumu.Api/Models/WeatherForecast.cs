using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HavaDurumu.Api.Models
{
    [Table("WEATHERFORECAST")]
    public class WeatherForecast
    {
        public WeatherForecast()
        {

        }

        [Key]
        [Column("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("CITY")]
        public string City { get; set; }

        [Column("CELCIUS")]
        public int Celcius { get; set; }

        [Column("STATUS")]
        public string Status { get; set; }

        [Column("HUMIDITY")]
        public int Humidity { get; set; }
    }
}
