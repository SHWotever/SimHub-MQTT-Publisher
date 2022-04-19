using SimHub.MQTTPublisher.ViewModels;
using System.Windows.Controls;

namespace SimHub.MQTTPublisher.Settings
{
    /// <summary>
    /// Logique d'interaction pour SimHubMQTTPublisherPluginUI.xaml
    /// </summary>
    public partial class SimHubMQTTPublisherPluginUI : UserControl
    {
        public SimHubMQTTPublisherPluginUI(SimHubMQTTPublisherPlugin simHubMQTTPublisherPlugin)
        {
            InitializeComponent();
            SimHubMQTTPublisherPlugin = simHubMQTTPublisherPlugin;

            this.Model = new SimHubMQTTPublisherPluginUIModel()
            {
                Server = simHubMQTTPublisherPlugin.Settings.Server,
                Topic = simHubMQTTPublisherPlugin.Settings.Topic,
                Login = simHubMQTTPublisherPlugin.Settings.Login,
                Password = simHubMQTTPublisherPlugin.Settings.Password,
                UserId = simHubMQTTPublisherPlugin.UserSettings.UserId,
            };

            this.DataContext = Model;
        }

        private SimHubMQTTPublisherPluginUIModel Model { get; }

        private SimHubMQTTPublisherPlugin SimHubMQTTPublisherPlugin { get; }

        private void Apply_Settings(object sender, System.Windows.RoutedEventArgs e)
        {
            SimHubMQTTPublisherPlugin.Settings.Server = Model.Server;
            SimHubMQTTPublisherPlugin.Settings.Topic = Model.Topic;
            SimHubMQTTPublisherPlugin.Settings.Login = Model.Login;
            SimHubMQTTPublisherPlugin.Settings.Password = Model.Password;

            SimHubMQTTPublisherPlugin.CreateMQTTClient();
        }
    }
}