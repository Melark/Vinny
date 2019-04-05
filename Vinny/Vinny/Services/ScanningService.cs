using System.Threading.Tasks;
using Vinny.Interfaces;
using ZXing.Mobile;

namespace Vinny.Services
{
    public class ScanningService : IScannerService
    {
        public async Task<string> ScanBarcode()
        {
            var scanner = new MobileBarcodeScanner();
            var result = await scanner.Scan();
            return result?.Text ?? string.Empty;
        }
    }
}
