
using System;

namespace Backend.Models
{
    public class VehicleLocation
    {
        public int Id { get; set; }
        public string VehicleId { get; set; } = string.Empty; // Avoid null issues
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
