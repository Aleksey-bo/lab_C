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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2.Forms
{
    public partial class AddUserCardForm : Form
    {
        private toastNotification toast;
        public AddUserCardForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserCard newClient = new UserCard(
                IDGenerator.GenerateRandomId(16),
                textBoxName.Text,
                textBoxEmail.Text,
                textBoxPhone.Text
            );

            PostalCompany.Instance.AddClientCard(newClient);

            toast = new toastNotification();


            this.LocationChanged += MainForm_LocationChanged;

            toast.SetLabelText("Successfully created");
            toast.Show();
        }

        private void MainForm_LocationChanged(object sender, EventArgs e)
        {
            toast.SetPosition(new Point(this.Left, this.Top));
        }
    }
}
