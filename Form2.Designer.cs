namespace WindowsFormsApp9
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbStdName2 = new System.Windows.Forms.TextBox();
			this.tbStdNo2 = new System.Windows.Forms.TextBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "이름";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "학번";
			// 
			// tbStdName2
			// 
			this.tbStdName2.Location = new System.Drawing.Point(55, 9);
			this.tbStdName2.Name = "tbStdName2";
			this.tbStdName2.Size = new System.Drawing.Size(172, 25);
			this.tbStdName2.TabIndex = 2;
			// 
			// tbStdNo2
			// 
			this.tbStdNo2.Location = new System.Drawing.Point(55, 37);
			this.tbStdNo2.Name = "tbStdNo2";
			this.tbStdNo2.Size = new System.Drawing.Size(171, 25);
			this.tbStdNo2.TabIndex = 3;
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(240, 24);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 4;
			this.btnOk.Text = "확인";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(325, 72);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.tbStdNo2);
			this.Controls.Add(this.tbStdName2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "좌석 예약";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbStdName2;
		private System.Windows.Forms.TextBox tbStdNo2;
		private System.Windows.Forms.Button btnOk;
	}
}