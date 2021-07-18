using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppBIGTest.Model
{
    public class AwsTranslateViewModel
    {

        public string ContentPush { get; set; }
        public string SelectedLanguage { get; set; }
        //public List<SelectListItem> SelectedLanguages { get; set; }

        public ObservableCollection<string> Language { get; set; }


        public AwsTranslateViewModel()
        {

            Language = new ObservableCollection<string>
            {
                "",
                "pt",
                "fr",
                "en",
                "es",
                "it"
            };
            //// Set up the target language select
            //SelectedLanguages = new ObservableCollection<SupportedLanguages>
            //{
            //    new SelectListItem() { Text = "Select Language", Value = string.Empty },
            //    new SelectListItem() { Text = "Portuguese (pt)", Value = "pt" },
            //    new SelectListItem() { Text = "French (fr)", Value = "fr" },
            //    new SelectListItem() { Text = "English (en)", Value = "en" },
            //    new SelectListItem() { Text = "Spanish (es)", Value = "es" },
            //    new SelectListItem() { Text = "Italian (it)", Value = "it" }
            //};
        }
       

    }
}
