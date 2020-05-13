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
						tempSeat = new Seat(index, new Student("이름"+(index+1).ToString(),"학번" + (index + 1).ToString()));
					}
									
					seats.Add(tempSeat);

					btnSeat[index] = new Button();
					btnSeat[index].Text = (index + 1).ToString();
					btnSeat[index].Size = new Size(35, 35);
					btnSeat[index].Location = new Point(10 + j * 35, 15 + i * 35);

					
					// 좌석을 사용 가능할 때
					if (seats[index].IsAvailable()==true)
					{
						btnSeat[index].BackColor = Color.CornflowerBlue;
					}
					// 좌석이 사용 중일 때
					else
					{
						// 사용 중인 학생 정보 업데이트
						AddDgvRow(seats[index]);
						btnSeat[index].BackColor = Color.LightGray;
					}

					btnSeat[index].Click += BtnSeat_Click;

					gbSeat.Controls.Add(btnSeat[index]);
				}
			}

			PrintCondition();
		}


		// 독서실 현황
		public void PrintCondition()
		{
			// 전체 좌석 수 
			lbTotal.Text = totalNum.ToString();
			// 사용 중인 좌석 수
			lbUnavailable.Text= (dgvSeat.RowCount-1).ToString();
			// 사용 가능한 좌석 수
			lbAvailable.Text = (totalNum - dgvSeat.RowCount+1).ToString();
		}


		// 좌석 버튼
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
			// 선택된 좌석이 사용 중일 때 -> 학생 정보 출력
			else
			{
				tbStdName.Text = seats[index].Std.StdName;
				tbStdNo.Text = seats[index].Std.StdNo;
			}

		}


		// 예약 버튼
		private void BtnBooking_Click(object sender, EventArgs e)
		{
			int index = Int32.Parse(tbSeatNo.Text) - 1;

			// 선택된 좌석이 예약 가능할 때 -> 예약 창
			if (seats[index].IsAvailable() == true)
			{
				Form2 form2 = new Form2(this);
				form2.ShowDialog();
			}
			// 선택된 좌석이 사용 중일 때 -> 메세지
			else
			{
				MessageBox.Show("현재 사용중인 좌석입니다.");
			}
		}


		// 종료 버튼
		private void BtnQuit_Click(object sender, EventArgs e)
		{
			int index = Int32.Parse(tbSeatNo.Text) - 1;

			// 좌석이 사용 중이 아닐 때 -> 사용 종료할 좌석 없음
			if (seats[index].IsAvailable() == true)
			{

			}
			// 좌석이 사용 중일 때 -> 사용 종료
			else
			{
				// Yes -> 사용 종료
				if(MessageBox.Show("사용을 종료하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					seats.RemoveAt(index);
					seats.Insert(index, new Seat(index));
					MessageBox.Show(seats[index].IsAvailable().ToString());
					btnSeat[index].BackColor = Color.CornflowerBlue;

					// dgv 업데이트 필요
					dgvSeat.Rows.RemoveAt(index);
				}
			}
		}


		// dgv에 데이터 추가
		public void AddDgvRow(Seat seat)
		{
			dgvSeat.Rows.Add(seat.Std.StdNo, seat.Std.StdName, seat.index+1);
			dgvSeat.Update();
		}


		// 학번 중복확인
		public void SearchDgv(String stdNo, String stdName)
		{
			int index = Int32.Parse(tbSeatNo.Text) - 1;
			bool stdDupli = false;

			for (int i=0; i<dgvSeat.RowCount-1; i++)
			{
				// 학번이 중복된 경우 -> 메세지
				if (stdNo.Equals(dgvSeat.Rows[i].Cells[0].Value.ToString()))
				{
					stdDupli = true;
					MessageBox.Show("이미 예약한 학생입니다.");
					break;
				}
			}

			// 학번이 중복이 아닌 경우 -> 예약
			if (stdDupli== false)
			{
				MessageBox.Show("예약되었습니다.");
				dgvSeat.Rows.Add(stdNo, stdName, index + 1);

				Student std = new Student(stdName,stdNo);
				seats[index].Std = std;

				btnSeat[index].BackColor = Color.LightGray;

			}
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
		Form1 form1;
		public Form2()
		{
			InitializeComponent();
		}
		public Form2(Form1 form1)
		{
			InitializeComponent();
			this.form1 = form1;
		}

		private void BtnOk_Click(object sender, EventArgs e)
		{
			form1.SearchDgv(tbStdNo2.Text, tbStdName2.Text);
			this.Close();
		}
	}
}

```

