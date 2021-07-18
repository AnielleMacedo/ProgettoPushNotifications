using Amazon;
using Amazon.Translate;
using Amazon.Translate.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace provaAmazon
{
    public partial class MainPage : ContentPage
    {
        AwsTranslatePush aws = new AwsTranslatePush();
        public MainPage()
        {
            InitializeComponent();
        }

        private void BotaoTranslate_Clicked(object sender, EventArgs e)
        {
            if (textoPraTraduzir.Text != "")
            {
                outputTranslated.Text = textoPraTraduzir.Text;
            }
            else
            {
                outputTranslated.Text = "";
            }   

            //var translate = new AmazonTranslateClient(RegionEndpoint.USWest2);

            //var request = new TranslateTextRequest()
            //{
            //    Text = textoPraTraduzir.Text, //testo da tradurre
            //    SourceLanguageCode = "auto", //lingua detectada pela api Aamazon automaticament
            //    TargetLanguageCode = "pt", //lingua escolhida pelo usuario

            //};
            //var resultTranslated = translate.TranslateTextAsync(request);
            //var resultTranslatedString = resultTranslated.ToString();

            //outputTranslated.Text = resultTranslatedString;
        }
    }
}
