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


			// 좌석 현황
			int index = 0;
			for(int i=0; i<4; i++)
			{
				for(int j=0; j<30; j++)
				{
					index = i * 30 + j;

					Seat tempSeat;

					if (index % 2 == 0)
					{
						tempSeat = new Seat(index);
					}
					else
					{
						tempSeat = new Seat(index, new Student("이름", "학번"));
					}
									
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
			
			// 선택된 좌석이 예약 가능할 때
			if (seats[index].IsAvailable() ==true)
			{
				tbStdName.Text = "";
				tbStdNo.Text = "";
			}
			// 선택된 좌석이 사용 중일 때
			else
			{
				tbStdName.Text = seats[index].Std.StdName;
				tbStdNo.Text = seats[index].Std.StdNo;
			}

		}

		private void BtnBooking_Click(object sender, EventArgs e)
		{
			int index = Int32.Parse(tbSeatNo.Text) - 1;

			// 선택된 좌석이 예약 가능할 때
			if (seats[index].IsAvailable() == true)
			{
				Form2 form2 = new Form2();
				form2.ShowDialog();
			}
			// 선택된 좌석이 사용 중일 때
			else
			{
				MessageBox.Show("현재 사용중인 좌석입니다.");
			}
		}


		public void PrintDgv()
		{

		}
	}
}

```

Form2.cs

```c#
using System;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
	public partial class Form2 : Form
	{
		
		public Form2()
		{
			InitializeComponent();

		}

		private void BtnOk_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

```

