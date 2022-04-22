using GameReaderCommon;

namespace SimHub.MQTTPublisher.Payload
{
    public class VehicleInformation
    {
        public VehicleInformation(GameData data)
        {
            this.CarModel = data.NewData.CarModel;
            this.CarClass = data.NewData.CarClass;
            this.CarId = data.NewData.CarId;
            this.MaxRpm = data.NewData.MaxRpm;
        }

        public string CarModel { get; set; }

        public string CarClass { get; set; }

        public string CarId { get; set; }

        public double MaxRpm { get; set; }
    }
}