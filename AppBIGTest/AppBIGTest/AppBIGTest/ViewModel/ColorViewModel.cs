using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppBIGTest.ViewModel
{
    public class ColorViewModel
    {

        private ObservableCollection<string> _color;

        public ObservableCollection<string> Colors

        {

            get { return _color; }
            set { _color = value; }

        }

        public ColorViewModel()
        {
            Colors = new ObservableCollection<string>
            {
                //Colors.Add("");  //ver como deixar primeira linha nulla no picker
                "White",
                "Red",
                "Green",
                "Yellow",
                "Blue",
                "Black",
                "Gray"
            };
        }
    }
}
