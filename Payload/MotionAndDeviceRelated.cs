using GameReaderCommon;
using System.Collections.Generic;
using System.Linq;

namespace SimHub.MQTTPublisher.Payload
{
    public class MotionAndDeviceRelated
    {
        public MotionAndDeviceRelated(GameData data)
        {
            mOrientation = data.NewData.CarCoordinates.ToList();
        }

        public List<double> mOrientation { get; set; }
    }
}