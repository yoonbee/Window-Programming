namespace WindowsFormsApp9
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.gbCondition = new System.Windows.Forms.GroupBox();
			this.lbAvailable = new System.Windows.Forms.Label();
			this.lbUnavailable = new System.Windows.Forms.Label();
			this.lbTotal = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.gbReservation = new System.Windows.Forms.GroupBox();
			this.btnQuit = new System.Windows.Forms.Button();
			this.btnBooking = new System.Windows.Forms.Button();
			this.tbStdName = new System.Windows.Forms.TextBox();
			this.tbStdNo = new System.Windows.Forms.TextBox();
			this.tbSeatNo = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.gbUsing = new System.Windows.Forms.GroupBox();
			this.dgvSeat = new System.Windows.Forms.DataGridView();
			this.gbSeat = new System.Windows.Forms.GroupBox();
			this.gbCondition.SuspendLayout();
			this.gbReservation.SuspendLayout();
			this.gbUsing.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSeat)).BeginInit();
			this.SuspendLayout();
			// 
			// gbCondition
			// 
			this.gbCondition.Controls.Add(this.lbAvailable);
			this.gbCondition.Controls.Add(this.lbUnavailable);
			this.gbCondition.Controls.Add(this.lbTotal);
			this.gbCondition.Controls.Add(this.label3);
			this.gbCondition.Controls.Add(this.label2);
			this.gbCondition.Controls.Add(this.label1);
			this.gbCondition.Location = new System.Drawing.Point(12, 12);
			this.gbCondition.Name = "gbCondition";
			this.gbCondition.Size = new System.Drawing.Size(277, 125);
			this.gbCondition.TabIndex = 0;
			this.gbCondition.TabStop = false;
			this.gbCondition.Text = "독서실 현황";
			// 
			// lbAvailable
			// 
			this.lbAvailable.AutoSize = true;
			this.lbAvailable.Location = new System.Drawing.Point(165, 92);
			this.lbAvailable.Name = "lbAvailable";
			this.lbAvailable.Size = new System.Drawing.Size(45, 15);
			this.lbAvailable.TabIndex = 5;
			this.lbAvailable.Text = "label3";
			// 
			// lbUnavailable
			// 
			this.lbUnavailable.AutoSize = true;
			this.lbUnavailable.Location = new System.Drawing.Point(148, 61);
			this.lbUnavailable.Name = "lbUnavailable";
			this.lbUnavailable.Size = new System.Drawing.Size(45, 15);
			this.lbUnavailable.TabIndex = 4;
			this.lbUnavailable.Text = "label2";
			// 
			// lbTotal
			// 
			this.lbTotal.AutoSize = true;
			this.lbTotal.Location = new System.Drawing.Point(114, 29);
			this.lbTotal.Name = "lbTotal";
			this.lbTotal.Size = new System.Drawing.Size(45, 15);
			this.lbTotal.TabIndex = 3;
			this.lbTotal.Text = "label1";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(147, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "사용 가능한 좌석 수:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "사용 중인 좌석 수:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "전체 좌석 수:";
			// 
			// gbReservation
			// 
			this.gbReservation.Controls.Add(this.btnQuit);
			this.gbReservation.Controls.Add(this.btnBooking);
			this.gbReservation.Controls.Add(this.tbStdName);
			this.gbReservation.Controls.Add(this.tbStdNo);
			this.gbReservation.Controls.Add(this.tbSeatNo);
			this.gbReservation.Controls.Add(this.label6);
			this.gbReservation.Controls.Add(this.label5);
			this.gbReservation.Controls.Add(this.label4);
			this.gbReservation.Location = new System.Drawing.Point(314, 12);
			this.gbReservation.Name = "gbReservation";
			this.gbReservation.Size = new System.Drawing.Size(408, 125);
			this.gbReservation.TabIndex = 1;
			this.gbReservation.TabStop = false;
			this.gbReservation.Text = "예약 / 종료";
			// 
			// btnQuit
			// 
			this.btnQuit.Location = new System.Drawing.Point(318, 76);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(75, 23);
			this.btnQuit.TabIndex = 7;
			this.btnQuit.Text = "종료";
			this.btnQuit.UseVisualStyleBackColor = true;
			this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
			// 
			// btnBooking
			// 
			this.btnBooking.Location = new System.Drawing.Point(318, 42);
			this.btnBooking.Name = "btnBooking";
			this.btnBooking.Size = new System.Drawing.Size(75, 23);
			this.btnBooking.TabIndex = 6;
			this.btnBooking.Text = "예약";
			this.btnBooking.UseVisualStyleBackColor = true;
			this.btnBooking.Click += new System.EventHandler(this.BtnBooking_Click);
			// 
			// tbStdName
			// 
			this.tbStdName.Location = new System.Drawing.Point(119, 89);
			this.tbStdName.Name = "tbStdName";
			this.tbStdName.ReadOnly = true;
			this.tbStdName.Size = new System.Drawing.Size(178, 25);
			this.tbStdName.TabIndex = 5;
			// 
			// tbStdNo
			// 
			this.tbStdNo.Location = new System.Drawing.Point(119, 58);
			this.tbStdNo.Name = "tbStdNo";
			this.tbStdNo.ReadOnly = true;
			this.tbStdNo.Size = new System.Drawing.Size(178, 25);
			this.tbStdNo.TabIndex = 4;
			// 
			// tbSeatNo
			// 
			this.tbSeatNo.Location = new System.Drawing.Point(119, 26);
			this.tbSeatNo.Name = "tbSeatNo";
			this.tbSeatNo.ReadOnly = true;
			this.tbSeatNo.Size = new System.Drawing.Size(178, 25);
			this.tbSeatNo.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 96);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(87, 15);
			this.label6.TabIndex = 2;
			this.label6.Text = "사용자 이름";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 64);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(87, 15);
			this.label5.TabIndex = 1;
			this.label5.Text = "사용자 학번";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 29);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 15);
			this.label4.TabIndex = 0;
			this.label4.Text = "좌석 번호";
			// 
			// gbUsing
			// 
			this.gbUsing.Controls.Add(this.dgvSeat);
			this.gbUsing.Location = new System.Drawing.Point(12, 350);
			this.gbUsing.Name = "gbUsing";
			this.gbUsing.Size = new System.Drawing.Size(1189, 178);
			this.gbUsing.TabIndex = 3;
			this.gbUsing.TabStop = false;
			this.gbUsing.Text = "예약 현황";
			// 
			// dgvSeat
			// 
			this.dgvSeat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSeat.Location = new System.Drawing.Point(7, 25);
			this.dgvSeat.Name = "dgvSeat";
			this.dgvSeat.RowTemplate.Height = 27;
			this.dgvSeat.Size = new System.Drawing.Size(1210, 150);
			this.dgvSeat.TabIndex = 0;
			this.dgvSeat.CurrentCellChanged += new System.EventHandler(this.DgvSeat_CurrentCellChanged);
			// 
			// gbSeat
			// 
			this.gbSeat.Location = new System.Drawing.Point(12, 143);
			this.gbSeat.Name = "gbSeat";
			this.gbSeat.Size = new System.Drawing.Size(1217, 201);
			this.gbSeat.TabIndex = 4;
			this.gbSeat.TabStop = false;
			this.gbSeat.Text = "좌석 현황";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1241, 534);
			this.Controls.Add(this.gbSeat);
			this.Controls.Add(this.gbUsing);
			this.Controls.Add(this.gbReservation);
			this.Controls.Add(this.gbCondition);
			this.Name = "Form1";
			this.Text = "도서관 예약 시스템";
			this.gbCondition.ResumeLayout(false);
			this.gbCondition.PerformLayout();
			this.gbReservation.ResumeLayout(false);
			this.gbReservation.PerformLayout();
			this.gbUsing.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvSeat)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbCondition;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbAvailable;
		private System.Windows.Forms.Label lbUnavailable;
		private System.Windows.Forms.Label lbTotal;
		private System.Windows.Forms.GroupBox gbReservation;
		private System.Windows.Forms.TextBox tbSeatNo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbStdName;
		private System.Windows.Forms.TextBox tbStdNo;
		private System.Windows.Forms.Button btnQuit;
		private System.Windows.Forms.Button btnBooking;
		private System.Windows.Forms.GroupBox gbUsing;
		private System.Windows.Forms.GroupBox gbSeat;
		private System.Windows.Forms.DataGridView dgvSeat;
	}
}

