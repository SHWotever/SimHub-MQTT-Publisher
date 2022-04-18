using GameReaderCommon;

namespace SimHub.MQTTPublisher.Payload
{
    public class VehicleInformation
    {

        public VehicleInformation(GameData data)
        {
            this.mCarName = data.NewData.CarModel;
            this.mCarClassName = data.NewData.CarClass;
        }

        public string mCarName { get; set; }
        public string mCarClassName { get; set; }
    }
}
