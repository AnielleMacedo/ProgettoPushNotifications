using BIGPushDll;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBIGTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserFeatures : ContentPage
    {
        public BIGOneSignalPushNotification push = null;

        public UserFeatures()
        {
            InitializeComponent();
         
        }

       
        private void BtnSend_Clicked(object sender, EventArgs e)
        {
            try
            {
                InitializePushService();
                CleanFields();
            }
            catch (Exception ex)
            {
                DisplayAlert("Alert", "Push not sent! " + ex.Message, "OK");
            }
        }

       

        private async void InitializePushService()
        {
            //Nota: per utilizzare un servizio di traduzione per la push ci sono delle Api a pagamento: Google Translator e  Amazon Translate 
            string inputContentPush = inputContent.Text;
            string userPush = inputUser.Text;
            string headingPush = inputHeading.Text;
            string headingColor = inputHeadColor.Text;
            string contentColor = inputContColor.Text;
            string imageSet = "https://i.ibb.co/mFZW2zN/bigApp.jpg";
            string imageNotSet = "";


            try
            {

                if (inputContentPush != "") //&& (user != "") && (heading != "")
                {
                   
                    //call the send function from my DLL with input features  | IncludedSegment.TEST_DEVICE
                    push = new BIGOneSignalPushNotification();
                   

                    if (lblSwichtImg.Text == "Image set")
                    {

                        bool result = await push.SendPushNotificationsAndroid(inputContentPush, userPush, headingPush, headingColor, contentColor, imageSet);

                        if (result)
                        {
                            await DisplayAlert("Notification", "Sent!", "Ok");
                        }
                    }
                    else
                    {
                        bool result = await push.SendPushNotificationsAndroid(inputContentPush, userPush, headingPush, headingColor, contentColor, imageNotSet);
                        if (result)
                        {
                            await DisplayAlert("Notification", "Sent!", "Ok");
                        }
                    }

                }
                else
                {
                    await DisplayAlert("Alert", "Compile fields", "Ok");
                }

            }
            catch (Exception ex)

            {
                await DisplayAlert("Alert", "Notification is not sent: " + ex.Message, "OK");
            }


        }


        private void BtClean_Clicked(object sender, EventArgs e)
        {
            CleanFields();
        }

        private void CleanFields()
        {
            inputContent.Text = "";
            inputHeadColor.Text = "";
            inputContColor.Text = "";
            inputHeading.Text = "";
            inputUser.Text = "";
            inputLanguage.Text = "";
            inputDevice.Text = "";
            switchSetImage.IsToggled = false;
        }



        //Functions to SelectionChange Items
        private void PickerContentColor_SelectionChanged(object sender, Syncfusion.SfPicker.XForms.SelectionChangedEventArgs e)
        {
            if (e.NewValue != null)
            {

                var colorContent = PickerHelper.GetColor(e.NewValue.ToString());

                if ((Device.RuntimePlatform == Device.Android) || (Device.RuntimePlatform == Device.iOS))
                {

                    var outputContentColor = (string)pickerContentColor.SelectedItem;

                    if (outputContentColor == "Red")
                        inputContColor.Text = "FFFF0000";
                    if (outputContentColor == "Blue")
                        inputContColor.Text = "FF0000FF";
                    if (outputContentColor == "Green")
                        inputContColor.Text = "FF00FF00";
                    if (outputContentColor == "Yellow")
                        inputContColor.Text = "FFFFFF00";
                    if (outputContentColor == "Black")
                        inputContColor.Text = "FF000000";
                    if (outputContentColor == "Gray")
                        inputContColor.Text = "FF808080";

                    pickerContentColor.BackgroundColor = Color.FromRgba(colorContent.R, colorContent.G, colorContent.B, 0.6); //trasparenza

                }
                else
                    pickerContentColor.SelectionBackgroundColor = colorContent;

            }
        }

        private void PickerHeadingColor_SelectionChanged(object sender, Syncfusion.SfPicker.XForms.SelectionChangedEventArgs e)
        {
            if (e.NewValue != null)
            {

                var colorHead = PickerHelper.GetColor(e.NewValue.ToString());

                if ((Device.RuntimePlatform == Device.Android) || (Device.RuntimePlatform == Device.iOS))
                {

                    var outputHeadColor = (string)pickerHeadingColor.SelectedItem;

                    if (outputHeadColor == "Red")
                        inputHeadColor.Text = "FFFF0000";
                    if (outputHeadColor == "Blue")
                        inputHeadColor.Text = "FF0000FF";
                    if (outputHeadColor == "Green")
                        inputHeadColor.Text = "FF00FF00";
                    if (outputHeadColor == "Yellow")
                        inputHeadColor.Text = "FFFFFF00";
                    if (outputHeadColor == "Black")
                        inputHeadColor.Text = "FF000000";
                    if (outputHeadColor == "Gray")
                        inputHeadColor.Text = "FF808080";

                    pickerHeadingColor.BackgroundColor = Color.FromRgba(colorHead.R, colorHead.G, colorHead.B, 0.6); 

                }
                else
                    pickerHeadingColor.SelectionBackgroundColor = colorHead;

            }
        }


        private void PickerUser_SelectionChanged(object sender, Syncfusion.SfPicker.XForms.SelectionChangedEventArgs e)
        {
            //if (e.NewValue != null)
            //{

            var user = e.NewValue.ToString();
            inputUser.Text = user;

            //}
        }

        private void PickerHeading_SelectionChanged(object sender, Syncfusion.SfPicker.XForms.SelectionChangedEventArgs e)
        {
            inputHeading.Text = e.NewValue.ToString();
        }

        private void PickerLanguage_SelectionChanged(object sender, Syncfusion.SfPicker.XForms.SelectionChangedEventArgs e)
        {
            
            if (e.NewValue != null)
            {
                inputLanguage.Text = e.NewValue.ToString();
                
            }

        }
        

        private void PickerDevice_SelectionChanged(object sender, Syncfusion.SfPicker.XForms.SelectionChangedEventArgs e)
        {
            inputDevice.Text = e.NewValue.ToString();
        }

        //buttons
        private void BtnUser_Clicked(object sender, EventArgs e)
        {
            pickerUser.IsOpen = true;
        }

        private void BtnHeading_Clicked(object sender, EventArgs e)
        {
            pickerHeading.IsOpen = true;
        }

        private void BtnHeadingColor_Clicked(object sender, EventArgs e)
        {
            pickerHeadingColor.IsOpen = true;

        }

        private void BtnContentColor_Clicked(object sender, EventArgs e)
        {
            pickerContentColor.IsOpen = true;
        }


        private void BtnLanguage_Clicked(object sender, EventArgs e)
        {
            // To use a translation system, access the automatic keyboard translator
            DisplayAlert("Alert", "Per utilizzare un sistema di traduzione, accedere al traduttore automatico della tastiera", "ok");
            pickerLanguage.IsOpen = false;

        }

        private void BtnDevice_Clicked(object sender, EventArgs e)
        {
            pickerDevice.IsOpen = true;
        }

        private void SwitchSetImage_Toggled(object sender, ToggledEventArgs e)
        {
            bool swicthValue = e.Value;
            if (swicthValue == true)
                lblSwichtImg.Text = "Image set";
            else
                lblSwichtImg.Text = "Image not set";
        }

       

      
    }
}
