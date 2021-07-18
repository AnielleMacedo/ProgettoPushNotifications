using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppBIGTest.Views;

namespace AppBIGTest
{
    public partial class App : Application
    {
        /// <summary>
        /// Account OneSignal: BIGAppPushOneSignalTest //  big.macedoanielle@gmail.com
        /// Account FCM:       BIGAppPushFirebase
        /// </summary>
        public App()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDM4MzYxQDMxMzkyZTMxMmUzMENEQ3FhNzlmdXF2ZlFIL2F2SklIeUJ0VHo2ZXpjM3Mvd3ZjK1NoL3p3VWc9");
            
            InitializeComponent();

            MainPage = new UserFeatures(); 
        }

        protected override void OnStart() 
        {
        }

        protected override void OnSleep()
        {

        }

        protected override void OnResume()
        {
        }
    }
}
