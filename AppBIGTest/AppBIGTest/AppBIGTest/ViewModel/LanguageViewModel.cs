using AppBIGTest.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace AppBIGTest.ViewModel
{
    public class LanguageViewModel //: INotifyPropertyChanged
    {
        //public string _message { get; set; }

        //public string Message
        //{
        //    get { return _message; }
        //    set
        //    {
        //        _message = value;
        //        NotifyLanguage();
        //    }
        //}
        //public Command AlertLanguage
        //{
        //    get
        //    {
        //        return new Command(() =>
        //        {
                    
        //            Message = "era";
        //        });
        //    }
        //}

        //public event PropertyChangedEventHandler PropertyChanged;

        //public void NotifyLanguage([CallerMemberName] string prop = "")
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        //}


        private ObservableCollection<string> _language;

       

        public ObservableCollection<string> Language

        {

            get { return _language; }

            set { _language = value; }

        }

        public LanguageViewModel()
        {
           
            Language = new ObservableCollection<string>();
            Language.Add("");
            Language.Add("it");
            Language.Add("en");
            Language.Add("pt");
            Language.Add("es");
            Language.Add("fr");

            

        }

    }
}
