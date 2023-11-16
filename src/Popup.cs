using System;
using System.Drawing;
using System.Windows.Forms;

using PurchaseBar;

namespace Popup
{
	public class PopupDetails
	{
		// hard coded
		public Form popupForm = new Form();
		public Panel popupPanel = new Panel();
		
		public Image IceImg = Image.FromFile("/workspace/PC_Kiosk/img/PopupImg/Ice.png");
		public Image HotImg = Image.FromFile("/workspace/PC_Kiosk/img/PopupImg/Hot.png");
		
		public Button iceBtn = new Button();
		public Button hotBtn = new Button();
		
		public Label changeMilkTxt = new Label();
		public Button milkBtn = new Button();
		public Button lowFatMilkBtn = new Button();
		public Button soyMilkBtn = new Button();
		
		public Label amountOfIce = new Label();
		public Button lessIce = new Button();
		public Button normalIce = new Button();
		public Button aLotIce = new Button();
		
		public Label extraShot = new Label();
		public Button noExtraShot = new Button();
		public Button oneExtraShot = new Button();
		public Button twoExtraShot = new Button();
		
		public Button selectBtn = new Button();
		public Button cancelBtn = new Button();
		
		public string selectedName;
		
		public void ShowModal(Form form, string name)
		{
			selectedName = name;
			popupForm.Size = new Size(200,250);
			popupForm.StartPosition = FormStartPosition.Manual;
			popupForm.Location = new Point(140, 50);
			
			popupPanel.Height = 250;
			popupPanel.Width = 200;
			// p.Location = new Point(10, 10);
			popupPanel.BackColor = Color.White;
			popupForm.Controls.Add(popupPanel);
			
			IceOrHot();
			ChangingMilk();
			AmountOfIce();
			ExtraShot();
			
			Choice();
			
			popupForm.ShowDialog(form);
		}
		
		public void OnBackBtnClick(object sender, EventArgs e)
		{
			popupForm.Close();
		}
		
		public void IceOrHot()
		{
			var icePic = new Bitmap(IceImg, 40, 40);
			var hotPic = new Bitmap(HotImg, 40, 40);
			
			iceBtn.BackColor = Color.LightGray;
			iceBtn.BackgroundImage = icePic;
			iceBtn.ForeColor = Color.LightGray;
			
			iceBtn.Location = new Point(50, 30);
			iceBtn.Parent = popupPanel;
			iceBtn.Size = new Size(40, 40);
			iceBtn.Click += new EventHandler(OnIceBtnClick);
			
			hotBtn.BackColor = Color.LightGray;
			hotBtn.BackgroundImage = hotPic;
			hotBtn.ForeColor = Color.LightGray;
			
			hotBtn.Location = new Point(100, 30);
			hotBtn.Parent = popupPanel;
			hotBtn.Size = new Size(40, 40);
			hotBtn.Click += new EventHandler(OnHotBtnClick);
		}
		
		public void OnIceBtnClick(object sender, EventArgs e)
		{
			Button iceClicked = sender as Button;
			
			iceClicked.BackColor = Color.CornflowerBlue;
			if(hotBtn.BackColor == Color.CornflowerBlue)
			{
				hotBtn.BackColor = Color.LightGray;
			}
		}
		
		public void OnHotBtnClick(object sender, EventArgs e)
		{
			Button hotClicked = sender as Button;
			
			hotClicked.BackColor = Color.CornflowerBlue;
			if(iceBtn.BackColor == Color.CornflowerBlue)
			{
				iceBtn.BackColor = Color.LightGray;
			}
		}
		
		public void ChangingMilk()
		{
			changeMilkTxt.Location = new Point(0, 80);
			changeMilkTxt.Parent = popupPanel;
			changeMilkTxt.BackColor = Color.CornflowerBlue;
			changeMilkTxt.Text = "우유 변경";
			changeMilkTxt.AutoSize = true;
			
			milkBtn.Location = new Point(60, 80);
			milkBtn.Parent = popupPanel;
			milkBtn.Size = new Size(35, 20);
			milkBtn.Text = "우유";
			milkBtn.Click += new EventHandler(OnMilkBtnClick);
			
			lowFatMilkBtn.Location = new Point(100, 80);
			lowFatMilkBtn.Parent = popupPanel;
			lowFatMilkBtn.Size = new Size(40, 20);
			lowFatMilkBtn.Text = "저지방";
			lowFatMilkBtn.Click += new EventHandler(OnLowFatMilkBtnClick);
			
			soyMilkBtn.Location = new Point(150, 80);
			soyMilkBtn.Parent = popupPanel;
			soyMilkBtn.Size = new Size(35, 20);
			soyMilkBtn.Text = "두유";
			soyMilkBtn.Click += new EventHandler(OnSoyMilkBtnClick);
		}
		
		public void OnMilkBtnClick(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			
			btn.BackColor = Color.CornflowerBlue;
			
			if(lowFatMilkBtn.BackColor == Color.CornflowerBlue)
			{
				lowFatMilkBtn.BackColor = Color.LightGray;
			}
			else if(soyMilkBtn.BackColor == Color.CornflowerBlue)
			{
				soyMilkBtn.BackColor = Color.LightGray;
			}
		}
		
		public void OnLowFatMilkBtnClick(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			
			btn.BackColor = Color.CornflowerBlue;
			
			if(milkBtn.BackColor == Color.CornflowerBlue)
			{
				milkBtn.BackColor = Color.LightGray;
			}
			else if(soyMilkBtn.BackColor == Color.CornflowerBlue)
			{
				soyMilkBtn.BackColor = Color.LightGray;
			}
		}
		
		public void OnSoyMilkBtnClick(object sender, EventArgs e)
		{			
			Button btn = sender as Button;
			
			btn.BackColor = Color.CornflowerBlue;
			
			if(milkBtn.BackColor == Color.CornflowerBlue)
			{
				milkBtn.BackColor = Color.LightGray;
			}
			else if(lowFatMilkBtn.BackColor == Color.CornflowerBlue)
			{
				lowFatMilkBtn.BackColor = Color.LightGray;
			}
		}
		
		public void AmountOfIce()
		{
			amountOfIce.Location = new Point(0, 110);
			amountOfIce.Parent = popupPanel;
			amountOfIce.BackColor = Color.CornflowerBlue;
			amountOfIce.Text = "얼음 양";
			amountOfIce.AutoSize = true;
			
			lessIce.Location = new Point(60, 110);
			lessIce.Parent = popupPanel;
			lessIce.Size = new Size(35, 20);
			lessIce.Text = "적게";
			lessIce.Click += new EventHandler(OnLessIceClick);
			
			normalIce.Location = new Point(100, 110);
			normalIce.Parent = popupPanel;
			normalIce.Size = new Size(40, 20);
			normalIce.Text = "보통";
			normalIce.Click += new EventHandler(OnNormalClick);
			
			aLotIce.Location = new Point(150, 110);
			aLotIce.Parent = popupPanel;
			aLotIce.Size = new Size(35, 20);
			aLotIce.Text = "많이";
			aLotIce.Click += new EventHandler(OnALotIceClick);
		}
		
		public void OnLessIceClick(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			
			btn.BackColor = Color.CornflowerBlue;
			
			if(normalIce.BackColor == Color.CornflowerBlue)
			{
				normalIce.BackColor = Color.LightGray;
			}
			else if(aLotIce.BackColor == Color.CornflowerBlue)
			{
				aLotIce.BackColor = Color.LightGray;
			}
		}
		
		public void OnNormalClick(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			
			btn.BackColor = Color.CornflowerBlue;
			
			if(lessIce.BackColor == Color.CornflowerBlue)
			{
				lessIce.BackColor = Color.LightGray;
			}
			else if(aLotIce.BackColor == Color.CornflowerBlue)
			{
				aLotIce.BackColor = Color.LightGray;
			}
		}
		
		public void OnALotIceClick(object sender, EventArgs e)
		{
			
			Button btn = sender as Button;
			
			btn.BackColor = Color.CornflowerBlue;
			
			if(lessIce.BackColor == Color.CornflowerBlue)
			{
				lessIce.BackColor = Color.LightGray;
			}
			else if(normalIce.BackColor == Color.CornflowerBlue)
			{
				normalIce.BackColor = Color.LightGray;
			}
		}
		
		public void ExtraShot()
		{
			extraShot.Location = new Point(0, 140);
			extraShot.Parent = popupPanel;
			extraShot.BackColor = Color.CornflowerBlue;
			extraShot.Text = "샷추가";
			extraShot.AutoSize = true;
			
			noExtraShot.Location = new Point(60, 140);
			noExtraShot.Parent = popupPanel;
			noExtraShot.Size = new Size(35, 20);
			noExtraShot.Text = "없음";
			noExtraShot.Click += new EventHandler(OnNoExtraClick);
			
			oneExtraShot.Location = new Point(100, 140);
			oneExtraShot.Parent = popupPanel;
			oneExtraShot.Size = new Size(40, 20);
			oneExtraShot.Text = "1샷";
			oneExtraShot.Click += new EventHandler(OnOneExtraClick);
			
			twoExtraShot.Location = new Point(150, 140);
			twoExtraShot.Parent = popupPanel;
			twoExtraShot.Size = new Size(35, 20);
			twoExtraShot.Text = "2샷";
			twoExtraShot.Click += new EventHandler(TwoExtraClick);
		}
		
		public void OnNoExtraClick(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			
			btn.BackColor = Color.CornflowerBlue;
			
			if(oneExtraShot.BackColor == Color.CornflowerBlue)
			{
				oneExtraShot.BackColor = Color.LightGray;
			}
			else if(twoExtraShot.BackColor == Color.CornflowerBlue)
			{
				twoExtraShot.BackColor = Color.LightGray;
			}
		}
		
		public void OnOneExtraClick(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			
			btn.BackColor = Color.CornflowerBlue;
			
			if(noExtraShot.BackColor == Color.CornflowerBlue)
			{
				noExtraShot.BackColor = Color.LightGray;
			}
			else if(twoExtraShot.BackColor == Color.CornflowerBlue)
			{
				twoExtraShot.BackColor = Color.LightGray;
			}
		}
		
		public void TwoExtraClick(object sender, EventArgs e)
		{			
			Button btn = sender as Button;
			
			btn.BackColor = Color.CornflowerBlue;
			
			if(noExtraShot.BackColor == Color.CornflowerBlue)
			{
				noExtraShot.BackColor = Color.LightGray;
			}
			else if(oneExtraShot.BackColor == Color.CornflowerBlue)
			{
				oneExtraShot.BackColor = Color.LightGray;
			}
		}
		
		public void Choice()
		{
			selectBtn.Location = new Point(50, 180);
			selectBtn.Parent = popupPanel;
			selectBtn.Size = new Size(50, 30);
			selectBtn.Text = "담기";
			selectBtn.BackColor = Color.Gray;
			selectBtn.Click += new EventHandler(OnSelectBtnClick);
			
			cancelBtn.Location = new Point(100, 180);
			cancelBtn.Parent = popupPanel;
			cancelBtn.Size = new Size(50, 30);
			cancelBtn.Text = "취소";
			cancelBtn.BackColor = Color.Gray;
			cancelBtn.Click += new EventHandler(OnCancelBtnClick);
		}
		
		public void OnSelectBtnClick(object sender, EventArgs e)
		{
			int extra = 0;
			
			if(soyMilkBtn.BackColor == Color.CornflowerBlue)
			{
				extra += 500;
			}
			
			if(oneExtraShot.BackColor == Color.CornflowerBlue)
			{
				extra += 500;
			}
			else if(twoExtraShot.BackColor == Color.CornflowerBlue)
			{
				extra += 1000;
			}
			
			Console.WriteLine("extra : " + extra);
			
			Purchase.CreateSelectedItems(selectedName, extra);
			popupForm.Close();
		}
		
		public void OnCancelBtnClick(object sender, EventArgs e)
		{
			popupForm.Close();
		}
	}
}