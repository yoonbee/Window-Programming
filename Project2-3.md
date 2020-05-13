Student.cs

```c#
using System;

namespace WindowsFormsApp9
{
	public class Student
	{
		private string stdName;
		private string stdNo;

		public String StdName
		{
			get { return stdName; }
			set { stdName = value; }
		}
		public String StdNo
		{
			get { return stdNo; }
			set { stdNo = value; }
		}

		// 생성자
		public Student() { }
		public Student(string stdName, string stdNo)
		{
			this.stdName = stdName;
			this.stdNo = stdNo;
		}
	}
}

```

Seat.cs

```c#
using System;

namespace WindowsFormsApp9
{
	public class Seat
	{
		public int index;
		private Student std;

		public Student Std
		{
			get { return std; }
			set { std = value; }
		}

		// 생성자
		public Seat(int index)
		{
			this.index = index;
		}
		public Seat(int index, Student std)
		{
			this.index = index;
			this.std = std;
		}

		public Boolean IsAvailable()
		{
			if (std == null)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}

```

Form1.cs

```c#
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
	public partial class Form1 : Form
	{
		// 전체 좌석 수(상수)
		public const int totalNum = 120;
		
		Button[] btnSeat = new Button[totalNum];
		List<Seat> seats = new List<Seat>();

		public Form1()
		{
			InitializeComponent();

			// 독서실 현황
			// 전체 좌석 수 
			lbTotal.Text = totalNum.ToString();

			int index = 0;
			for(int i=0; i<4; i++)
			{
				for(int j=0; j<30; j++)
				{
					index = i * 30 + j;

					Seat tempSeat = new Seat(index);
									
					seats.Add(tempSeat);

					btnSeat[index] = new Button();
					btnSeat[index].Text = (index + 1).ToString();
					btnSeat[index].Size = new Size(35, 35);
					btnSeat[index].Location = new Point(10 + j * 35, 15 + i * 35);

					if (seats[index].IsAvailable()==true)
					{
						btnSeat[index].BackColor = Color.CornflowerBlue;
					}

					btnSeat[index].Click += BtnSeat_Click;

					gbSeat.Controls.Add(btnSeat[index]);
				}
			}
			
		}

		private void BtnSeat_Click(object sender, EventArgs e)
		{
			Button clickedButton = (Button)sender;
			int index = Int32.Parse(clickedButton.Text) - 1;

			tbSeatNo.Text = (index + 1).ToString();

			if (seats[index].IsAvailable() == true)
			{
				tbStdName.Text = "";
				tbStdNo.Text = "";
			}
			else
			{
				tbStdName.Text = seats[index].Std.StdName;
				tbStdNo.Text = seats[index].Std.StdNo;
			}

		}

		private void BtnBooking_Click(object sender, EventArgs e)
		{
		}


		public void PrintDgv()
		{

		}
	}
}

```

