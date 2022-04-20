using GameReaderCommon;

namespace SimHub.MQTTPublisher.Payload
{
    public class CarState
    {
        public CarState(GameData data)
        {
            SpeedKmh = data.NewData.SpeedKmh;
            Rpms = data.NewData.Rpms;
            Clutch = data.NewData.Clutch;
            Throttle = data.NewData.Throttle;
            Brake = data.NewData.Brake;
            Gear = data.NewData.Gear;
        }

        public double SpeedKmh { get; set; }
        public double Rpms { get; set; }
        public double Brake { get; set; }
        public double Throttle { get; set; }
        public double Clutch { get; set; }
        public string Gear { get; set; }
    }
}