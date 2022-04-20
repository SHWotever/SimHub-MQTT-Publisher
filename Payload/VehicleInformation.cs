using GameReaderCommon;

namespace SimHub.MQTTPublisher.Payload
{
    public class VehicleInformation
    {
        public VehicleInformation(GameData data)
        {
            this.CarModel = data.NewData.CarModel;
            this.CarClass = data.NewData.CarClass;
        }

        public string CarModel { get; set; }

        public string CarClass { get; set; }
    }
}