
using Xunit;
using Moq;
using BackendAPI.Controllers;
using BackendAPI.Models;
using BackendAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BackendAPI.UnitTests
{
    public class VehicleControllerTests
    {
        [Fact]
        public void PostLocation_ValidData_ReturnsOk()
        {
            var mockService = new Mock<IVehicleService>();
            var controller = new VehicleController(mockService.Object);

            var result = controller.PostLocation(new VehicleLocation { VehicleId = "V123", Latitude = 37.7749m, Longitude = -122.4194m, Timestamp = System.DateTime.Now });

            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetLocations_ReturnsListOfLocations()
        {
            var mockService = new Mock<IVehicleService>();
            mockService.Setup(s => s.GetLatestLocations()).Returns(new List<VehicleLocation> { new VehicleLocation { VehicleId = "V123", Latitude = 37.7749m, Longitude = -122.4194m, Timestamp = System.DateTime.Now } });

            var controller = new VehicleController(mockService.Object);
            var result = controller.GetLocations() as OkObjectResult;

            Assert.NotNull(result);
            Assert.IsType<List<VehicleLocation>>(result.Value);
        }
    }
}
