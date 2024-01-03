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
    public partial class AddUserForm : Form
    {
        private toastNotification toast;
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ClientCompany newClient = new ClientCompany(
                IDGenerator.GenerateRandomId(16),
                textBox1.Text,
                textBox2.Text
            );

            PostalCompany.Instance.onMessage += PostalCompany.Instance.EventHandlerExistsClient;
            PostalCompany.Instance.AddCompanyClient(newClient);
            //MessageBox.Show($"Successfully created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

            /*PostalCompany.Instance.AddCompanyClient(newClient);

            toast = new toastNotification();
            toast.SetLabelText("User create");
            toast.Show();*/

            this.LocationChanged += MainForm_LocationChanged;
        }

        private void MainForm_LocationChanged(object sender, EventArgs e)
        {
            toast.SetPosition(new Point(this.Left, this.Top));
        }
    }
}
