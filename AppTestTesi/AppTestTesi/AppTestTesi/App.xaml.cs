using Com.OneSignal;
using Com.OneSignal.Abstractions;
using Xamarin.Forms;

namespace AppTestTesi
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            //Remove this method to stop OneSignal Debugging  
            OneSignal.Current.SetLogLevel(LOG_LEVEL.VERBOSE, LOG_LEVEL.NONE);
            OneSignal.Current.StartInit("9b1d6a06-3c05-45df-aa3d-1ff1d3fb9ae9").EndInit();

            

        }

        protected override void OnStart()
        {
            // OneSignal.Current.RegisterForPushNotifications();
            OneSignal.Current.RegisterForPushNotifications();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
