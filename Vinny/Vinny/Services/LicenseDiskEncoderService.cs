using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vinny.Interfaces;
using Vinny.Models;

namespace Vinny.Services
{
    public class LicenseDiskEncoderService : ILicenseDiskEncoderService
    {
        public LicenseDiskDetails GetLicenseDiskDetails(string barcodeString)
        {
            LicenseDiskDetails licenseDiskDetails = new LicenseDiskDetails();

            if ( !string.IsNullOrEmpty(barcodeString))
            {

                List<String> licenseDiskSections = barcodeString.Split('%').ToList();

                if (licenseDiskSections.Count != 16)
                {
                    return null;
                }

                licenseDiskDetails.VehicleRegistrationNumber = licenseDiskSections[7];
                licenseDiskDetails.VinNumber = licenseDiskSections[12];
                licenseDiskDetails.EngineNumber = licenseDiskSections[13];
                licenseDiskDetails.LicenseDiskNumber = licenseDiskSections[5];
                licenseDiskDetails.LicenseNumber = licenseDiskSections[6];
                licenseDiskDetails.VehicleMake = licenseDiskSections[9];
                licenseDiskDetails.VehicleModel = licenseDiskSections[10];
                licenseDiskDetails.Description = licenseDiskSections[8];
                licenseDiskDetails.VehicleColor = licenseDiskSections[11];
                licenseDiskDetails.LicenseExpiryDate = DateTime.Parse(licenseDiskSections[14]);
            }

            return licenseDiskDetails;
        }
    }
}
