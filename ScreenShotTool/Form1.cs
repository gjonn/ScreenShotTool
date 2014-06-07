using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ScreenShotTool
{
    public partial class Form1 : Form
    {
        public static Bitmap bit = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height); 
        public Form1()
        {
            InitializeComponent();
            this.Text = "Screenshot Tool";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide(); //hides form so it's not in the screenshot
            timer1.Interval = 200; //200ms delay
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false; //stops timer
            Graphics SS = Graphics.FromImage(bit);
            SS.CopyFromScreen(0, 0, 0, 0, bit.Size);

            // opens screenshot form
            Dialog Dg = new Dialog();
            Dg.ShowDialog();
        }
    }
}
