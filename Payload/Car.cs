using GameReaderCommon;
using System.Collections.Generic;
using System.Linq;

namespace SimHub.MQTTPublisher.Payload
{
    public class Car
    {
        public Car(GameData data)
        {
            SpeedKmh = data.NewData.SpeedKmh;
            Rpms = data.NewData.Rpms;
            Clutch = data.NewData.Clutch;
            Throttle = data.NewData.Throttle;
            Brake = data.NewData.Brake;
            Gear = data.NewData.Gear;
            CarCoordinates = data.NewData.CarCoordinates.ToList();
            CurrentLapTime = data.NewData.CurrentLapTime.TotalMilliseconds;
            CarModel = data.NewData.CarModel;
            CarClass = data.NewData.CarClass;
        }

        public double SpeedKmh { get; set; }
        public double Rpms { get; set; }
        public double Brake { get; set; }
        public double Throttle { get; set; }
        public double Clutch { get; set; }
        public string Gear { get; set; }
        public List<double> CarCoordinates { get; set; }
        public double CurrentLapTime { get; set; }
        public string CarModel { get; set; }
        public string CarClass { get; set; }
    }
}