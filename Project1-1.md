# Project No.1

### 04/02 ~ 04/16

```c#
using Restaurant_List;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
	public partial class Form1 : Form
	{
		List<Restaurant> restaurants;

		public Form1()
		{
			InitializeComponent();
			restaurants = new List<Restaurant>();

			PrintData();
		}
		
		// 저장한 데이터를 불러와 dgv에 저장
		private void PrintData()
		{
			using (StreamReader sr = new StreamReader("data.txt"))
			{

				String line;
				while ((line = sr.ReadLine()) != null)
				{
					char sp = ',';
					string[] spValues = line.Split(sp);

					Restaurant tempRes = new Restaurant()
					{
						name = spValues[0],
						menu = spValues[1],
						location = spValues[2]
					};

					restaurants.Add(tempRes);
					dgvRestaurant.Rows.Add(spValues);

				}
			}
		}
	
		// 추가 버튼
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			string name = tbName.Text;
			string menu = tbMenu.Text;
			string location = tbLocation.Text;

			// 입력값이 있을 때
			if (name != "" && menu != "" && location != "")
			{
				// 중복 체크
				bool nameDupli = false;
				for (int i = 0; i < dgvRestaurant.RowCount-1; i++)
				{
					if (dgvRestaurant.Rows[i].Cells[0].Value.ToString() == name)
					{
						nameDupli = true;
						break;
					}
				}
				
				// 중복이 아닐 때
				if (nameDupli != true)
				{
					Restaurant tempRes = new Restaurant()
					{
						name = name,
						menu = menu,
						location = location
					};

					restaurants.Add(tempRes);
					dgvRestaurant.Rows.Add(tempRes.name, tempRes.menu, tempRes.location);
				}

			}
			ClearInput();
		}

		// 삭제 버튼
		private void BtnDelete_Click(object sender, EventArgs e)
		{
			int selectedRowCount = dgvRestaurant.Rows.GetRowCount(DataGridViewElementStates.Selected);


			if(selectedRowCount > 0)
			{
				for(int i=selectedRowCount-1; i >= 0; i--)
				{
					int index = dgvRestaurant.SelectedRows[i].Index;
					dgvRestaurant.Rows.RemoveAt(index);
					restaurants.RemoveAt(index);
				}
			}

			ClearInput();
		}

		// 저장 버튼
		private void BtnSave_Click(object sender, EventArgs e)
		{
			// data.txt에 저장
			string path = @".\data.txt";

			using (StreamWriter sw = File.CreateText(path))
			{
				int row = 0;
				while (dgvRestaurant.Rows[row].Cells[0].Value != null)
				{
					for (int i = 0; i < dgvRestaurant.ColumnCount; i++)
					{
						sw.Write(dgvRestaurant.Rows[row].Cells[i].Value.ToString());

						if (i == dgvRestaurant.ColumnCount - 1)
							sw.WriteLine();
						else
							sw.Write(",");
					}
					row++;
				}
			}
		}


		bool dgvCellClick = false; // dgv 선택 상태 변수
		int selectedRowIndex = 0; // 선택된 행 인덱스

		// dgv에서 선택 시 입력칸에 출력
		private void DgvCell_Click(object sender, DataGridViewCellEventArgs e)
		{
			selectedRowIndex = e.RowIndex;
			dgvCellClick = true;

			tbName.Text = dgvRestaurant.Rows[e.RowIndex].Cells[0].Value.ToString();
			tbMenu.Text = dgvRestaurant.Rows[e.RowIndex].Cells[1].Value.ToString();
			tbLocation.Text = dgvRestaurant.Rows[e.RowIndex].Cells[2].Value.ToString();
		}

		// 수정 버튼
		private void BtnModify_Click(object sender, EventArgs e)
		{
			if (dgvCellClick == true)
			{
				dgvRestaurant.Rows[selectedRowIndex].Cells[0].Value = tbName.Text;
				dgvRestaurant.Rows[selectedRowIndex].Cells[1].Value = tbMenu.Text;
				dgvRestaurant.Rows[selectedRowIndex].Cells[2].Value = tbLocation.Text;

				ClearInput();
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

namespace Restaurant_List
{
	class Restaurant
	{
		public string name;
		public string menu;
		public string location;
	}
}
```

