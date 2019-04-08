using System;
using System.Threading.Tasks;
using Vinny.Interfaces;
using Xamarin.Forms;
using ZXing.Mobile;

namespace Vinny.Services
{
    public class ScanningService : IScannerService
    {
        public async Task<string> ScanBarcode()
        {
            try
            {
                var scanner = new MobileBarcodeScanner();
                var result = await scanner.Scan();
                return result?.Text ?? string.Empty;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
