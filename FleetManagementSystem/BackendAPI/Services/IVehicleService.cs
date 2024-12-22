
using BackendAPI.Models;
using System.Collections.Generic;

namespace BackendAPI.Services
{
    public interface IVehicleService
    {
        void SaveLocation(VehicleLocation location);
        List<VehicleLocation> GetLatestLocations();
    }
}
