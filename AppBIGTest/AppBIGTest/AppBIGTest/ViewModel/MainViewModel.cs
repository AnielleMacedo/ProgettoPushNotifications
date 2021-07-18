using System;
using System.Collections.Generic;
using System.Text;

namespace AppBIGTest.ViewModel
{
    public class MainViewModel
    {
       
        public ColorViewModel ColorViewModel { get; }
        public ContentViewModel ContentViewModel { get; }
        public DeviceViewModel DeviceViewModel { get; }
        public HeadingViewModel HeadingViewModel { get; }
        public LanguageViewModel LanguageViewModel { get; }
        public UserViewModel UserViewModel { get; }


        //instantiate viewsmodels
        public MainViewModel()
        {

            ColorViewModel = new ColorViewModel();
           
            ContentViewModel = new ContentViewModel();

            DeviceViewModel = new DeviceViewModel();

            HeadingViewModel = new HeadingViewModel();

            LanguageViewModel = new LanguageViewModel();

            UserViewModel = new UserViewModel();
        }
        
            
        
    }
}
