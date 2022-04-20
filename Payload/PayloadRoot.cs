using GameReaderCommon;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimHub.MQTTPublisher.Payload
{

    public class PayloadRoot
    {
        
        public PayloadRoot(GameData data, SimHubMQTTPublisherPluginUserSettings userSettings)
        {
            time = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            vehicleInformation = new VehicleInformation(data, userSettings);
            carState = new CarState(data);
            motionAndDeviceRelated = new MotionAndDeviceRelated(data);

        }

        public long time { get; set; }
        public VehicleInformation vehicleInformation { get; set; }
        public CarState carState { get; set; }
        public MotionAndDeviceRelated motionAndDeviceRelated { get; set; }
    }
}
