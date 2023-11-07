using System;
using System.Drawing;
using System.Windows.Forms;

namespace PurchaseBar
{
	public class Purchase
	{
		// Purchase panel
		public Panel purchasePanel;
		// Purchase Related Buttons
		public Button purchaseBtn;
		public Button cancelBtn;
		// Price label
		public Label priceText;
		
		public Form form;
		
		public void BottomRight(Form mainForm)
		{
			Console.WriteLine("Bottom Right Start");
			
			form = mainForm;
			
			// all the purchase related btns
			purchaseBtn = new Button();
			cancelBtn = new Button();
			// price label
			priceText = new Label();
			
			BottomRightPanelControl();
		}
		
		public void BottomRightPanelControl()
		{
			purchasePanel = new Panel();
			purchasePanel.Height = 80;
			purchasePanel.Width = 150;
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
			priceText.Size = new Size(100, 0);
			priceText.Text = "price";
			priceText.AutoSize = true;
		}
		
		void OnPurchaseBtnClick(object sender, EventArgs e)
		{
			MessageBox.Show("Purchase button has pressed!");
		}
		
		void OnCancelBtnClick(object sender, EventArgs e)
		{
			MessageBox.Show("Cancel button has pressed!");
		}
	}
}