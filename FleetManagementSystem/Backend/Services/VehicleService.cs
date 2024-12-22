
using Backend.Models;
using System.Collections.Generic;
using System.Linq;

namespace Backend.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly List<VehicleLocation> _locations = new();

        public void SaveLocation(VehicleLocation location)
        {
            _locations.Add(location);
        }

        public List<VehicleLocation> GetLatestLocations()
        {
            return _locations
                .GroupBy(l => l.VehicleId)
                .Select(g => g.OrderByDescending(l => l.Timestamp).First())
                .ToList();
        }
    }
}
