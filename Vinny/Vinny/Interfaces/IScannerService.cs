using System.Threading.Tasks;

namespace Vinny.Interfaces
{
    public interface IScannerService
    {
        Task<string> ScanBarcode();
    }
}
