using GameReaderCommon;
using System.Collections.Generic;

namespace SimHub.MQTTPublisher.Payload
{
    public class MotionAndDeviceRelated
    {
        
        public MotionAndDeviceRelated(GameData data)
        {
            
        }

        public List<double> mOrientation { get; set; }
    }
}
