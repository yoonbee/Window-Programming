using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp9
{

	public partial class Form1 : Form
	{
		Button[] btnSeat = new Button[120];
		
		public Form1()
		{
			InitializeComponent();

			// 독서실 현황 라벨 설정
			lbTotal.Text = DataManager.Seats.Count.ToString();
			lbUnavailable.Text = DataManager.Seats.Where((x)=>x.IsAvailable).Count().ToString();
			lbAvailable.Text = (DataManager.Seats.Count- DataManager.Seats.Where((x) => x.IsAvailable).Count()).ToString();

			// dgv 설정
			Seat[] seats = new Seat[DataManager.Seats.Count];
			DataManager.Seats.CopyTo(seats);
			
			dgvSeat.DataSource = DataManager.Seats;
			dgvSeat.CurrentCellChanged += DgvSeat_CurrentCellChanged;

			
			this.dgvSeat.Columns["IsAvailable"].Visible = false;

			// 좌석 현황
			int index = 0;
			for(int i=0; i<4; i++)
			{
				for (int j = 0; j < 30; j++)
				{
					index = i * 30 + j;

					btnSeat[index] = new Button();
					btnSeat[index].Text = (index + 1).ToString();
					btnSeat[index].Size = new Size(35, 35);
					btnSeat[index].Location = new Point(10 + j * 35, 15 + i * 35);

					if (seats[index].IsAvailable)
						btnSeat[index].BackColor = Color.CornflowerBlue;
					else
						btnSeat[index].BackColor = Color.LightGray;

					btnSeat[index].Click += BtnSeat_Click;

					gbSeat.Controls.Add(btnSeat[index]);
				}
			}

		}
		

		private void DgvSeat_CurrentCellChanged(object sender, EventArgs e)
		{
			try
			{
				Seat seat = dgvSeat.CurrentRow.DataBoundItem as Seat;
				tbSeatNo.Text = seat.SeatNo.ToString();
				tbStdNo.Text = seat.StdNo;
				tbStdName.Text = seat.StdName;
			}
			catch (Exception exception)
			{

			}
		}
	

		// 좌석 버튼
		private void BtnSeat_Click(object sender, EventArgs e)
		{
			Button clickedButton = (Button)sender;

			tbSeatNo.Text = clickedButton.Text;

			Seat seat = DataManager.Seats.Single((x) => x.SeatNo.ToString() == tbSeatNo.Text);
			// 선택된 좌석이 예약 가능할 때
			if (seat.IsAvailable)
			{
				tbStdName.Text = "";
				tbStdNo.Text = "";
			}
			// 선택된 좌석이 사용 중일 때 -> 학생 정보 출력
			else
			{
				tbStdName.Text = seat.StdName;
				tbStdNo.Text = seat.StdNo;
			}
			

		}


		// 예약 버튼
		private void BtnBooking_Click(object sender, EventArgs e)
		{
			Seat seat = DataManager.Seats.Single((x) => x.SeatNo.ToString() == tbSeatNo.Text);
			// 선택된 좌석이 예약 가능할 때 -> 예약 창
			if (seat.IsAvailable)
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


		// 학번 중복 확인
		public void SearchDgv(string stdNo, string stdName)
		{
			try
			{
				Seat seat = DataManager.Seats.Single((x) => x.StdNo == stdNo);
				MessageBox.Show("이미 예약한 학생입니다.");
			}
			catch (Exception exception)
			{
				Seat seat = DataManager.Seats.Single((x) => x.SeatNo.ToString() == tbSeatNo.Text); 
				seat.IsAvailable = false;
				seat.StdName = stdName;
				seat.StdNo = stdNo;

				Student std = new Student();
				std.StdName = stdName;
				std.StdNo = stdNo;
				DataManager.Students.Add(std);

				
				btnSeat[seat.SeatNo-1].BackColor = Color.LightGray;

				dgvSeat.DataSource = null;
				dgvSeat.DataSource = DataManager.Seats;
				DataManager.Save();

				for (int i = 0; i < dgvSeat.RowCount; i++)
				{
					if (dgvSeat.Rows[i].Cells[1].Value.ToString() == true.ToString())
					{
						dgvSeat.Rows[i].Visible = false;
					}
				}
				this.dgvSeat.Columns["IsAvailable"].Visible = false;

				MessageBox.Show("예약 되었습니다");

				lbUnavailable.Text = DataManager.Seats.Where((x) => x.IsAvailable).Count().ToString();
				lbAvailable.Text = (DataManager.Seats.Count - DataManager.Seats.Where((x) => x.IsAvailable).Count()).ToString();

			}
			
		}


		// 종료 버튼
		private void BtnQuit_Click(object sender, EventArgs e)
		{

			Seat seat = DataManager.Seats.Single((x) => x.SeatNo.ToString() ==tbSeatNo.Text);

			// 좌석이 사용 가능할 때(사용 중X) -> 사용 종료할 좌석 없음
			if (seat.IsAvailable)
			{
				MessageBox.Show("비어있는 좌석입니다.");
			}
			// 좌석이 사용 중일 때 -> 사용 종료
			else
			{
				if (MessageBox.Show("사용을 종료하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					Student std = DataManager.Students.Single((x) => x.StdName.ToString() == tbStdName.Text);
					seat.IsAvailable = true;
					seat.StdName = "";
					seat.StdNo = "";
					DataManager.Students.Remove(std);

					this.dgvSeat.Columns["IsAvailable"].Visible = false;

					btnSeat[seat.SeatNo - 1].BackColor = Color.CornflowerBlue;

					dgvSeat.DataSource = null;
					dgvSeat.DataSource = DataManager.Seats;
					DataManager.Save();

					for (int i = 0; i < dgvSeat.RowCount; i++)
					{
						if (dgvSeat.Rows[i].Cells[1].Value.ToString() == true.ToString())
						{
							dgvSeat.Rows[i].Visible = false;
						}
					}
					this.dgvSeat.Columns["IsAvailable"].Visible = false;

					lbUnavailable.Text = DataManager.Seats.Where((x) => x.IsAvailable).Count().ToString();
					lbAvailable.Text = (DataManager.Seats.Count - DataManager.Seats.Where((x) => x.IsAvailable).Count()).ToString();

				}
			}
		}
	}
}
