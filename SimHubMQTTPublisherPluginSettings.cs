namespace SimHub.MQTTPublisher
{
    /// <summary>
    /// Settings class, make sure it can be correctly serialized using JSON.net
    /// </summary>
    public class SimHubMQTTPublisherPluginSettings
    {
        public string Server = "localhost";

        public string Topic = "racing";

        public string Login = "admin";

        public string Password = "admin";
    }
}