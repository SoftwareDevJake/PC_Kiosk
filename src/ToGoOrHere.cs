using System;
using System.Drawing;
using System.Windows.Forms;

using PurchaseBar;

namespace LastStep
{
	public class LastQuestion
	{
		public Form lastForm = new Form();
		public Panel lastPanel = new Panel();
		
		public Button toGoBtn = new Button();
		public Button hereBtn = new Button();
		
		public void LastModal(Form form)
		{
			lastForm.Size = new Size(200, 250);
			lastForm.StartPosition = FormStartPosition.Manual;
			lastForm.Location = new Point(140, 50);
			
			lastPanel.Height = 250;
			lastPanel.Width = 200;
			
			lastPanel.BackColor = Color.CornflowerBlue;
			lastForm.Controls.Add(lastPanel);
			
			toGoBtn.Location = new Point(50, 50);
			toGoBtn.Parent = lastPanel;
			toGoBtn.Size = new Size(100, 50);
			toGoBtn.BackColor = Color.Gray;
			toGoBtn.Text = "먹고 가기";
			toGoBtn.Click += new EventHandler(OnToGoBtnClick);
			
			hereBtn.Location = new Point(50, 130);
			hereBtn.Parent = lastPanel;
			hereBtn.Size = new Size(100, 50);
			hereBtn.BackColor = Color.Gray;
			hereBtn.Text = "포장 하기";
			hereBtn.Click += new EventHandler(OnHereBtnClick);
			
			lastForm.ShowDialog(form);
		}
		
		public void OnToGoBtnClick(object sender, EventArgs e)
		{
			int totalSelectedItem = Purchase.selectedList.Count;
			for(int i = totalSelectedItem - 1; i >= 0 ; i--)
			{
				Purchase.OnSelectedItemClick(Purchase.selectedList[i], null);
			}
			lastForm.Close();
		}
		
		public void OnHereBtnClick(object sender, EventArgs e)
		{
			lastForm.Close();
		}
	}
}