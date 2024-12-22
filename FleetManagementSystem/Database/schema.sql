
CREATE TABLE VehicleLocations (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    VehicleId NVARCHAR(50) NOT NULL,
    Latitude DECIMAL(9,6) NOT NULL,
    Longitude DECIMAL(9,6) NOT NULL,
    Timestamp DATETIME NOT NULL
);
