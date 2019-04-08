using Vinny.Models;

namespace Vinny.Interfaces
{
    public interface ILicenseDiskEncoderService
    {
        LicenseDiskDetails GetLicenseDiskDetails(string barcodeString);
    }
}
