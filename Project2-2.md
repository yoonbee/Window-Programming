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
			for (int i=0; i<4; i++)
			{
				for(int j=0; j<30; j++)
				{
					index = i * 30 + j;

					Seat tempSeat = new Seat()
					{
						no = index,
						state = true
					};

					seats.Add(tempSeat);

					btnSeat[index] = new Button();
					btnSeat[index].Text = (index + 1).ToString();
					btnSeat[index].Size = new Size(35, 35);
					btnSeat[index].Location = new Point(10 + j * 35, 15 + i * 35);

					if(seats[index].state == true)
						btnSeat[index].BackColor = Color.CornflowerBlue;

					btnSeat[index].Click += BtnSeat_Click;

					gbSeat.Controls.Add(btnSeat[index]);
				}
			}
		}

		private void BtnSeat_Click(object sender, EventArgs e)
		{
			Button clickedButton = (Button)sender;

			int index = Int32.Parse(clickedButton.Text) - 1;
			tbSeatNo.Text = (index+1).ToString();

			if(seats[index].state == false)
			{
				tbStdName.Text = "이름";
				tbStdNo.Text = "학번";
			}
			else
			{
				tbStdName.Text = "";
				tbStdNo.Text = "";
			}

		}

		private void BtnBooking_Click(object sender, EventArgs e)
		{
			int index = Int32.Parse(tbSeatNo.Text) - 1;

			// 선택한 좌석이 사용 중일 때
			if(seats[index].state == false)
			{ 
				MessageBox.Show("현재 사용 중인 좌석입니다.");
			}
			// 선택한 좌석이 사용 가능할 때
			else
			{
				Form2 form2 = new Form2();
				form2.ShowDialog();
			}
		}


		public void PrintDgv()
		{
			for(int i=0; i<totalNum; i++)
			{
				if (seats[i].state == false)
				{

				}
			}
		}
	}
}

```

```c#
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

