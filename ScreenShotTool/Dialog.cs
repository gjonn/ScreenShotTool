using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Live;

namespace ScreenShotTool
{
    public partial class Dialog : Form
    {
        public Dialog()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // makes the picture the size of the picturebox
            pictureBox1.Image = Form1.bit; // sets image to picturebox
            this.Text = "Screenshot"; // changes form name
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // saves the image to a file
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Images|*.png";
            ImageFormat format = ImageFormat.Png;
            if (sv.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Form1.bit.Save(sv.FileName, format);

            }
        }

    }
}
