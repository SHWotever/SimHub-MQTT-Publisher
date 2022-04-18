using GameReaderCommon;

namespace SimHub.MQTTPublisher.Payload
{
    public class CarState
    {
        private GameData data;

        public CarState(GameData data)
        {
            mSpeed = data.NewData.SpeedKmh;
            mRpm = data.NewData.Rpms;
            mClutch = data.NewData.Clutch;
            mThrottle = data.NewData.Throttle;
            mBrake = data.NewData.Brake;
            mGear = data.NewData.Gear;
        }

        public double mSpeed { get; set; }
        public double mRpm { get; set; }
        public double mBrake { get; set; }
        public double mThrottle { get; set; }
        public double mClutch { get; set; }
        public double mSteering { get; set; }
        public string mGear { get; set; }
    }
}