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

        public string GetTrainNumber(string departureStn,string arrivalStn)
        {
            int deptCoordi = distanceDict[departureStn];
            int arrvCoordi = distanceDict[arrivalStn];

            Random rm = new Random();
            string bound = (deptCoordi < arrvCoordi) ? "Westbound" : "Eastbound";
            string serialNo = (deptCoordi < arrvCoordi) ? rm.Next(410, 420).ToString() : rm.Next(400, 410).ToString();
            return "Canadian " + serialNo + " (" + bound + ")";
        }

        public string GetDepartureDateAndTime(DateTime departureDate, string departureStn, string arrivalStn)
        {
            int deptCoordi = distanceDict[departureStn];
            int arrvCoordi = distanceDict[arrivalStn];

            string deptTime = (deptCoordi < arrvCoordi) ? westboundDeparture[departureStn] : eastboundDeparture[departureStn];
            string date = departureDate.ToString("yyyy-MM-dd") + " " + deptTime;

            return date;
        }

        public int GetDistance(string departure, string arrival)
        {
            int deptCoordi = distanceDict[departure];
            int arrvCoordi = distanceDict[arrival];

            return Math.Abs(deptCoordi - arrvCoordi);
        }
      
        public double GetTotalFare(string dept, string arrv, string seatClass, int age, int numberOfPassengers)
        {
            double basicFare = GetDistance(dept, arrv) * 0.1;

            if (seatClass == "Business")
            {
                basicFare *= 2.5;
            }
            else if (seatClass == "Sleeper-Plus")
            {
                basicFare *= 4;
            }
            else if (seatClass == "Prestige")
            {
                basicFare *= 5;
            }
            if (age <= 17 || age >= 65)
            {
                basicFare *= 0.5;
            }
            basicFare *= numberOfPassengers;
            return basicFare;
        }

        public string FormatTotalFare(double fare)
        {
            return String.Format("{0:C}", fare);
        }
    }
}

