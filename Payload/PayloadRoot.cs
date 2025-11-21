using GameReaderCommon;
using System;

namespace SimHub.MQTTPublisher.Payload
{
    public class PayloadRoot
    {
        public PayloadRoot(GameData data, SimHubMQTTPublisherPluginUserSettings userSettings)
        {
            time = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            carState = new Car(data);
            userId = userSettings.UserId.ToString();
            flagData = new FlagInformation(data);
        }

        public long time { get; set; }
        public string userId { get; set; }
        public Car carState { get; set; }
        public FlagInformation flagData { get; set; }
    }
}