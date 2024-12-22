
document.addEventListener('DOMContentLoaded', () => {
    async function fetchLocations() {
        const response = await fetch('/api/vehicles/locations');
        const data = await response.json();
        document.getElementById('vehicle-list').innerHTML = JSON.stringify(data, null, 2);
    }
    setInterval(fetchLocations, 30000);
    fetchLocations();
});
