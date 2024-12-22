
SELECT VehicleId, Latitude, Longitude, Timestamp
FROM VehicleLocations
WHERE Timestamp = (
    SELECT MAX(Timestamp) 
    FROM VehicleLocations AS InnerQuery
    WHERE InnerQuery.VehicleId = VehicleLocations.VehicleId
);
