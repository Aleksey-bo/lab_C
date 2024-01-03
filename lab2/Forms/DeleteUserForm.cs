using Lb2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2.Forms
{
    public partial class DeleteUserForm : Form
    {
        private toastNotification toast;
        public DeleteUserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var isDeleted = PostalCompany.Instance.RemoveClientCard(textBox1.Text);
            toast = new toastNotification();
            

            this.LocationChanged += MainForm_LocationChanged;

            if (isDeleted)
            {
                toast.SetLabelText("User deleted");
                toast.Show();
            }
            else
            {
                toast.SetImage(Image.FromFile("C:\\Users\\swip swip\\source\\repos\\lab2\\Lab2\\Resources\\error_FILL0_wght400_GRAD0_opsz24.png"), Color.Red);
                toast.SetLabelText("Error when removing the card");
                toast.Show();
            }

            this.Close();
        }

        private void MainForm_LocationChanged(object sender, EventArgs e)
        {
            toast.SetPosition(new Point(this.Left, this.Top));
        }
    }
}
