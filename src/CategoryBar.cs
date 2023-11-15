using System;
using System.Drawing;
using System.Windows.Forms;

using Menu;

namespace CategoryBar
{
	public class Category
	{
		// middle category number
		public int middleCategory = 1;
		// name of categories
		public string[] categories = {"전체", "커피", "라떼", "주스", "스무디", "버블티", "티"};
		// category bar panel
		public Panel CategoryPanel;
		// Creating a control of buttons
		public Control[] categoryBtns;
		// buttons for back and forth
		public Button backBtn;
		public Button forthBtn;
		
		public Form form;
		
		public void Top(Form mainForm)
		{
			Console.WriteLine("Top Start");
			
			form = mainForm;
			// all the category btns
			categoryBtns = new Control[categories.Length];
			backBtn = new Button();
			forthBtn = new Button();

			TopPanelControl();
		}
		void TopPanelControl()
		{
			// Creating a panel
			CategoryPanel = new Panel();
			CategoryPanel.Height = 40;
			CategoryPanel.Width = 300;
			CategoryPanel.BackColor = Color.CornflowerBlue; // main color
			form.Controls.Add(CategoryPanel);

			ShowCategoryButtons(0);

			// Back Button
			backBtn.Location = new Point(0,5);
			backBtn.Parent = CategoryPanel;
			backBtn.Size = new Size(50, 30);
			backBtn.Enabled = false;
			backBtn.Text = "◁";
			backBtn.Click += new EventHandler(OnBackBtnClick);
			// Forth Button
			forthBtn.Location = new Point(240,5);
			forthBtn.Parent = CategoryPanel;
			forthBtn.Size = new Size(50, 30);
			forthBtn.Text = "▷";
			forthBtn.Click += new EventHandler(OnForthBtnClick);
		}
		// if int is 0 => no changes
		// if int is -1 => back button is clicked
		// if int is +1 => forth button is clicked
		void ShowCategoryButtons(int backAndForth)
		{
			middleCategory += backAndForth;
			
			int frontCategory = middleCategory - 1;
			int endCategory = middleCategory + 1;

			int start = 0;

			for(int i = frontCategory; i <= endCategory; i++)
			{
				categoryBtns[i] = new Button();

				categoryBtns[i].Location = new Point(60 + (start * 60), 5);
				categoryBtns[i].Parent = CategoryPanel;
				categoryBtns[i].Size = new Size(50, 30);
				categoryBtns[i].Text = categories[i];
				categoryBtns[i].Click += new EventHandler(OnCategoryBtnClick);

				start++;
			}
		}

		void DeleteAllBtns()
		{
			for(int i = 0; i < categories.Length; i++)
			{
				CategoryPanel.Controls.Remove(categoryBtns[i]);
			}
		}

		void OnCategoryBtnClick(object sender, EventArgs e)
		{
			Button btn = sender as Button;

			if(btn.Text.ToString().Equals("커피"))
			{
				Items.CoffeeMenuControl();
			}
			else if(btn.Text.ToString().Equals("라떼"))
			{
				Items.LatteMenuControl();
			}
			else if(btn.Text.ToString().Equals("주스"))
			{
				Items.JuiceMenuControl();
			}
			else
			{
				Items.AllMenuControl();
			}
		}

		void OnBackBtnClick(object sender, EventArgs e)
		{
			forthBtn.Enabled = true;
			if(middleCategory - 1 <= 0)
			{
				backBtn.Enabled = false;
			}
			else
			{
				DeleteAllBtns();
				ShowCategoryButtons(-1);	
			}
		}

		void OnForthBtnClick(object sender, EventArgs e)
		{
			backBtn.Enabled = true;
			if(middleCategory + 1 >= categories.Length - 1)
			{
				forthBtn.Enabled = false;
			}
			else
			{
				DeleteAllBtns();
				ShowCategoryButtons(1);	
			}
		}
	}
}