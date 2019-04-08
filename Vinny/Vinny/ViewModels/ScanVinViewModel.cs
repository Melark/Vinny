using System;
using System.Windows.Input;
using Vinny.Interfaces;
using Vinny.Models;
using Vinny.Services;
using Vinny.ViewModels.Base;
using Xamarin.Forms;

namespace Vinny.ViewModels
{
    public class ScanVinViewModel : ViewModelBase
    {
        IScannerService _scannerService;
        ILicenseDiskEncoderService _licenseDiskEncoderService;

        public ScanVinViewModel()
        {
            // do with DI
            _scannerService = new ScanningService();
            _licenseDiskEncoderService = new LicenseDiskEncoderService();
        }

        private string _vehicleRegistrationNumber;
        public string VehicleRegistrationNumber
        {
            get => _vehicleRegistrationNumber;
            set
            {
                _vehicleRegistrationNumber = value;
                OnPropertyChanged();
            }
        }


        private string _vinNumber;
        public string VinNumber
        {
            get => _vinNumber;
            set
            {
                _vinNumber = value;
                OnPropertyChanged();
            }
        }

        private string _engineNumber;
        public string EngineNumber
        {
            get => _engineNumber;
            set
            {
                _engineNumber = value;
                OnPropertyChanged();
            }
        }

        private string _licenseDiskNumber;
        public string LicenseDiskNumber
        {
            get => _licenseDiskNumber;
            set
            {
                _licenseDiskNumber = value;
                OnPropertyChanged();
            }
        }

        private string _licenseNumber;
        public string LicenseNumber
        {
            get => _licenseNumber;
            set
            {
                _licenseNumber = value;
                OnPropertyChanged();
            }
        }

        private string _vehicleMake;
        public string VehicleMake
        {
            get => _vehicleMake;
            set
            {
                _vehicleMake = value;
                OnPropertyChanged();
            }
        }

        private string _vehicleModel;
        public string VehicleModel
        {
            get => _vehicleModel;
            set
            {
                _vehicleModel = value;
                OnPropertyChanged();
            }
        }

        private string _description;
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged();
            }
        }

        private string _vehicleColor;
        public string VehicleColor
        {
            get => _vehicleColor;
            set
            {
                _vehicleColor = value;
                OnPropertyChanged();
            }
        }

        private DateTime _licenseExpiryDate;
        public DateTime LicenseExpiryDate
        {
            get => _licenseExpiryDate;
            set
            {
                _licenseExpiryDate = value;
                OnPropertyChanged();
            }
        }

        public ICommand ScanBarcodeCommand
        {
            get
            {
                return new Command(async () =>
                {
                    string barcodeValue = await _scannerService.ScanBarcode();
                    LicenseDiskDetails licenseDiskDetails = _licenseDiskEncoderService.GetLicenseDiskDetails(barcodeValue);

                    if (licenseDiskDetails != null)
                    {
                        VehicleRegistrationNumber = licenseDiskDetails.VehicleRegistrationNumber;
                        VinNumber = licenseDiskDetails.VinNumber;
                        EngineNumber = licenseDiskDetails.EngineNumber;
                        LicenseDiskNumber = licenseDiskDetails.LicenseDiskNumber;
                        LicenseNumber = licenseDiskDetails.LicenseNumber;
                        VehicleMake = licenseDiskDetails.VehicleMake;
                        VehicleModel = licenseDiskDetails.VehicleModel;
                        Description = licenseDiskDetails.Description;
                        VehicleColor = licenseDiskDetails.VehicleColor;
                        LicenseExpiryDate = licenseDiskDetails.LicenseExpiryDate;
                    }
                });
            }
        }
    }
}
