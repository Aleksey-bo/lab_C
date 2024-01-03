using System.Net.Http;
using System.Runtime.InteropServices;

namespace Lab2
{
    public partial class mainform : Form
    {


        public mainform()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            MaximizeBox = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void regular_delivery_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.MaskRegularForm(), sender);
            labelTitle.Text = "Regular delivery";
        }

        private void add_user_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AddUserForm(), sender);
        }

        private void add_user_card_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AddUserCardForm(), sender);
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void freight_delivery_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.MaskFormFreight(), sender);
            labelTitle.Text = "Freight delivery";
        }

        private void DeleteUserbtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DeleteUserForm(), sender);
        }

        private void nameSelect_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void OperationsButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.OperationsForm(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.TaxesForm(), sender);
        }
    }
}