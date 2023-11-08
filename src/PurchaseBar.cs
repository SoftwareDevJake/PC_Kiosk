using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PurchaseBar
{
	public class Purchase
	{
		// Purchase Panel
		public Panel purchasePanel;
		// Purchase Related Buttons
		public Button purchaseBtn;
		public Button cancelBtn;
		// Price Label
		public Label priceText;
		
		// Selected Item Panel
		public static Panel selectedItemPanel;
		// Selected Item's msg
		public Label chosenMenuTxt;
		// Selected Item's selected btns (when it's clicked, it'll be canceled)
		public Control[] selectedCancelBtns;
		public static List<Button> selectedList = new List<Button>();
		
		public static Form form;
		
		public static int floor = 0;
		
		public void BottomRight(Form mainForm)
		{
			Console.WriteLine("Bottom Right Start");
			
			form = mainForm;
			
			// Purchase parts
			purchaseBtn = new Button();
			cancelBtn = new Button();
			priceText = new Label();
			
			// Selected parts
			chosenMenuTxt = new Label();
			
			BottomRightPanelControl();
		}
		
		public void BottomRightPanelControl()
		{
			// selected ui
			SelectedUI();
			
			// purchase ui
			PurchaseUI();
		}
		
		void OnPurchaseBtnClick(object sender, EventArgs e)
		{
			MessageBox.Show("Purchase button has pressed!");
		}
		
		void OnCancelBtnClick(object sender, EventArgs e)
		{
			MessageBox.Show("Cancel button has pressed!");
		}
		
		void SelectedUI()
		{
			// selected item panel part
			Purchase.selectedItemPanel = new Panel();
			Purchase.selectedItemPanel.Height = 80;
			Purchase.selectedItemPanel.Width = 140;
			Purchase.selectedItemPanel.Location = new Point(0, 220);
			Purchase.selectedItemPanel.BackColor = Color.CornflowerBlue;
			form.Controls.Add(selectedItemPanel);
			
			// chosen menu label
			chosenMenuTxt.Location = new Point(0, 5);
			chosenMenuTxt.Parent = Purchase.selectedItemPanel;
			// chosenMenuTxt.Size = new Size(100, 0);
			chosenMenuTxt.Text = "선택된 메뉴";
			chosenMenuTxt.AutoSize = true;
		}
		
		public static void CreateSelectedItems(string name)
		{
			int xPos = 0;
			int yPos = 0;
			
			if(Purchase.selectedList.Count == 0)
			{
				xPos = 70;
				yPos = 3;
				floor++;
			}
			else if(Purchase.selectedList.Count == 1)
			{
				xPos = 5;
				yPos = 25;
			}
			else
			{
				xPos = 70;
				yPos = 25;
			}
			
			Button selectedItem = new Button();
			
			selectedItem.Location = new Point(xPos, yPos);
			selectedItem.Parent = Purchase.selectedItemPanel;
			selectedItem.Size = new Size(50, 20);
			selectedItem.Text = "X" + name;
			selectedItem.Click += new EventHandler(Purchase.OnSelectedItemClick);
			
			Purchase.selectedList.Add(selectedItem);
		}
		
		public static void OnSelectedItemClick(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			// removing selected btn
			Purchase.selectedList.Remove(Purchase.selectedList[0]);
			form.Controls.Remove(btn);
			btn.Dispose();
		}
		
		void PurchaseUI()
		{
			// purchase panel part
			purchasePanel = new Panel();
			purchasePanel.Height = 80;
			purchasePanel.Width = 140;
			purchasePanel.Location = new Point(150, 220);
			purchasePanel.BackColor = Color.CornflowerBlue;
			form.Controls.Add(purchasePanel);
			
			// purchase button
			purchaseBtn.Location = new Point(10, 30);
			purchaseBtn.Parent = purchasePanel;
			purchaseBtn.Size = new Size(60, 20);
			purchaseBtn.Text = "결제하기";
			purchaseBtn.Click += new EventHandler(OnPurchaseBtnClick);
			
			// cancel button
			cancelBtn.Location = new Point(75, 30);
			cancelBtn.Parent = purchasePanel;
			cancelBtn.Size = new Size(60, 20);
			cancelBtn.Text = "취소";
			cancelBtn.Click += new EventHandler(OnCancelBtnClick);
			
			// price label
			priceText.Location = new Point(60, 5);
			priceText.Parent = purchasePanel;
			// priceText.Size = new Size(100, 0);
			priceText.Text = "price";
			priceText.AutoSize = true;
		}
	}
}