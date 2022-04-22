using GameReaderCommon;

namespace SimHub.MQTTPublisher.Payload
{
    public class TrackInformation
    {
        public TrackInformation(GameData data)
        {
            this.TrackId = data.NewData.TrackId;
            this.TrackConfig = data.NewData.TrackConfig;
            this.TrackCode = data.NewData.TrackCode;
            this.TrackLength = data.NewData.TrackLength;
        }

        public string TrackId { get; set; }

        public string TrackConfig { get; set; }

        public string TrackCode { get; set; }

        public double TrackLength { get; set; }
    }
}