using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class toastNotification : Form
    {
        public toastNotification()
        {
            InitializeComponent();
        }

        public void SetPosition(Point position)
        {
            this.Location = position;
        }

        public void SetLabelText(string text)
        {
            label1.Text = text;
        }

        public void SetImage(Image image, Color color)
        {
            pictureBox1.Image = image;
            panel1.BackColor = color;
        }
    }
}
