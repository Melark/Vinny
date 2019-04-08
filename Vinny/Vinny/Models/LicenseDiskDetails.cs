using System;

namespace Vinny.Models
{
    public class LicenseDiskDetails
    {
        public string VehicleRegistrationNumber { get; set; }
        public string VinNumber { get; set; }
        public string EngineNumber { get; set; }
        public string LicenseDiskNumber { get; set; }
        public string LicenseNumber { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public string Description { get; set; }
        public string VehicleColor { get; set; }
        public DateTime LicenseExpiryDate { get; set; }
    }
}
