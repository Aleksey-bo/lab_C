using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2.Forms
{
    public partial class Freight_deliveryForm : Form
    {
        public Freight_deliveryForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            FreightDeliveryHoldForPickup newDelivery = new FreightDeliveryHoldForPickup(
               IDGenerator.GenerateRandomId(16),
               DateTime.Now,
               double.Parse(textBox5.Text),
               decimal.Parse(textBox6.Text),
               textBox1.Text,
               textBox2.Text,
               checkBoxPrice.Checked,
               textBox3.Text,
               textBox4.Text,
               checkBoxPackage.Checked,
               false
            );

            var result = UserPattern.Instance.SendPackage(newDelivery);
            PostalCompany.Instance.WriteLogToFile(newDelivery);

            MessageBox.Show($"Service cost: {result}$", "Payable", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
