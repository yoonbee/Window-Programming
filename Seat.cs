using System;

namespace WindowsFormsApp9
{
	public class Seat
	{
		public int SeatNo { get; set; }
		public bool IsAvailable { get; set; }
		public string StdName { get; set; }
		public string StdNo { get; set; }

		public Seat() { }
		public Seat(int SeatNo)
		{
			this.SeatNo = SeatNo;
			IsAvailable = true;
		}

		public Seat(int SeatNo, bool IsAvailable, string StdName, string StdNo)
		{
			this.SeatNo = SeatNo;
			this.IsAvailable = IsAvailable;
			this.StdName = StdName;
			this.StdNo = StdNo;
		}
	}
}
