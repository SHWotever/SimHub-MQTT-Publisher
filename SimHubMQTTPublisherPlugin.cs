﻿using GameReaderCommon;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using Newtonsoft.Json;
using SimHub.Plugins;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media;

namespace SimHub.MQTTPublisher
{
    [PluginDescription("MQTT Publisher")]
    [PluginAuthor("Wotever")]
    [PluginName("MQTT Publisher")]
    public class SimHubMQTTPublisherPlugin : IPlugin, IDataPlugin, IWPFSettingsV2
    {
        public SimHubMQTTPublisherPluginSettings Settings;
        private MqttFactory mqttFactory;
        private IMqttClient mqttClient;

        /// <summary>
        /// Instance of the current plugin manager
        /// </summary>
        public PluginManager PluginManager { get; set; }

        /// <summary>
        /// Gets the left menu icon. Icon must be 24x24 and compatible with black and white display.
        /// </summary>
        public ImageSource PictureIcon => this.ToIcon(Properties.Resources.sdkmenuicon);

        /// <summary>
        /// Gets a short plugin title to show in left menu. Return null if you want to use the title as defined in PluginName attribute.
        /// </summary>
        public string LeftMenuTitle => "MQTT Publisher";

        /// <summary>
        /// Called one time per game data update, contains all normalized game data,
        /// raw data are intentionnally "hidden" under a generic object type (A plugin SHOULD NOT USE IT)
        ///
        /// This method is on the critical path, it must execute as fast as possible and avoid throwing any error
        ///
        /// </summary>
        /// <param name="pluginManager"></param>
        /// <param name="data">Current game data, including current and previous data frame.</param>
        public void DataUpdate(PluginManager pluginManager, ref GameData data)
        {
            // Define the value of our property (declared in init)
            if (data.GameRunning)
            {
                var applicationMessage = new MqttApplicationMessageBuilder()
               .WithTopic(Settings.Topic)
               .WithPayload(JsonConvert.SerializeObject(new Payload.PayloadRoot(data)))
               .Build();

                Task.Run(async () => await mqttClient.PublishAsync(applicationMessage, CancellationToken.None)).Wait();
            }
        }

        /// <summary>
        /// Called at plugin manager stop, close/dispose anything needed here !
        /// Plugins are rebuilt at game change
        /// </summary>
        /// <param name="pluginManager"></param>
        public void End(PluginManager pluginManager)
        {
            // Save settings
            this.SaveCommonSettings("GeneralSettings", Settings);
            mqttClient.Dispose();
        }

        /// <summary>
        /// Returns the settings control, return null if no settings control is required
        /// </summary>
        /// <param name="pluginManager"></param>
        /// <returns></returns>
        public System.Windows.Controls.Control GetWPFSettingsControl(PluginManager pluginManager)
        {
            return null;
        }

        /// <summary>
        /// Called once after plugins startup
        /// Plugins are rebuilt at game change
        /// </summary>
        /// <param name="pluginManager"></param>
        public void Init(PluginManager pluginManager)
        {
            SimHub.Logging.Current.Info("Starting plugin");

            // Load settings
            Settings = this.ReadCommonSettings<SimHubMQTTPublisherPluginSettings>("GeneralSettings", () => new SimHubMQTTPublisherPluginSettings());

            this.mqttFactory = new MqttFactory();

            mqttClient = mqttFactory.CreateMqttClient();

            var mqttClientOptions = new MqttClientOptionsBuilder()
               .WithTcpServer(Settings.Server)
               .WithCredentials(Settings.Login, Settings.Password)
               .Build();

            mqttClient.ConnectAsync(mqttClientOptions, CancellationToken.None);
        }
    }
}