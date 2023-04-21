using System;
namespace Andrea_Jiwoong_Group7.Models
{
	public class Order
	{
		private string departureStn;
		private string arrivalStn;
		private DateTime departureDate;
		private string seatClass;
		private string seatBerth;
		private string holderName;
		private int age;
		private string gender;
		private string phone;
		private string email;
		private int numberOfPassengers;

        public Order(string departureStn, string arrivalStn, DateTime departureDate, string seatClass, string seatBerth, string holderName, int age, string gender, string phone, string email, int numberOfPassengers)
        {
            this.departureStn = departureStn;
            this.arrivalStn = arrivalStn;
            this.departureDate = departureDate;
            this.seatClass = seatClass;
            this.seatBerth = seatBerth;
            this.holderName = holderName;
            this.age = age;
            this.gender = gender;
            this.phone = phone;
            this.email = email;
            this.numberOfPassengers = numberOfPassengers;
        }

        public string DepartureStn { get => departureStn; set => departureStn = value; }
        public string ArrivalStn { get => arrivalStn; set => arrivalStn = value; }
        public DateTime DepartureDate { get => departureDate; set => departureDate = value; }
        public string SeatClass { get => seatClass; set => seatClass = value; }
        public string SeatBerth { get => seatBerth; set => seatBerth = value; }
        public string HolderName { get => holderName; set => holderName = value; }
        public int Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public int NumberOfPassengers { get => numberOfPassengers; set => numberOfPassengers = value; }
    }
}

