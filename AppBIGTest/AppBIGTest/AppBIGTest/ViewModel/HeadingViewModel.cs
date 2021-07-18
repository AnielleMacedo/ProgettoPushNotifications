using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppBIGTest.ViewModel
{
    public class HeadingViewModel
    {
        private ObservableCollection<string> _heading;

        public ObservableCollection<string> Heading

        {

            get { return _heading; }

            set { _heading = value; }

        }

        public HeadingViewModel()
        {
            Heading = new ObservableCollection<string>
            {
                "",
                "BIGStudio",
                "BIGStudio Impianto X",
                "BIGStudio Impianto Y"
            };
        }
    }
}
