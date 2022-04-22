using System;

namespace SimHub.MQTTPublisher
{
    /// <summary>
    /// Settings class, make sure it can be correctly serialized using JSON.net
    /// </summary>
    public class SimHubMQTTPublisherPluginSettings
    {
        public string Server { get; set; } = "localhost";

        public string Topic { get; set; } = "racing/driver_name";

        public string Login { get; set; } = "admin";

        public string Password { get; set; } = "admin";
    }

    public class SimHubMQTTPublisherPluginUserSettings
    {
        public Guid UserId { get; set; } = Guid.NewGuid();

    }
}