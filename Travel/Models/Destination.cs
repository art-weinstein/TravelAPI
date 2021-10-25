using System.ComponentModel.DataAnnotations;
namespace Travel.Models
{
    public class Destination
    {
        public int DestinationId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        [Range(0, 10, ErrorMessage = "Rating must be between 0 and 10.")]
        public int Rating { get; set; }
    }
}