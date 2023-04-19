using System;
namespace Andrea_Jiwoong_Group7.Models
{
	public class TrainSchedule
	{
		private Dictionary<string, int> distanceDict;
		private Dictionary<string, string> westboundDeparture;
		private Dictionary<string, string> eastboundDeparture;

		public string sampleString = "sample value";

		public TrainSchedule()
		{
			distanceDict = new Dictionary<string, int>();
			westboundDeparture = new Dictionary<string, string>();
			eastboundDeparture = new Dictionary<string, string>();
		}

		public string getSampleValue()
		{
			return this.sampleString;
		}
	}
}

