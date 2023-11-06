using System;
using System.Drawing;
using System.Windows.Forms;

class MForm : Form {
    public MForm() {
        
        CenterToScreen();
    }

    void OnExit(object sender, EventArgs e) {
       Close();
    }
}

class MApplication {
    public static void Main() {
        Application.Run(new MForm());
    }
}
