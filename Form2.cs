using System;
using System.Windows.Forms;
using System.Drawing;

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
