using AppBIGTest.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppBIGTest.ViewModel
{
    public class DeviceViewModel
    {

        private ObservableCollection<string> _device;

        public ObservableCollection<string> Device

        {

            get { return _device; }

            set { _device = value; }

        }

        public DeviceViewModel()
        {
            //add elements device
            Device = new ObservableCollection<string>
            {
                "",
                "Android",
                "iOS",
                "Windows Phone"
            };

        }
    }
}
