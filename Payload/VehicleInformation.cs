using GameReaderCommon;

namespace SimHub.MQTTPublisher.Payload
{
    public class VehicleInformation
    {
        public VehicleInformation(GameData data, SimHubMQTTPublisherPluginUserSettings userSettings)
        {
            this.mCarName = data.NewData.CarModel;
            this.mCarClassName = data.NewData.CarClass;
            this.mUserUUID = userSettings.UserId.ToString();
        }

        public string mCarName { get; set; }

        public string mCarClassName { get; set; }

        public string mUserUUID { get; set; }
    }
}