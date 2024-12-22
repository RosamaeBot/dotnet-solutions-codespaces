
using Backend.Models;
using System.Collections.Generic;

namespace Backend.Services
{
    public interface IVehicleService
    {
        void SaveLocation(VehicleLocation location);
        List<VehicleLocation> GetLatestLocations();
    }
}
