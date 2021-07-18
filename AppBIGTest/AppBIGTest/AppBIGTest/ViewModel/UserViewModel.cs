using AppBIGTest.Model;
using AppBIGTest.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;


namespace AppBIGTest.ViewModel
{
    public class UserViewModel :INotifyPropertyChanged //interface che notifica qualunque alterazioni nella ViewModel alla View
    {
        public string Nome { get; set; }
       
        public string _mensagem { get; set; }
        //public string _picker { get; set; }

        public string Mensagem
        {
            get { return _mensagem; }
            set
            {
                _mensagem = value;
                Notificar();
            }
        }
        public Command InviaMsg {
            get
            {
                return new Command(() =>
                {
                   // _picker.ope  .IsOpen = true;
                    Mensagem = "Bem vinda " + Nome;
                });
            }
        }

        private ObservableCollection<string> _user;

        public event PropertyChangedEventHandler PropertyChanged;

        public void Notificar([CallerMemberName] string prop= "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public ObservableCollection<string> User

        {

            get { return _user; }

            set { _user = value; }

        }

        public UserViewModel()
        {
            User = new ObservableCollection<string>
            {
                "",
                "Subscribed Users",
                "Test Device",
                "Active Users",
                "Inactive Users"
            };

        }

 
    }
}
