using System;
using System.Drawing;
using System.Windows.Forms;

using CategoryBar;
using Menu;

public class MForm : Form {
		public MForm()
		{
			// Category bar part
			Category bar = new Category();
			bar.Top(this);
			
			// Menu part
			Items.Mid(this);

			CenterToScreen();
		}
	}

	class MApplication {
		public static void Main() {
			Application.Run(new MForm());
		}
	}