using System;
using System.Drawing;
using System.Windows.Forms;

using CategoryBar;
using PurchaseBar;
using Menu;

public class MForm : Form {
		public MForm()
		{
			// Category bar part
			Category categoryBar = new Category();
			categoryBar.Top(this);
			
			// Menu part
			Items.Mid(this);
			
			// Bottom Right part
			Purchase purchaseBar = new Purchase();
			purchaseBar.BottomRight(this);

			CenterToScreen();
		}
	}

	class MApplication {
		public static void Main() {
			Application.Run(new MForm());
		}
	}