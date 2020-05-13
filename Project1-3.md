# Project No.1

### 04/02 ~ 04/16

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

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
		private List<CheckBox> checkbox = new List<CheckBox>();
		private List<Label> lbName = new List<Label>();
		private List<Label> lbMenu = new List<Label>();
		private List<Label> lbLocation = new List<Label>();

		public Form1()
        {
            InitializeComponent();

		}

        int count = 0;

        // 추가 버튼
        private void btnAdd_Click(object sender, EventArgs e)
        {
			// 체크 박스
			checkbox.Add(new CheckBox());
			checkbox[count].Location = new Point(10, 25+count*30);
			panel2.Controls.Add(checkbox[count]);

			// 가게명
			lbName.Add(new Label());
			lbName[count].Text = tbName.Text;
			lbName[count].Location = new Point(10, 30+ count * 30);
			panel3.Controls.Add(lbName[count]);

			// 메뉴
			lbMenu.Add(new Label());
			lbMenu[count].Text = tbMenu.Text;
			lbMenu[count].Location = new Point(10, 30 + count * 30);
			panel4.Controls.Add(lbMenu[count]);

			// 위치
			lbLocation.Add(new Label());
			lbLocation[count].Text = tbLocation.Text;
			lbLocation[count].Location = new Point(10, 30 + count * 30);
			panel5.Controls.Add(lbLocation[count]);

			count++;
			
			ClearInput();
        }

        // 삭제 버튼
		// 삭제 후 위치 조정은 구현하지 못함.
        private void btnDelete_Click(object sender, EventArgs e)
        {
			for(int i=0; i < checkbox.Count; i++)
			{
				if (checkbox[i].Checked == true)
				{
					panel2.Controls.Remove(checkbox[i]);
					panel3.Controls.Remove(lbName[i]);
					panel4.Controls.Remove(lbMenu[i]);
					panel5.Controls.Remove(lbLocation[i]);

					checkbox.RemoveAt(i);
					lbName.RemoveAt(i);
					lbMenu.RemoveAt(i);
					lbLocation.RemoveAt(i);


					count--;
				}
			}
			
		}

		private void ClearInput()
		{
			tbName.Text = "";
			tbMenu.Text = "";
			tbLocation.Text = "";
		}
		
	}
}

```

