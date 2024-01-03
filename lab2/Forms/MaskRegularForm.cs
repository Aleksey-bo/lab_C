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
    public partial class MaskRegularForm : Form
    {
        public MaskRegularForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Regular_deliveryForm(), sender);
        }

        public void ShowRegularDeliveryForm()
        {
            button1_Click(null, EventArgs.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Regular_delivery_courier(), sender);
        }
    }
}
