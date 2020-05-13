```c#
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
	public partial class Form1 : Form
	{
		// 전체 좌석 수(상수)
		public const int totalNum = 120;

		public Form1()
		{
			InitializeComponent();

			// 독서실 현황
			// 전체 좌석 수 
			lbTotal.Text = totalNum.ToString();


			// 좌석 현황
			Button[] btnSeat = new Button[totalNum];
			for (int i = 0; i < totalNum / 30; i++){
				for (int j = 0; j < 30; j++){
					btnSeat[i] = new Button();
					btnSeat[i].Text = (i * 30 + j + 1).ToString();
					btnSeat[i].Size = new Size(35, 35);
					btnSeat[i].Location = new Point(10 + j * 35, 15 + i * 35);
					btnSeat[i].BackColor = Color.CornflowerBlue;
					btnSeat[i].Click += BtnSeat_Click;

					gbSeat.Controls.Add(btnSeat[i]);
				}
			}
		}
		
		private void BtnSeat_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void BtnUse_Click(object sender, EventArgs e)
		{

		}
	}
}

```

