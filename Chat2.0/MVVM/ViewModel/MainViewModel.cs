using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Chat2._0.MVVM.Model;
using Chat2._0.Core;

namespace Chat2._0.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public ObservableCollection<MessageModel> Messages { get; set; }

        public ObservableCollection<ContactModel> Contacts { get; set; }

        public RelayCommand SendCommand { get; set; }

        public ContactModel SelectedContact { get; set; }

        private string _message;
        
        private string Message
        {
            get { return _message; }
            set { _message = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();


            SendCommand = new RelayCommand(o =>
            {
                Messages.Add(new MessageModel
                {
                    Message = Message,
                    FristMessage = false
                });

                Message = "";
            });
            

            Messages.Add(new MessageModel
            {
                Username = "Allison",
                UsernameColor = "#409aff",
                ImageSource = "https://w7.pngwing.com/pngs/804/592/png-transparent-physical-education-school-educational-film-learning-people-icon-text-orange-logo.png",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                FristMessage = false,
            });

            for (int i = 0; i < 3; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "Luxury",
                    UsernameColor = "#409aff",
                    ImageSource = "https://w7.pngwing.com/pngs/804/592/png-transparent-physical-education-school-educational-film-learning-people-icon-text-orange-logo.png",
                    Time = DateTime.Now,
                    IsNativeOrigin = true,
                });
            }

            Messages.Add(new MessageModel
            {
                Username = "Allison",
                UsernameColor = "#409aff",
                ImageSource = "https://w7.pngwing.com/pngs/804/592/png-transparent-physical-education-school-educational-film-learning-people-icon-text-orange-logo.png",
                Message = "Last",
                IsNativeOrigin = false,
                FristMessage = false,
            });

            for (int i = 0; i < 5; i++)
            {
                Contacts.Add(new ContactModel
                { 
                    Username = $"Allison {i}",
                     ImageSource = "https://w7.pngwing.com/pngs/804/592/png-transparent-physical-education-school-educational-film-learning-people-icon-text-orange-logo.png",
                     Messages = Messages
                });
        }
    }
}
}

