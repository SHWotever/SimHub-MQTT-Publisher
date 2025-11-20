using GameReaderCommon;

namespace SimHub.MQTTPublisher.Payload
{
    public class FlagInformation
    {
        public FlagInformation(GameData data)
        {
            this.Flag_Name = data.NewData.Flag_Name;
			this.Flag_Black = data.NewData.Flag_Black;
			this.Flag_Blue = data.NewData.Flag_Blue;
			this.Flag_Checkered = data.NewData.Flag_Checkered;
			this.Flag_Yellow = data.NewData.Flag_Yellow;
			this.Flag_Green = data.NewData.Flag_Green;
			this.Flag_White = data.NewData.Flag_White;
			this.Flag_Orange = data.NewData.Flag_Orange;
		}

		public string Flag_Name { get; set; }
		public int Flag_Black { get; set; }
        public int Flag_Blue { get; set; }
        public int Flag_Checkered { get; set; }
        public int Flag_Yellow { get; set; }
        public int Flag_Green { get; set; }
        public int Flag_White { get; set; }
		public int Flag_Orange { get; set; }
	}
}