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
    public partial class MaskFormFreight : Form
    {
        public MaskFormFreight()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Freight_deliveryForm(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Freight_delivery_courierForm(), sender);
        }

        public void ShowFreightDeliveryForm()
        {
            button1_Click(null, EventArgs.Empty);
        }
    }
}
