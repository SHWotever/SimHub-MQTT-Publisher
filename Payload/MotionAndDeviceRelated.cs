using GameReaderCommon;
using System.Collections.Generic;
using System.Linq;

namespace SimHub.MQTTPublisher.Payload
{
    public class MotionAndDeviceRelated
    {
        public MotionAndDeviceRelated(GameData data)
        {
            CarCoordinates = data.NewData.CarCoordinates.ToList();
        }

        public List<double> CarCoordinates { get; set; }
    }
}