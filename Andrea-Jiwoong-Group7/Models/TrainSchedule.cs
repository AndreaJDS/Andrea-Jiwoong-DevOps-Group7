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

            distanceDict.Add("Toronto", 0);
            distanceDict.Add("Winnipeg", 1950);
            distanceDict.Add("Saskatoon", 2700);
            distanceDict.Add("Edmonton", 3200);
            distanceDict.Add("Jasper", 3600);
            distanceDict.Add("Vancouver", 4400);

            westboundDeparture.Add("Toronto", "09:45");
            westboundDeparture.Add("Winnipeg", "21:30");
            westboundDeparture.Add("Saskatoon", "11:50");
            westboundDeparture.Add("Edmonton", "00:01");
            westboundDeparture.Add("Jasper", "09:30");

            eastboundDeparture.Add("Vancouver", "15:00");
            eastboundDeparture.Add("Jasper", "12:30");
            eastboundDeparture.Add("Edmonton", "19:50");
            eastboundDeparture.Add("Saskatoon", "06:57");
            eastboundDeparture.Add("Winnipeg", "23:30");
        }

        public string GetTrainNumber()
        {
            return "TranNumber";
        }

        public string GetDepartureDateAndTime()
        {
            return "DateAndTime";
        }

        public int GetDistance()
        {
            return 0;
        }

        public double GetTotalFare()
        {
            return 0;
        }

        public string FormatTotalFare(double fare)
        {
            return String.Format("{0:C}", fare);
        }
    }
}

