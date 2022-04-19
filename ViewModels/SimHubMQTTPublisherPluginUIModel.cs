using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SimHub.MQTTPublisher.ViewModels
{
    internal class SimHubMQTTPublisherPluginUIModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _server;

        private string _topic;

        private string _login;

        private string _password;

        public string Server
        {
            get => _server;
            set
            {
                _server = value;
                OnPropertyChanged();
            }
        }

        public string Topic
        {
            get => _topic;
            set
            {
                _topic = value;
                OnPropertyChanged();
            }
        }

        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}