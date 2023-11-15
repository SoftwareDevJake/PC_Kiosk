using System;
using System.Drawing;
using System.Windows.Forms;

using PurchaseBar;
using Popup;

namespace Menu
{
	public static class Items
	{
		// Menu panel
		public static  Panel menuPanel;
		// Creating a control of buttons
		public static  Control[] menuBtns;
		// all menu
		public static string[] allMenu = {"아샷추", "아메리카노", "콜드브루", "아인슈페너", "카페라떼", "바닐라라떼", "헤이즐넛라떼", "연유라떼","카페모카", "카푸치노", "카라멜 마끼아또", "쥬스", "쥬스2", "쥬스3", "쥬스4", "쥬스5", "쥬스6", "쥬스7", "쥬스8"};
		// name of coffee menu
		public static  string[] coffeeMenu = {"아샷추", "아메리카노", "콜드브루", "아인슈페너"};
		// name of latte menu
		public static string[] latteMenu = {"카페라떼", "바닐라라떼", "헤이즐넛라떼", "연유라떼","카페모카", "카푸치노", "카라멜 마끼아또"};
		// name of juice menu
		public static  string[] juiceMenu = {"쥬스", "쥬스2", "쥬스3", "쥬스4", "쥬스5", "쥬스6", "쥬스7", "쥬스8"};
		
		// img of all
		public static Image[] allMenuImg = {
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/icedShotExtra.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/IcedAmericano.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/coldbrew.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/icedEinspenner.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/icedCafeLatte.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/icedCafeMocha.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/icedCappuccino.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/icedCafeLatte.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/icedCafeLatte.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/icedCafeLatte.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/icedCaramelMacchiato.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/icedEinspenner.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/IcedAmericano.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/coldbrew.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/icedCafeLatte.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/icedCafeMocha.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/icedCappuccino.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/icedCaramelMacchiato.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/icedEinspenner.png")
		};
		// img of coffee menu
		public static  Image[] coffeeMenuImg = {
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/icedShotExtra.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/IcedAmericano.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/coldbrew.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/icedEinspenner.png")
		};
		// img of latte menu
		public static Image[] latteMenuImg = {
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/icedCafeLatte.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/icedCafeMocha.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/icedCappuccino.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/icedCafeLatte.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/icedCafeLatte.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/icedCafeLatte.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/icedCaramelMacchiato.png")
		};
		
		// img of juice menu
		public static Image[] juiceMenuImg = {
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/icedEinspenner.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/IcedAmericano.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/coldbrew.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/icedCafeLatte.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/icedCafeMocha.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/icedCappuccino.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/icedCaramelMacchiato.png"),
			Image.FromFile("/workspace/PC_Kiosk/img/coffee/icedEinspenner.png")
		};
		
		// form from main.cs
		public static Form form;
		
		public static void Mid(Form mainForm)
		{
			Console.WriteLine("Mid Start");
			form = mainForm;
			
			MenuPanel();
			// TODO : it is suppossed to be ALL MENU
			ShowMenu(allMenu, allMenuImg);
		}
		
		public static void MenuPanel()
		{
			// Creating a panel
			menuPanel = new Panel();
			menuPanel.Height = 180;
			menuPanel.Width = 300;
			menuPanel.Location = new Point(-10, 40);
			menuPanel.BackColor = Color.White; // main color
			
			menuPanel.AutoScroll = true;
			ScrollToBottom(menuPanel);
			
			form.Controls.Add(menuPanel);
		}
		
		public static void ScrollToBottom(Panel p){
		  using (Control c = new Control() { Parent = p, Dock = DockStyle.Bottom })
			 {
				p.ScrollControlIntoView(c);
				c.Parent = null;
			 }
		}
		
		public static void AllMenuControl()
		{
			DeleteAllBtns();
			ShowMenu(allMenu, allMenuImg);
		}
		
		public static void CoffeeMenuControl()
		{
			DeleteAllBtns();
			ShowMenu(coffeeMenu, coffeeMenuImg);
		}
		
		public static void LatteMenuControl()
		{
			DeleteAllBtns();
			ShowMenu(latteMenu, latteMenuImg);
		}
		
		public static void JuiceMenuControl()
		{
			DeleteAllBtns();
			ShowMenu(juiceMenu, juiceMenuImg);
		}
		
		public static void ShowMenu(string[] menu, Image[] img)
		{
			//Console.WriteLine("first : " + first.ToString());
			// all the menu btns
			menuBtns = new Control[menu.Length];
			
			int start = 0;
			int floor = 0;
			
			for(int i = 0; i < menu.Length; i++)
			{
				menuBtns[i] = new Button();
				
				var pic = new Bitmap(img[i], 50, 50);
				
				menuBtns[i].BackColor = Color.CornflowerBlue;
				menuBtns[i].BackgroundImage = pic;
				menuBtns[i].ForeColor = Color.CornflowerBlue;
				
				if(i % 4 == 0 && i != 0)
				{
					floor++;
					start = 0;
					menuBtns[i].Location = new Point(30 + (start * 60), 50 * floor);
					menuBtns[i].Parent = menuPanel;
					menuBtns[i].Size = new Size(50, 50);
					menuBtns[i].Text = menu[i];
					menuBtns[i].Click += new EventHandler(OnMenuBtnClick);
				}
				else if(floor == 0)
				{
					menuBtns[i].Location = new Point(30 + (start * 60), 0);
					menuBtns[i].Parent = menuPanel;
					menuBtns[i].Size = new Size(50, 50);
					menuBtns[i].Text = menu[i];
					menuBtns[i].Click += new EventHandler(OnMenuBtnClick);
				}
				else
				{
					menuBtns[i].Location = new Point(30 + (start * 60), 50 * floor);
					menuBtns[i].Parent = menuPanel;
					menuBtns[i].Size = new Size(50, 50);
					menuBtns[i].Text = menu[i];
					menuBtns[i].Click += new EventHandler(OnMenuBtnClick);
				}
				
				start++;
			}
		}
		
		public static void DeleteAllBtns()
		{
			if(menuBtns != null)
			{
				for(int i = 0; i < menuBtns.Length; i++)
				{
					menuPanel.Controls.Remove(menuBtns[i]);
				}
			}
			else
			{
				Console.WriteLine("There are no menuBtns left");
			}
			
		}
		
		public static void OnMenuBtnClick(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			// popup
			PopupDetails popup = new PopupDetails();
			popup.ShowModal(form, btn.Text.ToString());			
		}
	}
}